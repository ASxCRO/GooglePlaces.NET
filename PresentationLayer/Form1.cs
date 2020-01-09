using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using DataAccessLayer;
using System.Data.Entity;

namespace PresentationLayer
{
    public partial class Form1 : Form
    {
        private decimal _positionLat;
        private decimal _positionLng;
        PointLatLng point;
        private MapEntities _mapDB;
        private BindingSource _searchedBinding;
        private BindingSource _administrationBinding;
        private BindingSource _savedLocationsBinding;

        private GMapOverlay _markers;
        private GMapOverlay _polygons;

        private DataGridViewImageColumn _AddButton;
        private DataGridViewImageColumn _DeleteButton;
        private DataGridViewImageColumn _ShowOnMapButton;
        private DataGridViewImageColumn _DeleteSavedLocationButton;
        private DataGridViewImageColumn _ShowSavedLocationOnMapButton;
        private int _selectedTypeId;
        List<PointLatLng> polyPoints;



        List<Supan_PlaceTypes> placeType;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _searchedBinding = new BindingSource();
            _administrationBinding = new BindingSource();
            _savedLocationsBinding = new BindingSource();

            _mapDB = new MapEntities();
            _AddButton = new DataGridViewImageColumn();
            _DeleteButton = new DataGridViewImageColumn();
            _ShowOnMapButton = new DataGridViewImageColumn();
            _DeleteSavedLocationButton = new DataGridViewImageColumn(); ;
            _ShowSavedLocationOnMapButton = new DataGridViewImageColumn(); ;
            placeType = new List<Supan_PlaceTypes>();
            polyPoints = new List<PointLatLng>();


            dataGridViewAdministration = NapuniGridIzBaze<Supan_PlaceTypes>(dataGridViewAdministration, _administrationBinding, _mapDB.Supan_PlaceTypes);
            dataGridViewSavedLocations = NapuniGridIzBaze<Supan_Places>(dataGridViewSavedLocations, _savedLocationsBinding, _mapDB.Supan_Places);
            UcitajMapu();
            startLocationBox.ReadOnly = true;
            NapuniTypeCombo();
            NapuniTextBoxSuggest();
            kreirajStupac(dataGridViewAdministration, _AddButton, @"images/addType.png", "Dodaj tip");
            kreirajStupac(dataGridViewAdministration, _DeleteButton, @"images/removeType.png", "Izbriši tip");
            kreirajStupac(dataGridViewSearchedPlaces, _ShowOnMapButton, @"images/showOnMap.png", "Uvećaj lokaciju");
            kreirajStupac(dataGridViewSavedLocations, _ShowSavedLocationOnMapButton, @"images/showOnMap.png", "Uvećaj lokaciju"); 
            kreirajStupac(dataGridViewSavedLocations, _DeleteSavedLocationButton, @"images/removeType.png", "Obriši lokaciju"); 
            

        }

