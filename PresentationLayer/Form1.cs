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
using System.Data.Entity.Migrations;

namespace PresentationLayer
{
    public partial class Form1 : Form
    {
        private decimal _positionLat;
        private decimal _positionLng;
        private PointLatLng _point;
        private GMapOverlay _markers;
        private GMapOverlay _polygons;
        private int _selectedTypeId;
        private GMapPolygon _polygon;
        List<PointLatLng> polyPoints;


        public Form1()
        {
            InitializeComponent();

        }

        //==========================================================================================================================================================================================================================
        //========================================================================================  Initial Program StartUp Config ==================================================================================================

        private void Form1_Load(object sender, EventArgs e)
        {
            InicijalizirajVarijable();
            UcitajMapu();
            SetPrimaryTextBoxConfig();
            NapuniComboBoxes();
            NapuniSuggestTextBoxes();
            NapuniSveDataGridViews();
            kreirajImageColumnsForDataGridView();
        }

        private void InicijalizirajVarijable()
        {
            _positionLat = 0;
            _positionLng = 0;
            _point = new PointLatLng();
            _markers = new GMapOverlay("markers");
            _polygons = new GMapOverlay("polygons");
            polyPoints = new List<PointLatLng>();
            _polygon = new GMapPolygon(polyPoints, "My Area");

        }

        private void NapuniSveDataGridViews()
        {
            using (var mapDB = new MapEntities())
            {
                dataGridViewAdministration = NapuniGridIzBaze<Supan_PlaceTypes>(dataGridViewAdministration, mapDB.Supan_PlaceTypes);
                dataGridViewSavedLocations = NapuniGridIzBaze<Supan_Places>(dataGridViewSavedLocations, mapDB.Supan_Places);
                dataGridViewSavedPolygons = NapuniGridIzBaze<Supan_Regions>(dataGridViewSavedPolygons, mapDB.Supan_Regions);
            }
        }

        private void UcitajMapu()
        {
            GMapProviders.GoogleMap.ApiKey = @"AIzaSyBSuPs2jtLhJs-9BHt-4iIZhABawlJvHhs";
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            gmap.MapProvider = GoogleMapProvider.Instance;
            gmap.Position = new PointLatLng(45.135555, 16.325684);
            gmap.ShowCenter = false;
            gmap.Overlays.Add(_markers);
            normalModeRadio.Select();
        }

        private void SetPrimaryTextBoxConfig()
        {
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
        }

        private void NapuniComboBoxes()
        {
            NapuniTypeCombo();
            NapuniPolyCombo();
            NapuniSavedLocationsTypeCombo();
        }

        private void NapuniSuggestTextBoxes()
        {
            NapuniTextBoxSuggest(searchLocationsCityInGridBox, dataGridViewSavedLocations);
            NapuniTextBoxSuggest(searchLocationsNameInGridBox, dataGridViewSavedLocations);
            NapuniTextBoxSuggest(searchPolygonsNameInGridBox, dataGridViewSavedPolygons);
            NapuniTextBoxSuggest(searchTypesBox, dataGridViewAdministration);
        }

