using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;
using MoreLinq;
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

            placeType = new List<Supan_PlaceTypes>();
            polyPoints = new List<PointLatLng>();
            using (var mapDB = new MapEntities())
            {
                dataGridViewAdministration = NapuniGridIzBaze<Supan_PlaceTypes>(dataGridViewAdministration, mapDB.Supan_PlaceTypes);
                dataGridViewSavedLocations = NapuniGridIzBaze<Supan_Places>(dataGridViewSavedLocations, mapDB.Supan_Places);
                dataGridViewSavedPolygons = NapuniGridIzBaze<Supan_Regions>(dataGridViewSavedPolygons, mapDB.Supan_Regions);
            }

            
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
            NapuniSavedLocationsTypeCombo();
            NapuniTextBoxSuggest(searchLocationsCityInGridBox, dataGridViewSavedLocations);
            NapuniTextBoxSuggest(searchLocationsNameInGridBox, dataGridViewSavedLocations);
            NapuniTextBoxSuggest(searchPolygonsNameInGridBox, dataGridViewSavedPolygons);
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

            dataGridViewAdministration.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

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
                gmap.Overlays.Remove(_markers);
                gmap.Refresh();
            }

            if (startLocationBox.Text == "" || radiusBox.Text == "" || typeCombo.Text == "")
            {
                MessageBox.Show("Molimo unesite sve tražene vrijednosti");
            }
            else
            {
                List<int> selectedTypeIDs = null;
                string selectedTypeName = this.typeCombo.GetItemText(this.typeCombo.SelectedItem);

                using (var mapDB = new MapEntities())
                {
                    if (typeCombo.Text == "Svi tipovi")
                    {
                        selectedTypeIDs = mapDB.Supan_PlaceTypes.Where(t=>t.TYPE_ALLOWED == true).Select(t => t.TYPE_ID).ToList();
                    }
                    else
                    {
                        _selectedTypeId = mapDB.Supan_PlaceTypes.Where(t => t.TYPE_NAME == selectedTypeName).Select(t => t.TYPE_ID).FirstOrDefault();
                    }
                }

                int radius = Convert.ToInt32(radiusBox.Text);
                List<Supan_Places> places = new List<Supan_Places>();
                try
                {
                    if (typeCombo.Text == "Svi tipovi")
                    {
                        foreach (var typeID in selectedTypeIDs)
                        {
                            places.AddRange(PlaceRepository.GetPlaces(typeID, _positionLat, _positionLng, radius));
                        }
                    }
                    else
                    {
                        places = PlaceRepository.GetPlaces(_selectedTypeId, _positionLat, _positionLng, radius);
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Tip lokacije ili ne postoji ili vam pretraživanje tog tipa lokacije nije omogućeno. Provjerite tipove lokacija u administraciji." + exc.Message );
                    return;
                }
                if (_polygons.Polygons.Count() > 0 && searchOnlyInPolygon.Checked)
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
                else if(_polygons.Polygons.Count() == 0 && searchOnlyInPolygon.Checked)
                {
                    MessageBox.Show("Ne postoji ni jedan poligon na karti.");
                    return;
                }
                if(places.Count() > 0)
                {
                    dataGridViewSearchedPlaces = NapuniGridListom<Supan_Places>(dataGridViewSearchedPlaces, places);
                    foreach (var place in places)
                    {
                        GMapMarker marker = NapraviMarker(place.PLACE_LAT, place.PLACE_LNG, GMarkerGoogleType.red_dot, _markers);
                        PostaviMarkerToolTip(marker, place.PLACE_NAME, place.PLACE_ADDRESS);
                    }
                }
                else
                {
                    MessageBox.Show("Nije pronađeno niti jedno mjesto prema odabranim kriterijima.");
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
            typeCombo.Text = "Svi tipovi";

            dataGridViewSearchedPlaces.DataSource = null;
        }

        private void UcitajMapu()
        {
            GMapProviders.GoogleMap.ApiKey = @"AIzaSyBSuPs2jtLhJs-9BHt-4iIZhABawlJvHhs";
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            gmap.MapProvider = GoogleMapProvider.Instance;
            gmap.Position = new PointLatLng(45.135555, 16.325684);
            gmap.ShowCenter = false;
            _markers = new GMapOverlay("markers");
            _polygons = new GMapOverlay("polygons");
            gmap.Overlays.Add(_markers);
            normalModeRadio.Select();


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

        private DataGridView NapuniGridIzBaze<TEntity>(DataGridView dataGridView, DbSet<TEntity> relacija) where TEntity : class
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = relacija.ToList() ;
            bindingSource.ResetBindings(true);

            dataGridView.AutoGenerateColumns = false;
            dataGridView.RowTemplate.Height = 33;
            dataGridView.DataSource = bindingSource;
            return dataGridView;
        }

        private DataGridView NapuniGridListom<T>(DataGridView dataGridView, List<T> lista) where T:class
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = lista;
            bindingSource.ResetBindings(true);
            dataGridView.AutoGenerateColumns = false;
            dataGridView.RowTemplate.Height = 33;
            dataGridView.DataSource = bindingSource;
            return dataGridView;
        }

        private void NapuniTypeCombo()
        {
            List<Supan_PlaceTypes> omoguceniTipoviLokacija = new List<Supan_PlaceTypes>();
            omoguceniTipoviLokacija.Add(new Supan_PlaceTypes { TYPE_ALLOWED = true, TYPE_ID = 9999, TYPE_NAME = "Svi tipovi", TYPE_VALUE = "all" });
            using (var mapDB = new MapEntities())
            {
                omoguceniTipoviLokacija.AddRange(mapDB.Supan_PlaceTypes.Where(t => t.TYPE_ALLOWED == true).ToList());
            }
            ComboConfig<Supan_PlaceTypes>(omoguceniTipoviLokacija, typeCombo, "TYPE_NAME", "Svi tipovi");
        }

        private void NapuniPolyCombo()
        {
            List<Supan_Regions> regijeuBazi = new List<Supan_Regions>();
            using (var mapDB = new MapEntities())
            {
                regijeuBazi = mapDB.Supan_Regions.ToList();
            }
            ComboConfig<Supan_Regions>(regijeuBazi, polyCombo, "NAZIV_REGIJE", "");
        }

        private void NapuniSavedLocationsTypeCombo()
        {
            List<Supan_PlaceTypes> tipoviUBazi = new List<Supan_PlaceTypes>();
            List<Supan_PlaceTypes> tipoviTrenutnoUSpremljenimLokacijama = new List<Supan_PlaceTypes>();
            List<Supan_Places> lokacijeUBazi = new List<Supan_Places>();
            using (var mapDB = new MapEntities())
            {
                tipoviUBazi = mapDB.Supan_PlaceTypes.ToList();
                lokacijeUBazi = mapDB.Supan_Places.ToList();
            }
            foreach (var lokacija in lokacijeUBazi)
            {
                tipoviTrenutnoUSpremljenimLokacijama.Add(tipoviUBazi.Where(t => t.TYPE_ID == lokacija.PLACE_TYPE).FirstOrDefault());
            }
            List<Supan_PlaceTypes> imenaJedinstvenihSpremljenihLokacijinihTipova = new List<Supan_PlaceTypes>();
            imenaJedinstvenihSpremljenihLokacijinihTipova.Add(new Supan_PlaceTypes { TYPE_ALLOWED = true, TYPE_ID = 9999, TYPE_NAME = "Svi tipovi", TYPE_VALUE = "all" });
            imenaJedinstvenihSpremljenihLokacijinihTipova.AddRange(tipoviTrenutnoUSpremljenimLokacijama.DistinctBy(t => t.TYPE_NAME).ToList());
            ComboConfig<Supan_PlaceTypes>(imenaJedinstvenihSpremljenihLokacijinihTipova, savedTypesCombo, "TYPE_NAME", "");
        }

        private void ComboConfig<T>(List<T> lista, ComboBox comboBox, string displayMember, string text)
        {
            comboBox.SelectedIndex = -1;
            comboBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox.DataSource = lista;
            comboBox.DisplayMember = displayMember;
            comboBox.Text = text;
        }

        private void NapuniTextBoxSuggest(TextBox searchBoxP, DataGridView dataGridView)
        {
            searchBoxP.AutoCompleteMode = AutoCompleteMode.Suggest;
            searchBoxP.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (dataGridView == dataGridViewSavedLocations && searchBoxP == searchLocationsCityInGridBox)
                {
                    string grad = row.Cells[1].Value.ToString().Split(',')[1].TrimStart();
                    col.Add(grad);
                }
                else
                {
                    col.Add(row.Cells[0].Value.ToString());
                }
            }
            searchBoxP.AutoCompleteCustomSource = col;
        }

        public void kreirajStupac(DataGridView dataGridView,DataGridViewImageColumn button, string lokacijaSlike, string nazivKolone)
        {
            button = new DataGridViewImageColumn();
            button.Name = nazivKolone;
            button.Image = Image.FromFile(lokacijaSlike);
            button.Width = 33;
            button.ReadOnly = true;

            button.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns.Add(button);

        }

        private void dataGridViewAdministration_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var dataGridViewAdministrationBySender = (DataGridView)sender;
            var column = dataGridViewAdministrationBySender.Columns[e.ColumnIndex];
            string typeName = (string)dataGridViewAdministration.Rows[e.RowIndex].Cells["typeName"].Value;
            Supan_PlaceTypes placeType = new Supan_PlaceTypes();
            if (column.Name == "Dodaj tip" & e.RowIndex>-1)
            {
                using (var mapDB = new MapEntities())
                {
                    placeType = mapDB.Supan_PlaceTypes.Where(t => t.TYPE_NAME == typeName).FirstOrDefault();
                }
               
                if(placeType.TYPE_ALLOWED == true)
                {
                    MessageBox.Show("Taj tip lokacije već možete pretraživati ( " + typeName + " )");
                    return;
                }
                placeType.TYPE_ALLOWED = true;
                using (var mapDB = new MapEntities())
                {
                    mapDB.Supan_PlaceTypes.Add(placeType);
                    mapDB.SaveChanges();
                }
                NapuniTypeCombo();
                MessageBox.Show("Od sad možete pretraživati sljedeći tip lokacije: " + typeName);
            }
            else if(column.Name == "Izbriši tip" & e.RowIndex > -1)
            {


                using (var mapDB = new MapEntities())
                {
                    placeType = mapDB.Supan_PlaceTypes.Where(t => t.TYPE_NAME == typeName).FirstOrDefault();
                }
                if (placeType.TYPE_ALLOWED == false)
                {
                    MessageBox.Show("Taj tip lokacije je već onemogućen za pretraživanje ( " + typeName + " )");
                    return;
                }
                placeType.TYPE_ALLOWED = false;
                using (var mapDB = new MapEntities())
                {
                    mapDB.SaveChanges();
                }
                NapuniTypeCombo();
                MessageBox.Show("Od sad više ne možete pretraživati sljedeći tip lokacije: " + typeName);
            }
        }

        private void searchValueButton_Click(object sender, EventArgs e)
        {
            List<Supan_PlaceTypes> typesFiltered = new List<Supan_PlaceTypes>();
            using (var mapDB = new MapEntities())
            {
                if (!String.IsNullOrEmpty(searchValueBox.Text))
                {
                    typesFiltered = mapDB.Supan_PlaceTypes.Where(p => p.TYPE_NAME.Contains(searchValueBox.Text)).ToList();

                }
                else
                {
                    typesFiltered = mapDB.Supan_PlaceTypes.ToList();
                }
                NapuniGridListom<Supan_PlaceTypes>(dataGridViewAdministration, typesFiltered);
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
                    using (var mapDB = new MapEntities())
                    {
                        dataGridViewSavedLocations = NapuniGridIzBaze<Supan_Places>(dataGridViewSavedLocations, mapDB.Supan_Places);
                    }
                    NapuniSavedLocationsTypeCombo();
                    NapuniTextBoxSuggest(searchLocationsCityInGridBox, dataGridViewSavedLocations);
                    NapuniTextBoxSuggest(searchLocationsNameInGridBox, dataGridViewSavedLocations);

                }
                formSavePlace.Hide();
            }
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
                NapraviMarker(lat, lng, GMarkerGoogleType.red_pushpin,_markers);
                tabControl1.SelectedTab = mapTab;

            }
            else if (column.Name == "Obriši lokaciju" & e.RowIndex > -1)
            {
                try
                {
                    string placeName = (string)dataGridViewSavedLocations.Rows[e.RowIndex].Cells["placeName"].Value;
                    using (var mapDB = new MapEntities())
                    {
                        Supan_Places place = mapDB.Supan_Places.Where(p => p.PLACE_NAME == placeName).FirstOrDefault();
                        mapDB.Supan_Places.Remove(place);
                        mapDB.SaveChanges();
                        dataGridViewSavedLocations = NapuniGridIzBaze<Supan_Places>(dataGridViewSavedLocations, mapDB.Supan_Places);
                    }

                    NapuniSavedLocationsTypeCombo();
                    NapuniTextBoxSuggest(searchLocationsCityInGridBox, dataGridViewSavedLocations);
                    NapuniTextBoxSuggest(searchLocationsNameInGridBox, dataGridViewSavedLocations);
                    MessageBox.Show("Uspješno ste obrisali lokaciju: " + placeName);

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
                    using (var mapDB = new MapEntities())
                    {
                        formEditPlace.placeToEdit = mapDB.Supan_Places.Where(p => p.PLACE_NAME == placeName).FirstOrDefault();
                    }
                    formEditPlace.ShowDialog();

                    if (formEditPlace.savingSuccessFull)
                    {
                        using (var mapDB = new MapEntities())
                        {
                            dataGridViewSavedLocations = NapuniGridIzBaze<Supan_Places>(dataGridViewSavedLocations, mapDB.Supan_Places);
                        }


                        NapuniTextBoxSuggest(searchLocationsCityInGridBox, dataGridViewSavedLocations);
                        NapuniTextBoxSuggest(searchLocationsNameInGridBox, dataGridViewSavedLocations);
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
                polyPoints.Clear();

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
                Supan_Regions region = new Supan_Regions();
                List<Supan_RegionPoints> regionPoints = new List<Supan_RegionPoints>();
                using (var mapDB = new MapEntities())
                {
                    region = mapDB.Supan_Regions.Where(r => r.NAZIV_REGIJE == polyCombo.Text).FirstOrDefault();
                    if (region != null)
                    {
                        regionPoints = mapDB.Supan_RegionPoints.Where(rp => rp.ID_REGIJE == region.ID).ToList();

                    }
                    else
                    {
                        MessageBox.Show("Odabrana regija ne postoji!");
                        return;
                    }
                }

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
            if (_polygons.Polygons.Count() > 0)
            {
                MessageBox.Show("Prvo morate resetirati mapu kako bi se obrisao postojeći poligon.");
                return;
            }
            if (!(point.Lat == 0) && !(point.Lat == 0))
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
                    using (var mapDB = new MapEntities())
                    {
                        dataGridViewSavedPolygons = NapuniGridIzBaze<Supan_Regions>(dataGridViewSavedPolygons, mapDB.Supan_Regions);
                    }
                    NapuniTextBoxSuggest(searchPolygonsNameInGridBox, dataGridViewSavedPolygons);
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
                    using (var mapDB = new MapEntities())
                    {
                        var polyPointsForRemoval = mapDB.Supan_RegionPoints.Where(rp => rp.ID_REGIJE == region.ID).ToList();
                        if (polyPointsForRemoval.Count != 0)
                        {
                            foreach (var point in polyPointsForRemoval)
                            {
                                mapDB.Supan_RegionPoints.Remove(point);
                            }
                        }
                        var regionToRemove = mapDB.Supan_Regions.Where(r => r.ID == region.ID).FirstOrDefault();
                        mapDB.Supan_Regions.Remove(regionToRemove);
                        mapDB.SaveChanges();
                        dataGridViewSavedPolygons = NapuniGridIzBaze<Supan_Regions>(dataGridViewSavedPolygons, mapDB.Supan_Regions);
                    }
                    
                    NapuniTextBoxSuggest(searchPolygonsNameInGridBox, dataGridViewSavedPolygons);
                    
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
            else if (column.Name == "Uredi detalje" & e.RowIndex > -1)
            {
                var polyName = (string)dataGridViewSavedPolygons.Rows[e.RowIndex].Cells["RegionName"].Value;
                using (FormEditPoly formEditPoly = new FormEditPoly())
                {
                    using (var mapDB = new MapEntities())
                    {
                        formEditPoly.regionToEdit = mapDB.Supan_Regions.Where(p => p.NAZIV_REGIJE == polyName).FirstOrDefault();
                    }
                    formEditPoly.ShowDialog();

                    if (formEditPoly.savingSuccessFull)
                    {
                        using (var mapDB = new MapEntities())
                        {
                            dataGridViewSavedPolygons = NapuniGridIzBaze<Supan_Regions>(dataGridViewSavedPolygons, mapDB.Supan_Regions);
                        }

                        NapuniTextBoxSuggest(searchPolygonsNameInGridBox, dataGridViewSavedPolygons);
                    }
                }
            }
        }
        private void gmap_OnMapZoomChanged()
        {
            gmap.Zoom = gmap.Zoom;
            var lat = decimal.Round((decimal)gmap.Position.Lat, 6, MidpointRounding.AwayFromZero);
            currentLatTextBox.Text = "" + Convert.ToString(lat).Replace(",", ".");
            var lng = decimal.Round((decimal)gmap.Position.Lng, 6, MidpointRounding.AwayFromZero);
            currentLngTextBox.Text = "" + Convert.ToString(lng).Replace(",", ".");
        }

        private void btnSearchLocationsInGrid_Click(object sender, EventArgs e)
        {
            string demandedCity = searchLocationsCityInGridBox.Text;
            string demandedName = searchLocationsNameInGridBox.Text;
            try
            {
                var selectedTypeName = savedTypesCombo.GetItemText(savedTypesCombo.SelectedItem);
                List<Supan_Places>  placesFiltered = new List<Supan_Places>();
                using (var mapDB = new MapEntities())
                {
                    if(selectedTypeName == "Svi tipovi")
                    {
                        placesFiltered = mapDB.Supan_Places.Where(p => p.PLACE_NAME.Contains(demandedName) && p.PLACE_ADDRESS.Contains(demandedCity)).ToList();

                    }
                    else
                    {
                        var selectedTypeId = mapDB.Supan_PlaceTypes.Where(t => t.TYPE_NAME == selectedTypeName).Select(t => t.TYPE_ID).FirstOrDefault();
                        placesFiltered = mapDB.Supan_Places.Where(p => p.PLACE_NAME.Contains(demandedName) && p.PLACE_TYPE == selectedTypeId && p.PLACE_ADDRESS.Contains(demandedCity)).ToList();
                    }
                }
                using (var mapDB = new MapEntities())
                {
                    dataGridViewSavedLocations = NapuniGridListom<Supan_Places>(dataGridViewSavedLocations, placesFiltered);
                }
                NapuniTextBoxSuggest(searchLocationsCityInGridBox, dataGridViewSavedLocations);
                NapuniTextBoxSuggest(searchLocationsNameInGridBox, dataGridViewSavedLocations);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnSearchPolygonsInGrid_Click(object sender, EventArgs e)
        {
            List<Supan_Regions> regionsFiltered = new List<Supan_Regions>();
            using (var mapDB = new MapEntities())
            {
                if (!String.IsNullOrEmpty(searchPolygonsNameInGridBox.Text) || !String.IsNullOrWhiteSpace(searchPolygonsNameInGridBox.Text))
                {
                    regionsFiltered = mapDB.Supan_Regions.Where(p => p.NAZIV_REGIJE.Contains(searchPolygonsNameInGridBox.Text)).ToList();

                }
                else
                {
                    regionsFiltered = mapDB.Supan_Regions.ToList();
                }
                NapuniGridListom<Supan_Regions>(dataGridViewSavedPolygons, regionsFiltered);
            }
        }

        private void normalModeRadio_CheckedChanged(object sender, EventArgs e)
        {
            CheckMapMode();
        }

        private void negativeModeRadio_CheckedChanged(object sender, EventArgs e)
        {
            CheckMapMode();
        }

        private void CheckMapMode()
        {
            if (normalModeRadio.Checked)
            {
                gmap.MapProvider = GoogleMapProvider.Instance;
            }
            else if (negativeModeRadio.Checked)
            {
                gmap.MapProvider = GoogleHybridMapProvider.Instance;
            }
            gmap.Refresh();
        }

        private void searchLocationsNameInGridBox_KeyUp(object sender, KeyEventArgs e)
        {
                btnSearchLocationsInGrid_Click(this, new EventArgs());
        }

        private void searchLocationsCityInGridBox_KeyUp(object sender, KeyEventArgs e)
        {
                btnSearchLocationsInGrid_Click(this, new EventArgs());
        }

        private void savedTypesCombo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            btnSearchLocationsInGrid_Click(this, new EventArgs());
        }

        private void searchPolygonsNameInGridBox_KeyUp(object sender, KeyEventArgs e)
        {
            btnSearchPolygonsInGrid_Click(this, new EventArgs());
        }

        private void searchValueBox_KeyUp(object sender, KeyEventArgs e)
        {
            searchValueButton_Click(this, new EventArgs());
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

//bool rowFound = false;
//string searchValue = searchPolygonsNameInGridBox.Text;
//dataGridViewSavedPolygons.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
//try
//{
//    foreach (DataGridViewRow row in dataGridViewSavedPolygons.Rows)
//    {
//        row.Selected = false;
//        if (row.Cells[0].Value.ToString().ToLower().Contains(searchValue.ToLower()))
//        {
//            rowFound = true;
//            row.Selected = true;
//            dataGridViewSavedPolygons.FirstDisplayedScrollingRowIndex = dataGridViewSavedPolygons.SelectedRows[0].Index;
//        }
//    }
//    if (rowFound == false)
//    {
//        MessageBox.Show("Unešeni poligon ne postoji u bazi podataka!");
//    }
//}
//catch (Exception exc)
//{
//    MessageBox.Show(exc.Message);
//}