        private void gmap_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                point = gmap.FromLocalToLatLng(e.X, e.Y);
                startLocationBox.Text = "Lat: " + point.Lat + ", Lng: " + point.Lng;
                decimal lat = Convert.ToDecimal(point.Lat);
                decimal lng = Convert.ToDecimal(point.Lng);
                _positionLat = decimal.Round(lat, 6, MidpointRounding.AwayFromZero);
                _positionLng = decimal.Round(lng, 6, MidpointRounding.AwayFromZero);
            }
        }

        private void radiusBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (gmap.Overlays.Count == 0)
            {
                gmap.Overlays.Add(_markers);
            }
            else
            {
                _markers.Clear();
                //_polygons.Clear();
                gmap.Overlays.Remove(_markers);
                //gmap.Overlays.Remove(_polygons);
                gmap.Refresh();
            }

            if (startLocationBox.Text == "" || radiusBox.Text == "" || typeCombo.Text == "" || typeCombo.Text == "Odaberi tip lokacije")
            {
                MessageBox.Show("Molimo unesite sve tražene vrijednosti");
            }
            else
            {
                string selectedTypeName = this.typeCombo.GetItemText(this.typeCombo.SelectedItem);
                _selectedTypeId = _mapDB.Supan_PlaceTypes.Where(t => t.TYPE_NAME == selectedTypeName).Select(t => t.TYPE_ID).FirstOrDefault();
                int radius = Convert.ToInt32(radiusBox.Text);
                List<Supan_Places> places = null;
                try
                {
                    places = PlaceRepository.GetPlaces(_selectedTypeId, _positionLat, _positionLng, radius);
                }
                catch (Exception)
                {
                    MessageBox.Show("Tip lokacije ili ne postoji ili vam pretraživanje tog tipa lokacije nije omogućeno. Provjerite tipove lokacija u administraciji.");
                    return;
                }
                if (searchOnlyInPolygon.Checked)
                {
                    var polygons = _polygons.Polygons;
                    foreach (var polygon in polygons)
                    {
                        foreach (var place in places.ToList())
                        {
                            bool placeIsInsidePolygon = polygon.IsInside(new PointLatLng((double)place.PLACE_LAT, (double)place.PLACE_LNG));
                            if (!placeIsInsidePolygon)
                            {
                                var placeToRemove = places.Where(p => p.PLACE_LAT == place.PLACE_LAT && p.PLACE_LNG == place.PLACE_LNG).FirstOrDefault();
                                places.Remove(placeToRemove);
                            }
                        }
                        break;
                    }
                }
                dataGridViewSearchedPlaces = NapuniGridListom<Supan_Places>(dataGridViewSearchedPlaces, _searchedBinding, places);
                foreach (var place in places)
                {
                    GMapMarker marker = NapraviMarker(place.PLACE_LAT, place.PLACE_LNG, GMarkerGoogleType.red_dot, _markers);
                    PostaviMarkerToolTip(marker, place.PLACE_NAME, place.PLACE_ADDRESS);
                }
            }
            
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            _markers.Clear();
            _polygons.Clear();
            gmap.Overlays.Remove(_markers);
            gmap.Overlays.Remove(_polygons);
            polyPoints.Clear();
            gmap.Refresh();
            startLocationBox.Text = "";
            radiusBox.Text = "";
            typeCombo.Text = "Odaberi tip lokacije";

            dataGridViewSearchedPlaces.DataSource = null;
        }

        private void UcitajMapu()
        {
            GMapProviders.GoogleMap.ApiKey = @"AIzaSyAbH2_wC74VAkk8SY-MD21MmPE9ZWzkkWg";
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            gmap.MapProvider = GoogleMapProvider.Instance;
            gmap.Position = new PointLatLng(45.213003555994, 15.721435546875);
            gmap.ShowCenter = false;
            _markers = new GMapOverlay("markers");
            _polygons = new GMapOverlay("polygons");

        }

        private GMapMarker NapraviMarker(decimal lat,decimal lng, GMarkerGoogleType markerType, GMapOverlay markers)
        {
            GMapMarker marker =
                        new GMarkerGoogle(
                            new PointLatLng((double)lat, (double)lng),
                            markerType);
            if(tabControl1.SelectedTab == savedLocationsTab)
            {
                Supan_Places place;
                using (var mapDB = new MapEntities())
                {
                    place = mapDB.Supan_Places.Where(p => p.PLACE_LAT == (decimal)marker.Position.Lat && p.PLACE_LNG == (decimal)marker.Position.Lng).FirstOrDefault();
                }
                PostaviMarkerToolTip(marker, place.PLACE_NAME, place.PLACE_ADDRESS);
            }
            _markers.Markers.Add(marker);
            gmap.Overlays.Add(_markers);
            gmap.Refresh();
            return marker;
        }

        private void PostaviMarkerToolTip(GMapMarker marker, string placeName, string placeAddress)
        {
            marker.ToolTipText = "\n" + placeName + placeAddress;
            marker.ToolTip.Fill = Brushes.Black;
            marker.ToolTip.Foreground = Brushes.White;
            marker.ToolTip.Stroke = Pens.Black;
            marker.ToolTip.TextPadding = new Size(25, 17);
            marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
        }

        private DataGridView NapuniGridIzBaze<TEntity>(DataGridView dataGridView, BindingSource bindingSource,DbSet<TEntity> relacija) where TEntity:class
        {
            bindingSource = new BindingSource();
            bindingSource.DataSource = relacija.ToList();
            dataGridView.AutoGenerateColumns = false;
            dataGridView.RowTemplate.Height = 33;

            dataGridView.DataSource = bindingSource;

            return dataGridView;
        }

        private DataGridView NapuniGridListom<T>(DataGridView dataGridView, BindingSource bindingSource, List<T> lista) where T:class
        {
            bindingSource = new BindingSource();
            bindingSource.DataSource = lista;
            dataGridView.AutoGenerateColumns = false;
            dataGridView.RowTemplate.Height = 33;
            dataGridView.DataSource = bindingSource;
            return dataGridView;
        }

        private void NapuniTypeCombo()
        {
            //typeCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            typeCombo.SelectedIndex = -1;
            typeCombo.AutoCompleteMode = AutoCompleteMode.Suggest;
            typeCombo.AutoCompleteSource = AutoCompleteSource.ListItems;
            var omoguceniTipoviLokacija = _mapDB.Supan_PlaceTypes.Where(t => t.TYPE_ALLOWED == true).ToList();
            typeCombo.DataSource = omoguceniTipoviLokacija;
            typeCombo.DisplayMember = "TYPE_NAME";
            typeCombo.Text = "Odaberi tip lokacije";
        }

        public void kreirajStupac(DataGridView dataGridView,DataGridViewImageColumn button, string lokacijaSlike, string nazivKolone)
        {
            button = new DataGridViewImageColumn();
            button.Name = nazivKolone;
            button.Image = Image.FromFile(lokacijaSlike);
            button.Width = 33;
            button.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView.Columns.Add(button);
            button.Frozen = true;
        }

        private void dataGridViewAdministration_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var dataGridViewAdministrationBySender = (DataGridView)sender;
            var column = dataGridViewAdministrationBySender.Columns[e.ColumnIndex];

            if(column.Name == "Dodaj tip" & e.RowIndex>-1)
            {
                string typeName = (string)dataGridViewAdministration.Rows[e.RowIndex].Cells["typeName"].Value;
                Supan_PlaceTypes placeType = _mapDB.Supan_PlaceTypes.Where(t => t.TYPE_NAME == typeName).FirstOrDefault();
                if(placeType.TYPE_ALLOWED == true)
                {
                    MessageBox.Show("Taj tip lokacije već možete pretraživati ( " + typeName + " )");
                    return;
                }
                placeType.TYPE_ALLOWED = true;
                _mapDB.SaveChanges();
                NapuniTypeCombo();
                MessageBox.Show("Od sad možete pretraživati sljedeći tip lokacije: " + typeName);
            }
            else if(column.Name == "Izbriši tip" & e.RowIndex > -1)
            {
                string typeName = (string)dataGridViewAdministration.Rows[e.RowIndex].Cells["typeName"].Value;
                Supan_PlaceTypes placeType = _mapDB.Supan_PlaceTypes.Where(t => t.TYPE_NAME == typeName).FirstOrDefault();
                if (placeType.TYPE_ALLOWED == false)
                {
                    MessageBox.Show("Taj tip lokacije je već onemogućen za pretraživanje ( " + typeName + " )");
                    return;
                }
                placeType.TYPE_ALLOWED = false;
                _mapDB.SaveChanges();
                NapuniTypeCombo();
                MessageBox.Show("Od sad više ne možete pretraživati sljedeći tip lokacije: " + typeName);
            }
        }

        private void searchValueButton_Click(object sender, EventArgs e)
        {
            bool rowFound = false;
            string searchValue = searchValueBox.Text;
            dataGridViewAdministration.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dataGridViewAdministration.Rows)
                {
                    row.Selected = false;
                    if (row.Cells[0].Value.ToString().ToLower().Equals(searchValue.ToLower()))
                    {
                        rowFound = true;
                        row.Selected = true;
                        dataGridViewAdministration.FirstDisplayedScrollingRowIndex = dataGridViewAdministration.SelectedRows[0].Index;
                    }
                }
                if(rowFound == false)
                {
                    MessageBox.Show("Ne postoji takav tip lokacije u bazi podataka. Molimo pokušajte ponovno");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            
        }

        private void dataGridViewSearchedPlaces_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var dataGridViewSearchedLocationsBySender = (DataGridView)sender;
            var column = dataGridViewSearchedLocationsBySender.Columns[e.ColumnIndex];

            if (column.Name == "Uvećaj lokaciju" & e.RowIndex > -1)
            {
                decimal lat = (decimal)dataGridViewSearchedPlaces.Rows[e.RowIndex].Cells["Lat"].Value;
                decimal lng = (decimal)dataGridViewSearchedPlaces.Rows[e.RowIndex].Cells["Lng"].Value;
                gmap.Position = new PointLatLng((double)lat,(double) lng);
                gmap.Zoom = 30;
            }
        }

        private void OtvoriFormuZaSpremanjeLokacije(GMapMarker item)
        {
            int typeId = _selectedTypeId;
            string placeName = String.Empty;
            string placeAddress = String.Empty;
            foreach (DataGridViewRow row in dataGridViewSearchedPlaces.Rows)
            {
                if(Convert.ToDecimal(row.Cells[2].Value) == (decimal)item.Position.Lat && Convert.ToDecimal(row.Cells[3].Value) == (decimal)item.Position.Lng)
                {
                    placeName = row.Cells[0].Value.ToString();
                    placeAddress = row.Cells[1].Value.ToString();
                }
            }
            var placeToSave = new Supan_Places
            {
                PLACE_NAME = placeName,
                PLACE_ADDRESS = placeAddress,
                PLACE_LAT = (decimal)item.Position.Lat,
                PLACE_LNG = (decimal)item.Position.Lng,
                PLACE_TYPE = typeId
            };
            using (FormSavePlace formSavePlace = new FormSavePlace())
            {
                formSavePlace.place = placeToSave;
                formSavePlace.ShowDialog();
                if(formSavePlace.savingSuccessfull)
                {
                    dataGridViewSavedLocations = NapuniGridIzBaze<Supan_Places>(dataGridViewSavedLocations, _savedLocationsBinding, _mapDB.Supan_Places);
                }
            }
        }

        private void searchValueBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchValueButton_Click(this, new EventArgs());
            }
        }

        private void NapuniTextBoxSuggest()
        {
            searchValueBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            searchValueBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();
            foreach (DataGridViewRow row in dataGridViewAdministration.Rows)
            {
                col.Add(row.Cells[0].Value.ToString());
            }
            searchValueBox.AutoCompleteCustomSource = col;
        }

        private void gmap_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                OtvoriFormuZaSpremanjeLokacije(item);
            }
        }

        private void dataGridViewSavedLocations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var dataGridViewSearchedLocationsBySender = (DataGridView)sender;
            var column = dataGridViewSearchedLocationsBySender.Columns[e.ColumnIndex];

            if (column.Name == "Uvećaj lokaciju" & e.RowIndex > -1)
            {
                decimal lat = (decimal)dataGridViewSavedLocations.Rows[e.RowIndex].Cells["latitude"].Value;
                decimal lng = (decimal)dataGridViewSavedLocations.Rows[e.RowIndex].Cells["longitude"].Value;
                gmap.Position = new PointLatLng((double)lat, (double)lng);
                gmap.Zoom = 30;
                NapraviMarker(lat, lng, GMarkerGoogleType.lightblue,_markers);
                tabControl1.SelectedTab = mapTab;

            }
            else if (column.Name == "Obriši lokaciju" & e.RowIndex > -1)
            {
                try
                {
                    string placeName = (string)dataGridViewSavedLocations.Rows[e.RowIndex].Cells["placeName"].Value;
                    Supan_Places place = _mapDB.Supan_Places.Where(p => p.PLACE_NAME == placeName).FirstOrDefault();
                    _mapDB.Supan_Places.Remove(place);
                    _mapDB.SaveChanges();
                    dataGridViewSavedLocations = NapuniGridIzBaze<Supan_Places>(dataGridViewSavedLocations, _savedLocationsBinding, _mapDB.Supan_Places);
                    MessageBox.Show("Uspješno ste obrisali lokaciju: " + placeName);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Podatci nisu pravilno učitani. Brisanje nije izvršeno.\n\n " + ex.Message);

                }
            }
        }

        private void btnAddPoly_Click(object sender, EventArgs e)
        {
            var polygon = new GMapPolygon(polyPoints, "My Area")
            {
                Fill = new SolidBrush(Color.FromArgb(50, Color.Red)),
                Stroke = new Pen(Color.Red, 1)
            };
            _polygons.Polygons.Add(polygon);
            gmap.Overlays.Add(_polygons);
            gmap.Refresh();
            gmap.Zoom = 20;
            gmap.Zoom = 13;
        }

        private void btnAddPointToPoly_Click(object sender, EventArgs e)
        {
            polyPoints.Add(point);
            GMapMarker marker = NapraviMarker(_positionLat, _positionLng, GMarkerGoogleType.gray_small, _markers);
            PostaviMarkerToolTip(marker, "Granična točka područja", "Poligon");
            gmap.Zoom = 20;
            gmap.Zoom = 15;
            gmap.Refresh();
            MessageBox.Show("Uspješno ste dodali vanjsku točku za kreiranje područja!");
        }

        private void drawRegion(int id)
        {
            polyPoints.Clear();
            _markers.Clear();
            _polygons.Clear();
            gmap.Overlays.Remove(_markers);
            gmap.Overlays.Remove(_polygons);
            gmap.Refresh();

            List<Supan_RegionPoints> RegionPoints;
            using (var mapDB = new MapEntities())
            {
                RegionPoints = mapDB.Supan_RegionPoints.Where(r => r.ID_REGIJE == id).ToList();
            }
            foreach (var regionPoint in RegionPoints)
            {
                polyPoints.Add(new PointLatLng((double)regionPoint.LAT, (double)regionPoint.LNG));
            }
            var polygon = new GMapPolygon(polyPoints, "My Area")
            {
                Fill = new SolidBrush(Color.FromArgb(50, Color.Red)),
                Stroke = new Pen(Color.Red, 1)
            };
            _polygons.Polygons.Add(polygon);
            gmap.Overlays.Add(_polygons);
            gmap.Refresh();
            gmap.Zoom = gmap.Zoom - 0.01;
        }

        private void drawSlavonijaRegion(object sender, EventArgs e)
        {
            drawRegion(1);
        }

        private void drawSredRHRegion(object sender, EventArgs e)
        {
            drawRegion(2);
        }

        private void drawIstraRegion(object sender, EventArgs e)
        {
            drawRegion(3);
        }

        private void drawPrimorjeRegion(object sender, EventArgs e)
        {
            drawRegion(4);
        }

        private void drawDalmacijaRegion(object sender, EventArgs e)
        {
            drawRegion(5);
        }
    }
}


//GMapOverlay polygons = new GMapOverlay("polygons");
//List<PointLatLng> points = new List<PointLatLng>();
//points.Add(new PointLatLng(48.866383, 2.323575));
//points.Add(new PointLatLng(48.863868, 2.321554));
//points.Add(new PointLatLng(48.861017, 2.330030));
//points.Add(new PointLatLng(48.863727, 2.331918));
//GMapPolygon polygon = new GMapPolygon(points, "Jardin des Tuileries");
//polygons.Polygons.Add(polygon);
//gmap.Overlays.Add(polygons);


//GMapMarker marker =
//    new GMarkerGoogle(
//        new PointLatLng(48.8617774, 2.349272),
//        GMarkerGoogleType.red_dot);
//marker.ToolTipText = "hello\nout there";
//marker.ToolTip.Fill = Brushes.Black;
//marker.ToolTip.Foreground = Brushes.White;
//marker.ToolTip.Stroke = Pens.Black;
//marker.ToolTip.TextPadding = new Size(20, 20);
//marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
//markers.Markers.Add(marker);