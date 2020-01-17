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
using System.Text.RegularExpressions;
using System.Data.Entity.Core.Objects;

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
        private BindingSource _savedPolygonsBinding;

        private GMapOverlay _markers;
        private GMapOverlay _polygons;

        private DataGridViewImageColumn _AddButton;
        private DataGridViewImageColumn _DeleteButton;
        private DataGridViewImageColumn _ShowOnMapButton;
        private DataGridViewImageColumn _DeleteSavedLocationButton;
        private DataGridViewImageColumn _ShowSavedLocationOnMapButton;
        private DataGridViewImageColumn _toggleEditLocationForm;

        private DataGridViewImageColumn _DeleteSavedPolygonsButton;
        private DataGridViewImageColumn _ShowSavedPolygonsOnMapButton;
        private DataGridViewImageColumn _toggleEditPolygonForm;
        private int _selectedTypeId;
        private GMapPolygon _polygon;
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
            _savedPolygonsBinding = new BindingSource();

            _mapDB = new MapEntities();
            _AddButton = new DataGridViewImageColumn();
            _DeleteButton = new DataGridViewImageColumn();
            _ShowOnMapButton = new DataGridViewImageColumn();
            _DeleteSavedLocationButton = new DataGridViewImageColumn(); 
            _ShowSavedLocationOnMapButton = new DataGridViewImageColumn();
            _DeleteSavedPolygonsButton = new DataGridViewImageColumn();
            _ShowSavedPolygonsOnMapButton = new DataGridViewImageColumn();
            _toggleEditLocationForm = new DataGridViewImageColumn();
            _toggleEditPolygonForm = new DataGridViewImageColumn();
            placeType = new List<Supan_PlaceTypes>();
            polyPoints = new List<PointLatLng>();


            dataGridViewAdministration = NapuniGridIzBaze<Supan_PlaceTypes>(dataGridViewAdministration, _administrationBinding, _mapDB.Supan_PlaceTypes);
            dataGridViewSavedLocations = NapuniGridIzBaze<Supan_Places>(dataGridViewSavedLocations, _savedLocationsBinding, _mapDB.Supan_Places);
            dataGridViewSavedPolygons = NapuniGridIzBaze<Supan_Regions>(dataGridViewSavedPolygons, _savedPolygonsBinding, _mapDB.Supan_Regions);

            UcitajMapu();
            startLocationBox.ReadOnly = true;
            polyPointsReadyTextBox.ReadOnly = true;
            polyPointsReadyTextBox.TextAlign = HorizontalAlignment.Center;
            polyPointsReadyTextBox.Text = "" + polyPoints.Count();
            currentLatTextBox.ReadOnly = true;
            currentLatTextBox.TextAlign = HorizontalAlignment.Center;
            currentLngTextBox.ReadOnly = true;
            currentLngTextBox.TextAlign = HorizontalAlignment.Center;
            var lat = decimal.Round((decimal)gmap.Position.Lat, 6, MidpointRounding.AwayFromZero);
            currentLatTextBox.Text = "" + lat;
            var lng = decimal.Round((decimal)gmap.Position.Lng, 6, MidpointRounding.AwayFromZero);
            currentLngTextBox.Text = "" + lng;
            NapuniTypeCombo();
            NapuniPolyCombo();
            NapuniTextBoxSuggest(searchLocationsInGridBox, dataGridViewSavedLocations);
            NapuniTextBoxSuggest(searchPolygonsInGridBox, dataGridViewSavedPolygons);
            NapuniTextBoxSuggest(searchValueBox, dataGridViewAdministration);
            kreirajStupac(dataGridViewAdministration, _AddButton, @"images/addType.png", "Dodaj tip");
            kreirajStupac(dataGridViewAdministration, _DeleteButton, @"images/removeType.png", "Izbriši tip");
            kreirajStupac(dataGridViewSearchedPlaces, _ShowOnMapButton, @"images/showOnMap.png", "Uvećaj lokaciju");
            kreirajStupac(dataGridViewSavedLocations, _ShowSavedLocationOnMapButton, @"images/showOnMap.png", "Uvećaj lokaciju");
            kreirajStupac(dataGridViewSavedLocations, _toggleEditLocationForm, @"images/edit.png", "Uredi detalje");

            kreirajStupac(dataGridViewSavedLocations, _DeleteSavedLocationButton, @"images/removeType.png", "Obriši lokaciju");
  
            kreirajStupac(dataGridViewSavedPolygons, _ShowSavedPolygonsOnMapButton, @"images/showOnMap.png", "Prikaži poligon");
            kreirajStupac(dataGridViewSavedPolygons, _toggleEditPolygonForm, @"images/edit.png", "Uredi detalje");

            kreirajStupac(dataGridViewSavedPolygons, _DeleteSavedPolygonsButton, @"images/removeType.png", "Obriši poligon");

  
        }

        private void gmap_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                point = gmap.FromLocalToLatLng(e.X, e.Y);
                decimal lat = Convert.ToDecimal(point.Lat);
                decimal lng = Convert.ToDecimal(point.Lng);
                _positionLat = decimal.Round(lat, 6, MidpointRounding.AwayFromZero);
                _positionLng = decimal.Round(lng, 6, MidpointRounding.AwayFromZero);
                startLocationBox.Text = "Lat: " + Convert.ToString(_positionLat).Replace(",",".") + ", Lng: " + Convert.ToString(_positionLng).Replace(",", ".");

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
            _markers.Markers.Clear();
            _polygons.Polygons.Clear();
            gmap.Overlays.Remove(_markers);
            gmap.Overlays.Remove(_polygons);
            polyPoints.Clear();
            polyPointsReadyTextBox.Text = "" + polyPoints.Count();
            gmap.Refresh();
            startLocationBox.Text = "";
            radiusBox.Text = "";
            typeCombo.Text = "Odaberi tip lokacije";

            dataGridViewSearchedPlaces.DataSource = null;
        }

        private void UcitajMapu()
        {
            GMapProviders.GoogleMap.ApiKey = @"AIzaSyBSuPs2jtLhJs-9BHt-4iIZhABawlJvHhs";
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            gmap.MapProvider = GoogleMapProvider.Instance;
            gmap.Position = new PointLatLng(45.213003555994, 15.721435546875);
            gmap.ShowCenter = false;
            _markers = new GMapOverlay("markers");
            _polygons = new GMapOverlay("polygons");
            gmap.Overlays.Add(_markers);

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
            gmap.Overlays.Remove(_markers);
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

        private DataGridView NapuniGridIzBaze<TEntity>(DataGridView dataGridView, BindingSource bindingSourc, DbSet<TEntity> relacija) where TEntity : class
        {
            bindingSourc = new BindingSource();
            bindingSourc.DataSource = relacija.ToList();
            bindingSourc.ResetBindings(true);
            dataGridView.AutoGenerateColumns = false;
            dataGridView.RowTemplate.Height = 33;

            dataGridView.DataSource = bindingSourc;
            return dataGridView;
        }

        private DataGridView NapuniGridListom<T>(DataGridView dataGridView, BindingSource bindingSourc, List<T> lista) where T:class
        {
            bindingSourc = new BindingSource();
            bindingSourc.DataSource = lista;
            bindingSourc.ResetBindings(true);
            dataGridView.AutoGenerateColumns = false;
            dataGridView.RowTemplate.Height = 33;
            dataGridView.DataSource = bindingSourc;
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

        private void NapuniPolyCombo()
        {
            //typeCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            polyCombo.SelectedIndex = -1;
            polyCombo.AutoCompleteMode = AutoCompleteMode.Suggest;
            polyCombo.AutoCompleteSource = AutoCompleteSource.ListItems;
            var regijeuBazi = _mapDB.Supan_Regions.ToList();
            polyCombo.DataSource = regijeuBazi;
            polyCombo.DisplayMember = "NAZIV_REGIJE";
            polyCombo.Text = "";
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
                PLACE_LAT = Convert.ToDecimal(string.Format("{0:N6}", item.Position.Lat)),
                PLACE_LNG = Convert.ToDecimal(string.Format("{0:N6}", item.Position.Lng)),
                PLACE_TYPE = typeId
            };
            using (FormSavePlace formSavePlace = new FormSavePlace())
            {
                formSavePlace.place = placeToSave;
                formSavePlace.ShowDialog();
                if(formSavePlace.savingSuccessfull)
                {
                    dataGridViewSavedLocations = NapuniGridIzBaze<Supan_Places>(dataGridViewSavedLocations, _savedLocationsBinding, _mapDB.Supan_Places);
                    NapuniTextBoxSuggest(searchLocationsInGridBox, dataGridViewSavedLocations);
                }
                formSavePlace.Hide();
            }
        }

        private void searchValueBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchValueButton_Click(this, new EventArgs());
            }
        }

        private void NapuniTextBoxSuggest( TextBox searchBoxP, DataGridView dataGridView)
        {
            searchBoxP.AutoCompleteMode = AutoCompleteMode.Suggest;
            searchBoxP.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if(dataGridView == dataGridViewSavedLocations)
                {
                    string grad = row.Cells[2].Value.ToString().Split(',')[1];
                    grad = Regex.Replace(grad, @"\s+", "");
                    col.Add(grad);
                }
                else
                {
                    col.Add(row.Cells[0].Value.ToString());
                }
            }
            searchBoxP.AutoCompleteCustomSource = col;
        }

        private void gmap_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            Supan_Places place = null;
            if (e.Button == MouseButtons.Left)
            {
                decimal lat = Convert.ToDecimal(string.Format("{0:N6}", item.Position.Lat));
                decimal lng = Convert.ToDecimal(string.Format("{0:N6}", item.Position.Lng));
                using (var mapDB = new MapEntities())
                {
                    place = mapDB.Supan_Places.Where(p => p.PLACE_LAT ==  lat && p.PLACE_LNG == lng).FirstOrDefault();
                }
                if (place == null)
                {
                 OtvoriFormuZaSpremanjeLokacije(item);
                }
                else
                {
                    MessageBox.Show("Lokacija je već spremljena!");
                }
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
                    NapuniTextBoxSuggest(searchLocationsInGridBox, dataGridViewSavedLocations);
                    MessageBox.Show("Uspješno ste obrisali lokaciju: " + placeName);
                    NapuniPolyCombo();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Podatci nisu pravilno učitani. Brisanje nije izvršeno.\n\n " + ex.Message);

                }
            }
            else if (column.Name == "Uredi detalje" & e.RowIndex > -1)
            {
                var placeName = (string)dataGridViewSavedLocations.Rows[e.RowIndex].Cells["placeName"].Value;
                using (FormEditPlace formEditPlace = new FormEditPlace())
                {
                    formEditPlace.placeToEdit =_mapDB.Supan_Places.Where(p => p.PLACE_NAME == placeName).FirstOrDefault();
                    formEditPlace.ShowDialog();

                    if (formEditPlace.savingSuccessFull)
                    {
                        using (var mapDB = new MapEntities())
                        {
                            dataGridViewSavedLocations = NapuniGridIzBaze<Supan_Places>     (dataGridViewSavedLocations, _savedLocationsBinding, mapDB.Supan_Places);
                        }

                        NapuniTextBoxSuggest(searchLocationsInGridBox, dataGridViewSavedLocations);
                    }
                }
            }
        }

        private void btnAddPoly_Click(object sender, EventArgs e)
        {
            if (polyCombo.Text == "")
            {
                _markers.Markers.Clear();
                gmap.Overlays.Remove(_polygons);
                _polygons.Clear();
                _polygons.Polygons.Clear();

                gmap.Refresh();
                bool alreadyExists = false;
                _polygon = new GMapPolygon(polyPoints, "My Area")
                {
                    Fill = new SolidBrush(Color.FromArgb(50, Color.Red)),
                    Stroke = new Pen(Color.Red, 1)
                };
                foreach (var poly in _polygons.Polygons)
                {
                    alreadyExists = ((poly.From == _polygon.From) && (poly.To == _polygon.To)) ? true : false;
                    if (alreadyExists)
                    {
                        break;
                    }
                }
                if (alreadyExists == false)
                {
                    _polygons.Polygons.Add(_polygon);
                    _polygon.IsHitTestVisible = true;
                    gmap.Overlays.Add(_polygons);
                    gmap.Overlays.Remove(_markers);
                    gmap.Refresh();
                    gmap.Zoom = gmap.Zoom + 0.01;

                }
                else
                {
                    MessageBox.Show("Poligon koji želite nacrtati već je nacrtan.");
                }
            }
            else
            {
                var region = _mapDB.Supan_Regions.Where(r => r.NAZIV_REGIJE == polyCombo.Text).FirstOrDefault();
                var regionPoints = _mapDB.Supan_RegionPoints.Where(rp => rp.ID_REGIJE == region.ID).ToList();
                if (region != null)
                {
                    int brojJednakihTocaka = 0;
                    bool alreadyExists = false;
                    foreach (var poly in _polygons.Polygons)
                    {
                        foreach (var point in poly.Points)
                        {
                            foreach (var regionPoint in regionPoints)
                            {
                                var lat = decimal.Round((decimal)point.Lat, 6, MidpointRounding.AwayFromZero);
                                var lng = decimal.Round((decimal)point.Lng, 6, MidpointRounding.AwayFromZero);
                                if (lat == regionPoint.LAT && lng == regionPoint.LNG)
                                    brojJednakihTocaka++;
                            }
                        }
                        if(brojJednakihTocaka == poly.Points.Count() && brojJednakihTocaka == regionPoints.Count())
                        {
                            alreadyExists = true;
                            break;
                        }
                    }
                    if (alreadyExists == false)
                    {
                        polyPoints.Clear();
                        drawRegion(region.ID);
                        polyPoints.Clear();
                        polyPointsReadyTextBox.Text = "" + polyPoints.Count();
                    }
                    else
                    {
                        MessageBox.Show("Poligon koji želite nacrtati već je nacrtan.");
                    }

                }
                else
                {
                    MessageBox.Show("Poligon koji ste odabrali/unijeli ne postoji.");
                }
            }
        }

        private void btnAddPointToPoly_Click(object sender, EventArgs e)
        {
            if(!(point.Lat==0) && !(point.Lat == 0))
            {
                polyPoints.Add(point);
                polyPointsReadyTextBox.Text = "" + polyPoints.Count();
                GMapMarker marker = NapraviMarker(_positionLat, _positionLng, GMarkerGoogleType.gray_small, _markers);
                PostaviMarkerToolTip(marker, "Granična točka područja", "\nPoligon");
                gmap.Refresh();
            }
            else
            {
                MessageBox.Show("Prvo morate odabrati graničnu točku za kreiranje područja.");
            }

        }

        private void drawRegion(int id)
        {
            polyPoints.Clear();
            polyPointsReadyTextBox.Text = "" + polyPoints.Count();
            _markers.Markers.Clear();
            _polygons.Polygons.Clear();
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
            gmap.Zoom = 11;
            gmap.Zoom = gmap.Zoom + 0.01;
            gmap.Position = new PointLatLng((double)RegionPoints[0].LAT, (double)RegionPoints[0].LNG);

        }

        private void gmap_OnPolygonDoubleClick(GMapPolygon item, MouseEventArgs e)
        {
            using (FormSavePolygon formSavePolygon = new FormSavePolygon(_polygon))
            {
                formSavePolygon.ShowDialog();
                if (formSavePolygon.savingSuccessfull)
                {
                    dataGridViewSavedPolygons = NapuniGridIzBaze<Supan_Regions>(dataGridViewSavedPolygons, _savedPolygonsBinding, _mapDB.Supan_Regions);
                    NapuniTextBoxSuggest(searchPolygonsInGridBox, dataGridViewSavedPolygons);
                }
                NapuniPolyCombo();
                formSavePolygon.Hide();
            }
        }

        private void dataGridViewSavedPolygons_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var dataGridViewSavedPolygonsBySender = (DataGridView)sender;
            var column = dataGridViewSavedPolygonsBySender.Columns[e.ColumnIndex];
            Supan_Regions region;
            using (var mapDB = new MapEntities())
            {
                string nazivOdabraneRegije = (string)dataGridViewSavedPolygons.Rows[e.RowIndex].Cells["RegionName"].Value;
                string opisOdabraneRegije = (string)dataGridViewSavedPolygons.Rows[e.RowIndex].Cells["OpisRegije"].Value;
                region = mapDB.Supan_Regions.Where(r => r.NAZIV_REGIJE == nazivOdabraneRegije && r.OPIS_REGIJE == opisOdabraneRegije).FirstOrDefault();
            }
            if (column.Name == "Prikaži poligon" & e.RowIndex > -1)
            {
                drawRegion(region.ID);
                tabControl1.SelectedTab = mapTab;
            }
            else if (column.Name == "Obriši poligon" & e.RowIndex > -1)
            {
                try
                {
                    var polyPointsForRemoval = _mapDB.Supan_RegionPoints.Where(rp => rp.ID_REGIJE == region.ID).ToList();
                    if(polyPointsForRemoval.Count != 0)
                    {
                        foreach (var point in polyPointsForRemoval)
                        {
                            _mapDB.Supan_RegionPoints.Remove(point);
                        }
                    }
                    var regionToRemove = _mapDB.Supan_Regions.Where(r => r.ID == region.ID).FirstOrDefault();
                    _mapDB.Supan_Regions.Remove(regionToRemove);
                    _mapDB.SaveChanges();
                    dataGridViewSavedPolygons = NapuniGridIzBaze<Supan_Regions>(dataGridViewSavedPolygons, _savedPolygonsBinding, _mapDB.Supan_Regions);
                    
                    NapuniTextBoxSuggest(searchPolygonsInGridBox, dataGridViewSavedPolygons);
                    
                    MessageBox.Show("Uspješno ste obrisali poligon: " + region.NAZIV_REGIJE);
                    gmap.Overlays.Remove(_polygons);
                    _polygons.Polygons.Clear();
                    _polygons.Clear();
                    NapuniPolyCombo();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Došlo je do greške. Brisanje nije izvršeno.\n\n " + ex.Message);
                }
            }
        }
        private void gmap_OnMapZoomChanged()
        {
            var lat = decimal.Round((decimal)gmap.Position.Lat, 6, MidpointRounding.AwayFromZero);
            currentLatTextBox.Text = "" + Convert.ToString(lat).Replace(",", ".");
            var lng = decimal.Round((decimal)gmap.Position.Lng, 6, MidpointRounding.AwayFromZero);
            currentLngTextBox.Text = "" + Convert.ToString(lng).Replace(",", ".");
        }

        private void btnSearchLocationsInGrid_Click(object sender, EventArgs e)
        {
            bool rowFound = false;
            string searchValue = searchLocationsInGridBox.Text;
            dataGridViewSavedLocations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dataGridViewSavedLocations.Rows)
                {
                    row.Selected = false;
                    if (row.Cells[0].Value.ToString().ToLower().Equals(searchValue.ToLower()))
                    {
                        rowFound = true;
                        row.Selected = true;
                        dataGridViewSavedLocations.FirstDisplayedScrollingRowIndex = dataGridViewSavedLocations.SelectedRows[0].Index;
                    }
                }
                if (rowFound == false)
                {
                    MessageBox.Show("Unešena lokacija ne postoji u bazi podataka!");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnSearchPolygonsInGrid_Click(object sender, EventArgs e)
        {
            bool rowFound = false;
            string searchValue = searchPolygonsInGridBox.Text;
            dataGridViewSavedPolygons.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dataGridViewSavedPolygons.Rows)
                {
                    row.Selected = false;
                    if (row.Cells[0].Value.ToString().ToLower().Equals(searchValue.ToLower()))
                    {
                        rowFound = true;
                        row.Selected = true;
                        dataGridViewSavedPolygons.FirstDisplayedScrollingRowIndex = dataGridViewSavedPolygons.SelectedRows[0].Index;
                    }
                }
                if (rowFound == false)
                {
                    MessageBox.Show("Unešeni poligon ne postoji u bazi podataka!");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnSearchLocationsInGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearchLocationsInGrid_Click(this, new EventArgs());
            }
        }

        private void btnSearchPolygonsInGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearchPolygonsInGrid_Click(this, new EventArgs());
            }
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