        public void kreirajStupac(DataGridView dataGridView, string lokacijaSlike, string nazivKolone)
        {
            DataGridViewImageColumn button = new DataGridViewImageColumn();
            button.Name = nazivKolone;
            button.Image = Image.FromFile(lokacijaSlike);
            button.Width = 33;
            button.ReadOnly = true;
            button.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns.Add(button);
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
                    string[] adresa = row.Cells[1].Value.ToString().Split(',');
                    string grad = adresa[adresa.Count() - 1].TrimStart();
                    col.Add(grad);
                }
                else
                {
                    col.Add(row.Cells[0].Value.ToString());
                }
            }
            searchBoxP.AutoCompleteCustomSource = col;
        }

        private void kreirajImageColumnsForDataGridView()
        {
            kreirajStupac(dataGridViewAdministration, @"images/addType.png", "Dodaj tip");
            kreirajStupac(dataGridViewAdministration, @"images/removeType.png", "Izbriši tip");
            kreirajStupac(dataGridViewSearchedPlaces, @"images/showOnMap.png", "Uvećaj lokaciju");
            kreirajStupac(dataGridViewSavedLocations, @"images/showOnMap.png", "Uvećaj lokaciju");
            kreirajStupac(dataGridViewSavedLocations, @"images/edit.png", "Uredi detalje");
            kreirajStupac(dataGridViewSavedLocations, @"images/removeType.png", "Obriši lokaciju");
            kreirajStupac(dataGridViewSavedPolygons, @"images/showOnMap.png", "Prikaži poligon");
            kreirajStupac(dataGridViewSavedPolygons, @"images/edit.png", "Uredi detalje");
            kreirajStupac(dataGridViewSavedPolygons, @"images/removeType.png", "Obriši poligon");
            dataGridViewAdministration.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        //==========================================================================================================================================================================================================================
        //========================================================================================  Form Events ==================================================================================================
        private void radiusBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            apiProgressBar.Value = 0;
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
            polyCombo.Text = "";
            typeCombo.Text = "Svi tipovi";
            dataGridViewSearchedPlaces.DataSource = null;
        }


        private void searchButton_Click(object sender, EventArgs e)
        {
            ClearMarkerOverlay();
            if (CheckSearchBoxes())
            {
                MessageBox.Show("Molimo unesite sve tražene vrijednosti", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                apiProgressBar.Value = 0;
                List<int> selectedTypeIDs = GetSelectedTypeIDs();
                List<Supan_Places> places = GetPlacesBasedOnPolygonCheckbox(selectedTypeIDs);
                SetGridAndMarkersForSearchedPlaces(places);

            }
        }

        private void searchTypesButton_Click(object sender, EventArgs e)
        {
            List<Supan_PlaceTypes> typesFiltered = new List<Supan_PlaceTypes>();
            using (var mapDB = new MapEntities())
            {
                if (!String.IsNullOrEmpty(searchTypesBox.Text))
                {
                    typesFiltered = mapDB.Supan_PlaceTypes.Where(p => p.TYPE_NAME.Contains(searchTypesBox.Text)).ToList();
                }
                else
                {
                    typesFiltered = mapDB.Supan_PlaceTypes.ToList();
                }
                NapuniGridListom<Supan_PlaceTypes>(dataGridViewAdministration, typesFiltered);
            }
        }

        private void btnAddPoly_Click(object sender, EventArgs e)
        {
            bool regionExists = false;
            if (polyCombo.Text == "")
            {
                if(polyPoints.Count() > 0)
                {
                    ClearMarkersAndPolygonsFromMap();
                    if (_polygons.Polygons.Count() == 0)
                    {
                        NapraviPoligon();
                        PolygonAlreadyExists(ref regionExists);
                        dataGridViewSearchedPlaces.DataSource = null;
                    }
                }
                else
                {
                    MessageBox.Show("Prvo morate dodati točke kako bi se nacrtao poligon.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                Supan_Regions region = new Supan_Regions();
                List<Supan_RegionPoints> regionPoints = new List<Supan_RegionPoints>();
                GetRegionPointsFromDB(ref region, ref regionPoints, ref regionExists);
                if (regionExists)
                {
                    ProvjeriImaLiRegijeIdenticnihKrajnjihTocakaUBazi(ref region, ref regionPoints, ref regionExists);
                    if (regionExists == false)
                    {
                        NapraviPoligon();
                        polyPoints.Clear();
                        drawRegion(region.ID);
                        polyPoints.Clear();
                        polyPointsReadyTextBox.Text = "" + polyPoints.Count();
                        dataGridViewSearchedPlaces.DataSource = null;
                    }
                    else
                    {
                        MessageBox.Show("Poligon koji želite nacrtati već je nacrtan.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Poligon koji ste odabrali/unijeli ne postoji.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnAddPointToPoly_Click(object sender, EventArgs e)
        {
            if (_polygons.Polygons.Count() > 0)
            {
                MessageBox.Show("Prvo morate resetirati mapu kako bi se obrisao postojeći poligon.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!(_point.Lat == 0) && !(_point.Lat == 0))
            {
                polyPoints.Add(_point);
                polyPointsReadyTextBox.Text = "" + polyPoints.Count();
                GMapMarker marker = NapraviMarker(_positionLat, _positionLng, GMarkerGoogleType.gray_small, _markers);
                marker.IsHitTestVisible = false;
                gmap.Refresh();
            }
            else
            {
                MessageBox.Show("Prvo morate odabrati graničnu točku za kreiranje područja.", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnSearchLocationsInGrid_Click(object sender, EventArgs e)
        {
            string demandedCity = searchLocationsCityInGridBox.Text;
            string demandedName = searchLocationsNameInGridBox.Text;
            try
            {
                var selectedTypeName = savedTypesCombo.GetItemText(savedTypesCombo.SelectedItem);
                List<Supan_Places> placesFiltered = new List<Supan_Places>();
                DynamicallyFilterPlacesInGrid(ref placesFiltered, selectedTypeName, demandedName, demandedCity);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            searchTypesButton_Click(this, new EventArgs());
        }

        private void iZLAZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pretražiLokacijeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = mapTab;
        }

        private void spremljeneLokacijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = savedLocationsTab;
        }

        private void spremljeniPoligoniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = savedLocationsTab;
        }

        private void administracijaTipovaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = administrationTab;
        }

        private void pretražiLokacijeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = mapTab;
        }

        private void spremljeneLokacijeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = savedLocationsTab;
        }

        private void spremljeniPoligoniToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = savedLocationsTab;

        }

        private void administracijaTipovaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = administrationTab;
        }

        private void izlazToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void uputeZaKorištenjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ovaj program sastoji se od 3 glavne funkcionalnosti: \n\n\t Pretraživanje lokacija:  \n\t Ova opcija nam omogućuje da pretraživamo lokacije na cijeloj zemaljskoj kugli sukladno unešenim filterima. Ovdje također korisnik vidi razne informacije o lokaciji i spremnim točkama za crtanje poligona. Poligon (područje) možemo nacrtati i samo u njemu na temelju ostalih filter informacija pretraživati lokacije. Nakon uspješnog filtera prikazuju nam se lokacije tablično i na karti, koje možemo spremiti klikom na gumb markera, a nespremljene ( one nacrtane točkama) poligone spremamo dvostukim klikom miša. \n\n\t Prikaz spremljenih lokacija/ poligona:  \n\tSukladno spremljenim poligona i lokacija sa mape, na ovoj opciji imamo 2 tablična prikaza koji se ažuriraju na temelju sa strane unešenih filtera. Spremljene lokacije/poligone ovdje možemo prikazati na mapi, urediti detalje i obrisati redak u tablici i na taj način ažurirati bazu spremljenih lokacija/poligona. \n\n\t Administracija tipova lokacija: \n\t U ovoj opciji nudi nam se prikaz svih tipova lokacija koje su u bazi podataka. Iste možemo omogućiti ili onemogućiti za pretraživanje. Preko filtera automatski se ažurira tablični prikaz prema nazivu tipa lokacije.");
        }

        private void oProgramuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Autor: Antonio Supan \n Verzija:  0.01 \n Predmet: Programiranje u .NET okolini \n\t Siječanj 2020.");
        }


        //==========================================================================================================================================================================================================================
        //========================================================================================  GMap Events ==================================================================================================


        private void gmap_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _point = gmap.FromLocalToLatLng(e.X, e.Y);
                decimal lat = Convert.ToDecimal(_point.Lat);
                decimal lng = Convert.ToDecimal(_point.Lng);
                _positionLat = decimal.Round(lat, 6, MidpointRounding.AwayFromZero);
                _positionLng = decimal.Round(lng, 6, MidpointRounding.AwayFromZero);
                startLocationBox.Text = "Lat: " + Convert.ToString(_positionLat).Replace(",", ".") + ", Lng: " + Convert.ToString(_positionLng).Replace(",", ".");

            }
        }

        private void gmap_OnMarkerClick(GMapMarker marker, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                decimal lat = Convert.ToDecimal(string.Format("{0:N6}", marker.Position.Lat));
                decimal lng = Convert.ToDecimal(string.Format("{0:N6}", marker.Position.Lng));
                if (!PlaceAlreadyExistsInDB(lat, lng))
                {
                    OtvoriFormuZaSpremanjeLokacije(marker);
                }
                else
                {
                    MessageBox.Show("Ta lokacija je već spremljena u bazi.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void gmap_OnPolygonDoubleClick(GMapPolygon item, MouseEventArgs e)
        {
            OtvoriFormuZaSpremanjePoligona();
        }

        private void gmap_OnMapZoomChanged()
        {
            gmap.Zoom = gmap.Zoom;
            var lat = decimal.Round((decimal)gmap.Position.Lat, 6, MidpointRounding.AwayFromZero);
            currentLatTextBox.Text = "" + Convert.ToString(lat).Replace(",", ".");
            var lng = decimal.Round((decimal)gmap.Position.Lng, 6, MidpointRounding.AwayFromZero);
            currentLngTextBox.Text = "" + Convert.ToString(lng).Replace(",", ".");
        }

        private void gmap_OnMapDrag()
        {
            gmap.Zoom = gmap.Zoom;
            var lat = decimal.Round((decimal)gmap.Position.Lat, 6, MidpointRounding.AwayFromZero);
            currentLatTextBox.Text = "" + Convert.ToString(lat).Replace(",", ".");
            var lng = decimal.Round((decimal)gmap.Position.Lng, 6, MidpointRounding.AwayFromZero);
            currentLngTextBox.Text = "" + Convert.ToString(lng).Replace(",", ".");
        }



        //==========================================================================================================================================================================================================================
        //========================================================================================  GENERAL DATAGRIDVIEW SETUP ==================================================================================================

        private DataGridView NapuniGridIzBaze<TEntity>(DataGridView dataGridView, DbSet<TEntity> relacija) where TEntity : class
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = relacija.ToList();
            bindingSource.ResetBindings(true);

            dataGridView.AutoGenerateColumns = false;
            dataGridView.RowTemplate.Height = 33;
            dataGridView.DataSource = bindingSource;
            return dataGridView;
        }

        private DataGridView NapuniGridListom<T>(DataGridView dataGridView, List<T> lista) where T : class
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = lista;
            bindingSource.ResetBindings(true);

            dataGridView.AutoGenerateColumns = false;
            dataGridView.RowTemplate.Height = 33;
            dataGridView.DataSource = bindingSource;
            return dataGridView;
        }


        //==========================================================================================================================================================================================================================
        //========================================================================================  DataGridView SearchedPlaces ==================================================================================================

        private bool CheckSearchBoxes()
        {
            return String.IsNullOrWhiteSpace(startLocationBox.Text) || String.IsNullOrEmpty(startLocationBox.Text)
                       || String.IsNullOrWhiteSpace(radiusBox.Text) || String.IsNullOrEmpty(radiusBox.Text)
                       || String.IsNullOrWhiteSpace(typeCombo.Text) || String.IsNullOrEmpty(typeCombo.Text);
        }

        private int GetRadius()
        {
            return Convert.ToInt32(radiusBox.Text);
        }

        private List<int> GetSelectedTypeIDs()
        {
            List<int> selectedTypeIDs = new List<int>();
            string selectedTypeName = typeCombo.GetItemText(this.typeCombo.SelectedItem);

            using (var mapDB = new MapEntities())
            {
                if (typeCombo.Text == "Svi tipovi")
                {
                    selectedTypeIDs = mapDB.Supan_PlaceTypes.Where(t => t.TYPE_ALLOWED == true).Select(t => t.TYPE_ID).ToList();
                }
                else
                {
                    _selectedTypeId = mapDB.Supan_PlaceTypes.Where(t => t.TYPE_NAME == selectedTypeName).Select(t => t.TYPE_ID).FirstOrDefault();
                }
                return selectedTypeIDs;
            }
        }

        private List<Supan_Places> GetPlacesForSearchGrid(List<int> selectedTypeIDs)
        {
            List<Supan_Places> places = new List<Supan_Places>();
            if (selectedTypeIDs.Count > 0)
            {
                apiProgressBar.Maximum = selectedTypeIDs.Count;
            }
            else
            {
                apiProgressBar.Maximum = 1;
            }
            apiProgressBar.Step = 1;
            if (typeCombo.Text == "Svi tipovi")
            {
                foreach (var typeID in selectedTypeIDs)
                {
                    places.AddRange(PlaceRepository.GetPlaces(typeID, _positionLat, _positionLng, GetRadius()));
                    apiProgressBar.PerformStep();
                }
                return places;
            }
            else
            {
                places = PlaceRepository.GetPlaces(_selectedTypeId, _positionLat, _positionLng, GetRadius());
                foreach (var place in places)
                {
                    apiProgressBar.PerformStep();
                }
                return places;
            }
        }

        private List<Supan_Places> GetPlacesForSearchGridInsideTypeBoundaries(List<int> selectedTypeIDs)
        {
            try
            {
                return GetPlacesForSearchGrid(selectedTypeIDs);
            }
            catch (Exception exc)
            {
                MessageBox.Show("Tip lokacije ili ne postoji ili vam\n pretraživanje tog tipa lokacije nije omogućeno.\n Provjerite tipove lokacija u administraciji." + exc.Message, "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        private List<Supan_Places> GetPlacesBasedOnPolygonCheckbox(List<int> selectedTypeIDs)
        {
            List<Supan_Places> places = GetPlacesForSearchGridInsideTypeBoundaries(selectedTypeIDs);
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
                return places;
            }
            else if (_polygons.Polygons.Count() == 0 && searchOnlyInPolygon.Checked)
            {
                MessageBox.Show("Ne postoji ni jedan poligon na karti.\nMolimo ponovite kriterije pretrage.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                places.Clear();
            }
            return places;
        }

        private void SetGridAndMarkersForSearchedPlaces(List<Supan_Places> places)
        {
            if (places.Count() > 0)
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
                dataGridViewSearchedPlaces.DataSource = null;
                MessageBox.Show("Nije pronađeno niti jedno mjesto prema odabranim kriterijima.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                gmap.Position = new PointLatLng((double)lat, (double)lng);
                gmap.Zoom = 30;
            }
        }



        //==========================================================================================================================================================================================================================
        //========================================================================================  DataGridView Places ==================================================================================================

        private void DeleteSavedLocation(string placeName)
        {
            DialogResult brisanjeLokacije = MessageBox.Show("Jeste li sigurni da želite obrisati lokaciju?\n Brisanjem lokacije izbrisat će se svi markeri koji su trenutno prikazani na mapi",
            "Brisanje lokacije",
            MessageBoxButtons.YesNo);
            if (brisanjeLokacije.Equals(DialogResult.Yes))
            {
                ResetirajSavedLocationsInputAndAllMarkers();
                using (var mapDB = new MapEntities())
                {
                    Supan_Places place = mapDB.Supan_Places.Where(p => p.PLACE_NAME == placeName).FirstOrDefault();
                    mapDB.Supan_Places.Remove(place);
                    mapDB.SaveChanges();
                    dataGridViewSavedLocations = NapuniGridIzBaze<Supan_Places>(dataGridViewSavedLocations, mapDB.Supan_Places);
                    dataGridViewSearchedPlaces.DataSource = null;
                }
                MessageBox.Show("Uspješno ste obrisali lokaciju: " + placeName, "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ZoomSavedLocation(decimal lat, decimal lng)
        {
            gmap.Position = new PointLatLng((double)lat, (double)lng);
            gmap.Zoom = 30;
            NapraviMarker(lat, lng, GMarkerGoogleType.red_pushpin, _markers);
            tabControl1.SelectedTab = mapTab;
        }

        private void DynamicallyFilterPlacesInGrid(ref List<Supan_Places> placesFiltered, string selectedTypeName, string demandedName, string demandedCity)
        {
            using (var mapDB = new MapEntities())
            {
                if (selectedTypeName == "Svi tipovi")
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

        private void dataGridViewSavedLocations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var dataGridViewSearchedLocationsBySender = (DataGridView)sender;
            var column = dataGridViewSearchedLocationsBySender.Columns[e.ColumnIndex];

            string placeName = (string)dataGridViewSavedLocations.Rows[e.RowIndex].Cells["placeName"].Value;

            if (column.Name == "Uvećaj lokaciju" & e.RowIndex > -1)
            {
                var lat = (decimal)dataGridViewSavedLocations.Rows[e.RowIndex].Cells["latitude"].Value;
                var lng = (decimal)dataGridViewSavedLocations.Rows[e.RowIndex].Cells["longitude"].Value;
                RemoveMarkerOnSameLocationIfItExistsOnMap(lat, lng);

            }
            else if (column.Name == "Obriši lokaciju" & e.RowIndex > -1)
            {
                try
                {
                    DeleteSavedLocation(placeName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Podatci nisu pravilno učitani.\n Brisanje nije izvršeno.\n\n " + ex.Message, "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            else if (column.Name == "Uredi detalje" & e.RowIndex > -1)
            {
                OpenFormEditPlace(placeName);
            }
        }



        //==========================================================================================================================================================================================================================
        //========================================================================================  DataGridView Polygons ==================================================================================================
        private void GetRegionAndRegionPoints(ref Supan_Regions region, ref List<Supan_RegionPoints> regionPoints, string nazivOdabraneRegije, string opisOdabraneRegije)
        {
            using (var mapDB = new MapEntities())
            {
                region = mapDB.Supan_Regions.Where(r => r.NAZIV_REGIJE == nazivOdabraneRegije && r.OPIS_REGIJE == opisOdabraneRegije).FirstOrDefault();
                int regionId = region.ID;
                regionPoints = mapDB.Supan_RegionPoints.Where(rp => rp.ID_REGIJE == regionId).ToList();
            }
        }

        private void ShowPolygonFromDB(ref List<Supan_RegionPoints> regionPoints,int regionId)
        {
            bool alreadyExists = false;
            var firstPoint = regionPoints[0];
            var lastPoint = regionPoints[regionPoints.Count() - 1];
            PolygonAlreadyExists(ref firstPoint, ref lastPoint, ref alreadyExists);
            if (!alreadyExists)
            {

                drawRegion(regionId);
                tabControl1.SelectedTab = mapTab;
            }
        }

        private void DeletePolygonFromDB(ref Supan_Regions region)
        {
            try
            {
                DialogResult brisanjePoligona = MessageBox.Show("Jeste li sigurni da želite obrisati poligon?\n Brisanjem poligona resetirat će se svi poligoni na mapi.",
                                                               "Brisanje poligona",
                                                               MessageBoxButtons.YesNo);
                if (brisanjePoligona.Equals(DialogResult.Yes))
                {
                    ResetirajSavedLocationsBoxes();
                    using (var mapDB = new MapEntities())
                    {
                        int regionId = region.ID;
                        var polyPointsForRemoval = mapDB.Supan_RegionPoints.Where(rp => rp.ID_REGIJE == regionId).ToList();
                        if (polyPointsForRemoval.Count != 0)
                        {
                            foreach (var point in polyPointsForRemoval)
                            {
                                mapDB.Supan_RegionPoints.Remove(point);
                            }
                        }
                        var regionToRemove = mapDB.Supan_Regions.Where(r => r.ID == regionId).FirstOrDefault();
                        mapDB.Supan_Regions.Remove(regionToRemove);
                        mapDB.SaveChanges();
                        dataGridViewSavedPolygons = NapuniGridIzBaze<Supan_Regions>(dataGridViewSavedPolygons, mapDB.Supan_Regions);
                    }
                    MessageBox.Show("Uspješno ste obrisali poligon: " + region.NAZIV_REGIJE, "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NapuniTextBoxSuggest(searchPolygonsNameInGridBox, dataGridViewSavedPolygons);
                    gmap.Overlays.Remove(_polygons);
                    _polygons.Polygons.Clear();
                    _polygons.Clear();
                    NapuniPolyCombo();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Došlo je do greške. Brisanje nije izvršeno.\n\n " + ex.Message, "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridViewSavedPolygons_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var dataGridViewSavedPolygonsBySender = (DataGridView)sender;
            var column = dataGridViewSavedPolygonsBySender.Columns[e.ColumnIndex];
            var region = new Supan_Regions();
            var regionPoints = new List<Supan_RegionPoints>();
            string nazivOdabraneRegije = (string)dataGridViewSavedPolygons.Rows[e.RowIndex].Cells["RegionName"].Value;
            string opisOdabraneRegije = (string)dataGridViewSavedPolygons.Rows[e.RowIndex].Cells["OpisRegije"].Value;
            GetRegionAndRegionPoints(ref region, ref regionPoints, nazivOdabraneRegije, opisOdabraneRegije);

            if (column.Name == "Prikaži poligon" & e.RowIndex > -1)
            {
                ShowPolygonFromDB(ref regionPoints,region.ID);
            }
            else if (column.Name == "Obriši poligon" & e.RowIndex > -1)
            {
                DeletePolygonFromDB(ref region);
            }
            else if (column.Name == "Uredi detalje" & e.RowIndex > -1)
            {
                var polyName = (string)dataGridViewSavedPolygons.Rows[e.RowIndex].Cells["RegionName"].Value;
                OtvoriFormuZaUredivanjePoligona(polyName);
            }
        }

        //==========================================================================================================================================================================================================================
        //========================================================================================  DataGridView Administrating Types ==================================================================================================

        private void AddTypeForSearching(ref Supan_PlaceTypes placeType)
        {
            if (placeType.TYPE_ALLOWED == true)
            {
                MessageBox.Show("Taj tip lokacije već možete pretraživati ( " + placeType.TYPE_NAME + " )", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            placeType.TYPE_ALLOWED = true;
            MessageBox.Show("Od sad možete pretraživati sljedeći tip lokacije: " + placeType.TYPE_NAME, "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
            using (var mapDB = new MapEntities())
            {
                mapDB.Supan_PlaceTypes.AddOrUpdate(placeType); //requires using System.Data.Entity.Migrations;
                mapDB.SaveChanges();
            }
            NapuniTypeCombo();
        }

        private void DeleteTypeFromSearching(ref Supan_PlaceTypes placeType)
        {
            if (placeType.TYPE_ALLOWED == false)
            {
                MessageBox.Show("Taj tip lokacije je već onemogućen za pretraživanje ( " + placeType.TYPE_NAME + " )", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            placeType.TYPE_ALLOWED = false;
            MessageBox.Show("Od sad više ne možete pretraživati sljedeći tip lokacije: " + placeType.TYPE_NAME, "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
            using (var mapDB = new MapEntities())
            {
                mapDB.Supan_PlaceTypes.AddOrUpdate(placeType); //requires using System.Data.Entity.Migrations;
                mapDB.SaveChanges();

            }
            NapuniTypeCombo();
        }

        private void SaveTypeForSearchingInDB(Supan_PlaceTypes placeType)
        {
            using (var mapDB = new MapEntities())
            {
                if (placeType.TYPE_ALLOWED == true)
                {
                    mapDB.Supan_PlaceTypes.Add(placeType);
                }
                mapDB.SaveChanges();
            }
        }

        private void dataGridViewAdministration_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var dataGridViewAdministrationBySender = (DataGridView)sender;
            var column = dataGridViewAdministrationBySender.Columns[e.ColumnIndex];
            Supan_PlaceTypes placeType = new Supan_PlaceTypes();
            string typeName = String.Empty;
            try
            {
                typeName = (string)dataGridViewAdministration.Rows[e.RowIndex].Cells["typeName"].Value;

            }
            catch (Exception)
            {
                MessageBox.Show("Dogodila se greška.\nPokušajte ponovno ili ponovno pokrenite program\n", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            GetPlaceType(ref placeType, typeName);
            if (column.Name == "Dodaj tip" & e.RowIndex > -1)
            {
                AddTypeForSearching(ref placeType);
            }
            else if (column.Name == "Izbriši tip" & e.RowIndex > -1)
            {
                DeleteTypeFromSearching(ref placeType);
            }
            using (var mapDB = new MapEntities())
            {
                NapuniGridIzBaze<Supan_PlaceTypes>(dataGridViewAdministration, mapDB.Supan_PlaceTypes);
            }

        }


        //==========================================================================================================================================================================================================================
        //========================================================================================  GMap Support Functions ==================================================================================================


        private GMapMarker NapraviMarker(decimal lat, decimal lng, GMarkerGoogleType markerType, GMapOverlay markers)
        {
            GMapMarker marker =
                        new GMarkerGoogle(
                            new PointLatLng((double)lat, (double)lng),
                            markerType);
            if (tabControl1.SelectedTab == savedLocationsTab)
            {
                Supan_Places place = new Supan_Places();
                using (var mapDB = new MapEntities())
                {
                    place = mapDB.Supan_Places.Where(p => p.PLACE_LAT == (decimal)marker.Position.Lat && p.PLACE_LNG == (decimal)marker.Position.Lng).FirstOrDefault();
                }
                PostaviMarkerToolTip(marker, place.PLACE_NAME, place.PLACE_ADDRESS);
            }
            _markers.Markers.Add(marker);
            RefreshMarkersOverlay();
            return marker;
        }

        private void PostaviMarkerToolTip(GMapMarker marker, string placeName, string placeAddress)
        {
            string[] addressParts = placeAddress.Split(',');
            string ulica = addressParts[addressParts.Count() - 3];
            string grad = addressParts[addressParts.Count() - 2];
            string drzava = addressParts[addressParts.Count() - 1];
            marker.ToolTipText = "\n" + placeName  + ulica + grad + drzava;
            marker.ToolTip.Fill = Brushes.Black;
            marker.ToolTip.Foreground = Brushes.White;
            marker.ToolTip.Stroke = Pens.Black;
            marker.ToolTip.TextPadding = new Size(25, 17);
            marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
        }

        private void NapraviPoligon()
        {
            _polygon = new GMapPolygon(polyPoints, "My Area")
            {
                Fill = new SolidBrush(Color.FromArgb(50, Color.Red)),
                Stroke = new Pen(Color.Red, 1)
            };
        }


        private void ClearMarkerOverlay()
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
        }

        private void RefreshMarkersOverlay()
        {
            gmap.Overlays.Remove(_markers);
            gmap.Overlays.Add(_markers);
            gmap.Refresh();
        }

        private void ResetirajSavedLocationsInputAndAllMarkers()
        {
            gmap.Overlays.Remove(_markers);
            _markers.Markers.Clear();
            _markers.Clear();
            NapuniSavedLocationsTypeCombo();
            NapuniTextBoxSuggest(searchLocationsCityInGridBox, dataGridViewSavedLocations);
            NapuniTextBoxSuggest(searchLocationsNameInGridBox, dataGridViewSavedLocations);
        }

        private void ResetirajSavedLocationsBoxes()
        {
            NapuniSavedLocationsTypeCombo();
            NapuniTextBoxSuggest(searchLocationsCityInGridBox, dataGridViewSavedLocations);
            NapuniTextBoxSuggest(searchLocationsNameInGridBox, dataGridViewSavedLocations);
        }

        private void ClearMarkersAndPolygonsFromMap()
        {
            _markers.Markers.Clear();
            gmap.Overlays.Remove(_polygons);
            _polygons.Clear();
            _polygons.Polygons.Clear();
            gmap.Refresh();
        }


        private void PostaviPoligonNaMapu(bool canBeSaved)
        {
            _markers.Markers.Clear();
            _polygons.Polygons.Add(_polygon);
            _polygon.IsHitTestVisible = canBeSaved;
            gmap.Overlays.Remove(_polygons);
            gmap.Overlays.Add(_polygons);
            gmap.Refresh();
            gmap.Zoom = 13;
            gmap.Zoom = gmap.Zoom + 0.01;
        }


        private void RefreshPolyPointsAndPolygons()
        {
            polyPoints.Clear();
            polyPointsReadyTextBox.Text = "" + polyPoints.Count();
            _polygons.Polygons.Clear();
            gmap.Overlays.Remove(_polygons);
            gmap.Refresh();
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



        private void PolygonAlreadyExists(ref bool alreadyExists)
        {
            foreach (var poly in _polygons.Polygons)
            {
                alreadyExists = ((poly.From == _polygon.From) && (poly.To == _polygon.To));
                if (alreadyExists)
                {
                    break;
                }
            }
            if (alreadyExists == false)
            {
                PostaviPoligonNaMapu(true);
            }
            else
            {
                MessageBox.Show("Poligon koji želite nacrtati već je nacrtan.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PolygonAlreadyExists(ref Supan_RegionPoints pointFirst, ref Supan_RegionPoints pointLast, ref bool alreadyExists)
        {
            foreach (var poly in _polygons.Polygons)
            {
                var firstPoint = new PointLatLng((double)pointFirst.LAT, (double)pointFirst.LNG);
                var lastPoint = new PointLatLng((double)pointLast.LAT, (double)pointLast.LNG);
                alreadyExists = ((poly.From == firstPoint) && (poly.To == lastPoint));
                if (alreadyExists)
                {
                    break;
                }
            }
            if (alreadyExists == false)
            {
                PostaviPoligonNaMapu(true);
                dataGridViewSearchedPlaces.DataSource = null;
            }
            else
            {
                MessageBox.Show("Poligon koji želite nacrtati već je nacrtan.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void drawRegion(int id)
        {
            RefreshPolyPointsAndPolygons();

            List<Supan_RegionPoints> RegionPoints;
            using (var mapDB = new MapEntities())
            {
                RegionPoints = mapDB.Supan_RegionPoints.Where(r => r.ID_REGIJE == id).ToList();
            }
            foreach (var regionPoint in RegionPoints)
            {
                polyPoints.Add(new PointLatLng((double)regionPoint.LAT, (double)regionPoint.LNG));
            }
            NapraviPoligon();
            PostaviPoligonNaMapu(true);

            gmap.Position = new PointLatLng((double)RegionPoints[0].LAT, (double)RegionPoints[0].LNG);
        }


        private void RemoveMarkerOnSameLocationIfItExistsOnMap(decimal lat, decimal lng)
        {
            foreach (var marker in _markers.Markers.ToList())
            {
                var markerLat = decimal.Round((decimal)marker.Position.Lat, 6, MidpointRounding.AwayFromZero);
                var markerLng = decimal.Round((decimal)marker.Position.Lng, 6, MidpointRounding.AwayFromZero);
                if (lat == markerLat && lng == markerLng)
                {
                    _markers.Markers.Remove(marker);
                }
            }
            ZoomSavedLocation(lat, lng);
        }

        //==========================================================================================================================================================================================================================
        //========================================================================================  DB CHECING ==================================================================================================

        private bool PlaceAlreadyExistsInDB(decimal lat, decimal lng)
        {
            using (var mapDB = new MapEntities())
            {
                bool placeAlreadyExists = mapDB.Supan_Places.Any(p => p.PLACE_LAT == lat && p.PLACE_LNG == lng);
                return placeAlreadyExists;
            }
        }


        private void GetPlaceType(ref Supan_PlaceTypes placeType, string typeName)
        {
            using (var mapDB = new MapEntities())
            {
                placeType = mapDB.Supan_PlaceTypes.Where(t => t.TYPE_NAME == typeName).FirstOrDefault();
            }
        }


        private void GetRegionPointsFromDB(ref Supan_Regions region, ref List<Supan_RegionPoints> regionPoints, ref bool regionExists)
        {
            using (var mapDB = new MapEntities())
            {
                region = mapDB.Supan_Regions.Where(r => r.NAZIV_REGIJE == polyCombo.Text).FirstOrDefault();
                if (region != null)
                {
                    int idRegije = region.ID;
                    regionPoints = mapDB.Supan_RegionPoints.Where(rp => rp.ID_REGIJE == idRegije).ToList();
                    regionExists = true;
                }
                else
                {
                    MessageBox.Show("Odabrana regija ne postoji!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void ProvjeriImaLiRegijeIdenticnihKrajnjihTocakaUBazi(ref Supan_Regions region, ref List<Supan_RegionPoints> regionPoints, ref bool regionExists)
        {
            regionExists = false;
            int brojJednakihTocaka = 0;
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
                if (brojJednakihTocaka == poly.Points.Count() && brojJednakihTocaka == regionPoints.Count())
                {
                    regionExists = true;
                    break;
                }
            }

        }




        //==========================================================================================================================================================================================================================
        //========================================================================================  Functions considering COMBOBOXES ==================================================================================================



        private void ComboConfig<T>(List<T> lista, ComboBox comboBox, string displayMember, string text)
        {
            comboBox.SelectedIndex = -1;
            if (comboBox.DropDownStyle == ComboBoxStyle.DropDownList)
            {
                comboBox.AutoCompleteMode = AutoCompleteMode.None;
                comboBox.AutoCompleteSource = AutoCompleteSource.None;
            }
            else
            {
                comboBox.AutoCompleteMode = AutoCompleteMode.Suggest;
                comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            }
            comboBox.DataSource = lista;
            comboBox.DisplayMember = displayMember;
            comboBox.Text = text;
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




        //==========================================================================================================================================================================================================================
        //========================================================================================  FormSavePlace ==================================================================================================

        private void OtvoriFormuZaSpremanjeLokacije(GMapMarker item)
        {
            int typeId = -1;
            string placeName = String.Empty;
            string placeAddress = String.Empty;
            GetPlaceNameAndAddressForSavingLocationForm(item,ref placeName, ref placeAddress, ref typeId);
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
                if (formSavePlace.savingSuccessfull)
                {
                    using (var mapDB = new MapEntities())
                    {
                        dataGridViewSavedLocations = NapuniGridIzBaze<Supan_Places>(dataGridViewSavedLocations, mapDB.Supan_Places);
                    }
                    ResetirajSavedLocationsBoxes();
                }
            }
        }

        private void GetPlaceNameAndAddressForSavingLocationForm(GMapMarker item, ref string placeName, ref string placeAddress, ref int typeId)
        {
            foreach (DataGridViewRow row in dataGridViewSearchedPlaces.Rows)
            {
                if (Convert.ToDecimal(row.Cells[2].Value) == (decimal)item.Position.Lat && Convert.ToDecimal(row.Cells[3].Value) == (decimal)item.Position.Lng)
                {
                    placeName = row.Cells[0].Value.ToString();
                    placeAddress = row.Cells[1].Value.ToString();
                    typeId = (int)row.Cells[4].Value;
                }
            }
        }


        //==========================================================================================================================================================================================================================
        //========================================================================================  FormEditPlace ==================================================================================================

        private void OpenFormEditPlace(string placeName)
        {
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
                    btnSearchLocationsInGrid_Click(this, new EventArgs());
                }
            }
        }

       



        //==========================================================================================================================================================================================================================
        //========================================================================================  FormEditPolygon ==================================================================================================





        private void OtvoriFormuZaUredivanjePoligona(string polyName)
        {
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


        //==========================================================================================================================================================================================================================
        //========================================================================================  FormEditPolygon ==================================================================================================






        private void OtvoriFormuZaSpremanjePoligona()
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
            }
        }





        //    private void noviKorisnikToolStripMenuItem_Click(object sender, EventArgs e)
        //    {
        //        FormAddUser addUser = new FormAddUser(this);
        //        //addUser.Visible = false;
        //        addUser.ShowDialog();
        //    }

        //    private void izlazToolStripMenuItem1_Click(object sender, EventArgs e)
        //    {
        //        Application.Exit();
        //    }
        //}
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