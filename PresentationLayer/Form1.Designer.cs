namespace PresentationLayer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gmap = new GMap.NET.WindowsForms.GMapControl();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.mapTab = new System.Windows.Forms.TabPage();
            this.btnAddPointToPoly = new System.Windows.Forms.Button();
            this.btnAddPoly = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.radiusBox = new System.Windows.Forms.TextBox();
            this.startLocationBox = new System.Windows.Forms.TextBox();
            this.typeCombo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewSearchedPlaces = new System.Windows.Forms.DataGridView();
            this.locationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.savedLocationsTab = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewSavedLocations = new System.Windows.Forms.DataGridView();
            this.placeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.latitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.longitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.searchValueBox = new System.Windows.Forms.TextBox();
            this.searchValueButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewAdministration = new System.Windows.Forms.DataGridView();
            this.typeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchOnlyInPolygon = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.mapTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchedPlaces)).BeginInit();
            this.savedLocationsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSavedLocations)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdministration)).BeginInit();
            this.SuspendLayout();
            // 
            // gmap
            // 
            this.gmap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gmap.Bearing = 0F;
            this.gmap.CanDragMap = true;
            this.gmap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmap.GrayScaleMode = false;
            this.gmap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmap.LevelsKeepInMemmory = 5;
            this.gmap.Location = new System.Drawing.Point(-4, 0);
            this.gmap.MarkersEnabled = true;
            this.gmap.MaxZoom = 18;
            this.gmap.MinZoom = 0;
            this.gmap.MouseWheelZoomEnabled = true;
            this.gmap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmap.Name = "gmap";
            this.gmap.NegativeMode = false;
            this.gmap.PolygonsEnabled = true;
            this.gmap.RetryLoadTile = 0;
            this.gmap.RoutesEnabled = true;
            this.gmap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmap.ShowTileGridLines = false;
            this.gmap.Size = new System.Drawing.Size(750, 624);
            this.gmap.TabIndex = 1;
            this.gmap.Zoom = 7D;
            this.gmap.OnMarkerClick += new GMap.NET.WindowsForms.MarkerClick(this.gmap_OnMarkerClick);
            this.gmap.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gmap_MouseClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.mapTab);
            this.tabControl1.Controls.Add(this.savedLocationsTab);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1225, 650);
            this.tabControl1.TabIndex = 2;
            // 
            // mapTab
            // 
            this.mapTab.BackColor = System.Drawing.Color.Transparent;
            this.mapTab.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mapTab.BackgroundImage")));
            this.mapTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mapTab.Controls.Add(this.button5);
            this.mapTab.Controls.Add(this.button4);
            this.mapTab.Controls.Add(this.button3);
            this.mapTab.Controls.Add(this.button2);
            this.mapTab.Controls.Add(this.button1);
            this.mapTab.Controls.Add(this.searchOnlyInPolygon);
            this.mapTab.Controls.Add(this.btnAddPointToPoly);
            this.mapTab.Controls.Add(this.btnAddPoly);
            this.mapTab.Controls.Add(this.removeButton);
            this.mapTab.Controls.Add(this.searchButton);
            this.mapTab.Controls.Add(this.radiusBox);
            this.mapTab.Controls.Add(this.startLocationBox);
            this.mapTab.Controls.Add(this.typeCombo);
            this.mapTab.Controls.Add(this.label4);
            this.mapTab.Controls.Add(this.label3);
            this.mapTab.Controls.Add(this.label2);
            this.mapTab.Controls.Add(this.label1);
            this.mapTab.Controls.Add(this.dataGridViewSearchedPlaces);
            this.mapTab.Controls.Add(this.gmap);
            this.mapTab.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mapTab.Location = new System.Drawing.Point(4, 22);
            this.mapTab.Name = "mapTab";
            this.mapTab.Padding = new System.Windows.Forms.Padding(3);
            this.mapTab.Size = new System.Drawing.Size(1217, 624);
            this.mapTab.TabIndex = 0;
            this.mapTab.Text = "Pretraga lokacija";
            // 
            // btnAddPointToPoly
            // 
            this.btnAddPointToPoly.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddPointToPoly.BackgroundImage")));
            this.btnAddPointToPoly.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddPointToPoly.Location = new System.Drawing.Point(1138, 3);
            this.btnAddPointToPoly.Name = "btnAddPointToPoly";
            this.btnAddPointToPoly.Size = new System.Drawing.Size(70, 62);
            this.btnAddPointToPoly.TabIndex = 11;
            this.btnAddPointToPoly.UseVisualStyleBackColor = true;
            this.btnAddPointToPoly.Click += new System.EventHandler(this.btnAddPointToPoly_Click);
            // 
            // btnAddPoly
            // 
            this.btnAddPoly.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddPoly.BackgroundImage")));
            this.btnAddPoly.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddPoly.Location = new System.Drawing.Point(986, 200);
            this.btnAddPoly.Name = "btnAddPoly";
            this.btnAddPoly.Size = new System.Drawing.Size(70, 62);
            this.btnAddPoly.TabIndex = 3;
            this.btnAddPoly.UseVisualStyleBackColor = true;
            this.btnAddPoly.Click += new System.EventHandler(this.btnAddPoly_Click);
            // 
            // removeButton
            // 
            this.removeButton.Image = ((System.Drawing.Image)(resources.GetObject("removeButton.Image")));
            this.removeButton.Location = new System.Drawing.Point(1062, 200);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(70, 62);
            this.removeButton.TabIndex = 10;
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.Image")));
            this.searchButton.Location = new System.Drawing.Point(1138, 200);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(70, 62);
            this.searchButton.TabIndex = 3;
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // radiusBox
            // 
            this.radiusBox.Location = new System.Drawing.Point(926, 128);
            this.radiusBox.Name = "radiusBox";
            this.radiusBox.Size = new System.Drawing.Size(282, 20);
            this.radiusBox.TabIndex = 9;
            this.radiusBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.radiusBox_KeyPress);
            // 
            // startLocationBox
            // 
            this.startLocationBox.Location = new System.Drawing.Point(926, 75);
            this.startLocationBox.Name = "startLocationBox";
            this.startLocationBox.Size = new System.Drawing.Size(282, 20);
            this.startLocationBox.TabIndex = 8;
            // 
            // typeCombo
            // 
            this.typeCombo.FormattingEnabled = true;
            this.typeCombo.Location = new System.Drawing.Point(926, 101);
            this.typeCombo.Name = "typeCombo";
            this.typeCombo.Size = new System.Drawing.Size(282, 21);
            this.typeCombo.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(752, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Maksimalna udaljenost (m)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(837, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tip lokacije";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(809, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Početna lokacija";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(900, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pretraži lokacije";
            // 
            // dataGridViewSearchedPlaces
            // 
            this.dataGridViewSearchedPlaces.AllowUserToAddRows = false;
            this.dataGridViewSearchedPlaces.AllowUserToDeleteRows = false;
            this.dataGridViewSearchedPlaces.AllowUserToResizeColumns = false;
            this.dataGridViewSearchedPlaces.AllowUserToResizeRows = false;
            this.dataGridViewSearchedPlaces.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridViewSearchedPlaces.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearchedPlaces.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.locationName,
            this.Adresa,
            this.Lat,
            this.Lng});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSearchedPlaces.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewSearchedPlaces.Location = new System.Drawing.Point(746, 274);
            this.dataGridViewSearchedPlaces.Name = "dataGridViewSearchedPlaces";
            this.dataGridViewSearchedPlaces.Size = new System.Drawing.Size(471, 350);
            this.dataGridViewSearchedPlaces.TabIndex = 2;
            this.dataGridViewSearchedPlaces.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSearchedPlaces_CellContentClick);
            // 
            // locationName
            // 
            this.locationName.DataPropertyName = "PLACE_NAME";
            this.locationName.Frozen = true;
            this.locationName.HeaderText = "Naziv lokacije";
            this.locationName.Name = "locationName";
            this.locationName.ReadOnly = true;
            this.locationName.Width = 180;
            // 
            // Adresa
            // 
            this.Adresa.DataPropertyName = "PLACE_ADDRESS";
            this.Adresa.Frozen = true;
            this.Adresa.HeaderText = "Adresa";
            this.Adresa.Name = "Adresa";
            this.Adresa.ReadOnly = true;
            this.Adresa.Visible = false;
            // 
            // Lat
            // 
            this.Lat.DataPropertyName = "PLACE_LAT";
            this.Lat.Frozen = true;
            this.Lat.HeaderText = "Latituda";
            this.Lat.Name = "Lat";
            this.Lat.ReadOnly = true;
            // 
            // Lng
            // 
            this.Lng.DataPropertyName = "PLACE_LNG";
            this.Lng.Frozen = true;
            this.Lng.HeaderText = "Longituda";
            this.Lng.Name = "Lng";
            this.Lng.ReadOnly = true;
            this.Lng.Width = 70;
            // 
            // savedLocationsTab
            // 
            this.savedLocationsTab.Controls.Add(this.label6);
            this.savedLocationsTab.Controls.Add(this.dataGridViewSavedLocations);
            this.savedLocationsTab.Location = new System.Drawing.Point(4, 22);
            this.savedLocationsTab.Name = "savedLocationsTab";
            this.savedLocationsTab.Padding = new System.Windows.Forms.Padding(3);
            this.savedLocationsTab.Size = new System.Drawing.Size(1217, 624);
            this.savedLocationsTab.TabIndex = 1;
            this.savedLocationsTab.Text = "Spremljene lokacije";
            this.savedLocationsTab.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(237, 23);
            this.label6.TabIndex = 2;
            this.label6.Text = "SPREMLJENE LOKACIJE";
            // 
            // dataGridViewSavedLocations
            // 
            this.dataGridViewSavedLocations.AllowUserToAddRows = false;
            this.dataGridViewSavedLocations.AllowUserToDeleteRows = false;
            this.dataGridViewSavedLocations.AllowUserToOrderColumns = true;
            this.dataGridViewSavedLocations.AllowUserToResizeColumns = false;
            this.dataGridViewSavedLocations.AllowUserToResizeRows = false;
            this.dataGridViewSavedLocations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSavedLocations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.placeName,
            this.placeAddress,
            this.latitude,
            this.longitude});
            this.dataGridViewSavedLocations.Location = new System.Drawing.Point(3, 62);
            this.dataGridViewSavedLocations.Name = "dataGridViewSavedLocations";
            this.dataGridViewSavedLocations.Size = new System.Drawing.Size(1211, 559);
            this.dataGridViewSavedLocations.TabIndex = 0;
            this.dataGridViewSavedLocations.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSavedLocations_CellContentClick);
            // 
            // placeName
            // 
            this.placeName.DataPropertyName = "PLACE_NAME";
            this.placeName.HeaderText = "Naziv lokacije";
            this.placeName.Name = "placeName";
            this.placeName.ReadOnly = true;
            this.placeName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.placeName.Width = 200;
            // 
            // placeAddress
            // 
            this.placeAddress.DataPropertyName = "PLACE_ADDRESS";
            this.placeAddress.HeaderText = "Adresa lokacije";
            this.placeAddress.Name = "placeAddress";
            this.placeAddress.ReadOnly = true;
            this.placeAddress.Width = 300;
            // 
            // latitude
            // 
            this.latitude.DataPropertyName = "PLACE_LAT";
            this.latitude.HeaderText = "Latituda";
            this.latitude.Name = "latitude";
            this.latitude.ReadOnly = true;
            // 
            // longitude
            // 
            this.longitude.DataPropertyName = "PLACE_LNG";
            this.longitude.HeaderText = "Longituda";
            this.longitude.Name = "longitude";
            this.longitude.ReadOnly = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.searchValueBox);
            this.tabPage3.Controls.Add(this.searchValueButton);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.dataGridViewAdministration);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1217, 624);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Administracija";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Pretraži tip";
            // 
            // searchValueBox
            // 
            this.searchValueBox.Location = new System.Drawing.Point(12, 95);
            this.searchValueBox.Name = "searchValueBox";
            this.searchValueBox.Size = new System.Drawing.Size(170, 20);
            this.searchValueBox.TabIndex = 5;
            this.searchValueBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchValueBox_KeyDown);
            // 
            // searchValueButton
            // 
            this.searchValueButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchValueButton.Image = ((System.Drawing.Image)(resources.GetObject("searchValueButton.Image")));
            this.searchValueButton.Location = new System.Drawing.Point(206, 57);
            this.searchValueButton.Name = "searchValueButton";
            this.searchValueButton.Size = new System.Drawing.Size(53, 58);
            this.searchValueButton.TabIndex = 4;
            this.searchValueButton.UseVisualStyleBackColor = true;
            this.searchValueButton.Click += new System.EventHandler(this.searchValueButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(377, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "Administracija tipova lokacija";
            // 
            // dataGridViewAdministration
            // 
            this.dataGridViewAdministration.AllowUserToAddRows = false;
            this.dataGridViewAdministration.AllowUserToDeleteRows = false;
            this.dataGridViewAdministration.AllowUserToResizeColumns = false;
            this.dataGridViewAdministration.AllowUserToResizeRows = false;
            this.dataGridViewAdministration.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdministration.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeName});
            this.dataGridViewAdministration.Location = new System.Drawing.Point(3, 140);
            this.dataGridViewAdministration.Name = "dataGridViewAdministration";
            this.dataGridViewAdministration.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridViewAdministration.Size = new System.Drawing.Size(355, 481);
            this.dataGridViewAdministration.TabIndex = 0;
            this.dataGridViewAdministration.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAdministration_CellContentClick);
            // 
            // typeName
            // 
            this.typeName.DataPropertyName = "TYPE_NAME";
            this.typeName.HeaderText = "Naziv tipa lokacije";
            this.typeName.MinimumWidth = 200;
            this.typeName.Name = "typeName";
            this.typeName.ReadOnly = true;
            this.typeName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.typeName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.typeName.Width = 200;
            // 
            // searchOnlyInPolygon
            // 
            this.searchOnlyInPolygon.AutoSize = true;
            this.searchOnlyInPolygon.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.searchOnlyInPolygon.Location = new System.Drawing.Point(926, 154);
            this.searchOnlyInPolygon.Name = "searchOnlyInPolygon";
            this.searchOnlyInPolygon.Size = new System.Drawing.Size(183, 23);
            this.searchOnlyInPolygon.TabIndex = 12;
            this.searchOnlyInPolygon.Text = "Pretraži samo u poligonu";
            this.searchOnlyInPolygon.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(855, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Slavonija";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.drawSlavonijaRegion);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(855, 200);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "SredišnjaRH";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.drawSredRHRegion);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(752, 229);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Istra";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.drawIstraRegion);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(752, 200);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "Primorje";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.drawPrimorjeRegion);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.button5.Location = new System.Drawing.Point(752, 174);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(97, 23);
            this.button5.TabIndex = 17;
            this.button5.Text = "Dalmacija";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.drawDalmacijaRegion);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 648);
            this.Controls.Add(this.tabControl1);
            this.MaximumSize = new System.Drawing.Size(1240, 687);
            this.MinimumSize = new System.Drawing.Size(1240, 687);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.mapTab.ResumeLayout(false);
            this.mapTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchedPlaces)).EndInit();
            this.savedLocationsTab.ResumeLayout(false);
            this.savedLocationsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSavedLocations)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdministration)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private GMap.NET.WindowsForms.GMapControl gmap;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage mapTab;
        private System.Windows.Forms.TabPage savedLocationsTab;
        private System.Windows.Forms.TextBox radiusBox;
        private System.Windows.Forms.TextBox startLocationBox;
        private System.Windows.Forms.ComboBox typeCombo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewSearchedPlaces;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewAdministration;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridViewSavedLocations;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox searchValueBox;
        private System.Windows.Forms.Button searchValueButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lng;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn latitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn longitude;
        private System.Windows.Forms.Button btnAddPoly;
        private System.Windows.Forms.Button btnAddPointToPoly;
        private System.Windows.Forms.CheckBox searchOnlyInPolygon;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

