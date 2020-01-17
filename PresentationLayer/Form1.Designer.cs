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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gmap = new GMap.NET.WindowsForms.GMapControl();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.mapTab = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.currentLngTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.currentLatTextBox = new System.Windows.Forms.TextBox();
            this.polyPointsReadyTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.startLocationBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchOnlyInPolygon = new System.Windows.Forms.CheckBox();
            this.typeCombo = new System.Windows.Forms.ComboBox();
            this.radiusBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.polyBox = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.polyCombo = new System.Windows.Forms.ComboBox();
            this.btnAddPointToPoly = new System.Windows.Forms.Button();
            this.btnAddPoly = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewSearchedPlaces = new System.Windows.Forms.DataGridView();
            this.locationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.savedLocationsTab = new System.Windows.Forms.TabPage();
            this.dataGridViewSavedPolygons = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
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
            this.RegionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpisRegije = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.searchLocationsInGridBox = new System.Windows.Forms.TextBox();
            this.searchPolygonsInGridBox = new System.Windows.Forms.TextBox();
            this.btnSearchPolygonsInGrid = new System.Windows.Forms.Button();
            this.btnSearchLocationsInGrid = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.mapTab.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.polyBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchedPlaces)).BeginInit();
            this.savedLocationsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSavedPolygons)).BeginInit();
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
            this.gmap.OnPolygonDoubleClick += new GMap.NET.WindowsForms.PolygonDoubleClick(this.gmap_OnPolygonDoubleClick);
            this.gmap.OnMapZoomChanged += new GMap.NET.MapZoomChanged(this.gmap_OnMapZoomChanged);
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
            this.mapTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mapTab.Controls.Add(this.groupBox3);
            this.mapTab.Controls.Add(this.groupBox2);
            this.mapTab.Controls.Add(this.groupBox1);
            this.mapTab.Controls.Add(this.polyBox);
            this.mapTab.Controls.Add(this.button1);
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.currentLngTextBox);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.currentLatTextBox);
            this.groupBox3.Controls.Add(this.polyPointsReadyTextBox);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(776, 298);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(432, 87);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informacije";
            // 
            // currentLngTextBox
            // 
            this.currentLngTextBox.Location = new System.Drawing.Point(143, 61);
            this.currentLngTextBox.Name = "currentLngTextBox";
            this.currentLngTextBox.Size = new System.Drawing.Size(283, 20);
            this.currentLngTextBox.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label13.Location = new System.Drawing.Point(111, 56);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 16);
            this.label13.TabIndex = 20;
            this.label13.Text = "Lng";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label12.Location = new System.Drawing.Point(112, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 16);
            this.label12.TabIndex = 19;
            this.label12.Text = "Lat";
            // 
            // currentLatTextBox
            // 
            this.currentLatTextBox.Location = new System.Drawing.Point(143, 37);
            this.currentLatTextBox.Name = "currentLatTextBox";
            this.currentLatTextBox.Size = new System.Drawing.Size(283, 20);
            this.currentLatTextBox.TabIndex = 18;
            // 
            // polyPointsReadyTextBox
            // 
            this.polyPointsReadyTextBox.Location = new System.Drawing.Point(263, 12);
            this.polyPointsReadyTextBox.Name = "polyPointsReadyTextBox";
            this.polyPointsReadyTextBox.Size = new System.Drawing.Size(163, 20);
            this.polyPointsReadyTextBox.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label11.Location = new System.Drawing.Point(6, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 16);
            this.label11.TabIndex = 16;
            this.label11.Text = "Trenutna lokacija: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label10.Location = new System.Drawing.Point(6, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(251, 16);
            this.label10.TabIndex = 15;
            this.label10.Text = "Trenutno točaka spremno za crtanje poligona";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.startLocationBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.searchButton);
            this.groupBox2.Controls.Add(this.searchOnlyInPolygon);
            this.groupBox2.Controls.Add(this.typeCombo);
            this.groupBox2.Controls.Add(this.radiusBox);
            this.groupBox2.Location = new System.Drawing.Point(756, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(465, 128);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtriraj lokacije";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Comic Sans MS", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(35, 31);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(78, 14);
            this.label16.TabIndex = 17;
            this.label16.Text = "Kliknite na mapu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Početna lokacija";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(6, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tip lokacije";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(6, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Radius (m)";
            // 
            // startLocationBox
            // 
            this.startLocationBox.Location = new System.Drawing.Point(119, 15);
            this.startLocationBox.Name = "startLocationBox";
            this.startLocationBox.Size = new System.Drawing.Size(206, 20);
            this.startLocationBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(336, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pretraži lokacije";
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.Image")));
            this.searchButton.Location = new System.Drawing.Point(331, 14);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(125, 73);
            this.searchButton.TabIndex = 3;
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchOnlyInPolygon
            // 
            this.searchOnlyInPolygon.AutoSize = true;
            this.searchOnlyInPolygon.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.searchOnlyInPolygon.Location = new System.Drawing.Point(119, 99);
            this.searchOnlyInPolygon.Name = "searchOnlyInPolygon";
            this.searchOnlyInPolygon.Size = new System.Drawing.Size(183, 23);
            this.searchOnlyInPolygon.TabIndex = 12;
            this.searchOnlyInPolygon.Text = "Pretraži samo u poligonu";
            this.searchOnlyInPolygon.UseVisualStyleBackColor = true;
            // 
            // typeCombo
            // 
            this.typeCombo.FormattingEnabled = true;
            this.typeCombo.Location = new System.Drawing.Point(119, 43);
            this.typeCombo.Name = "typeCombo";
            this.typeCombo.Size = new System.Drawing.Size(206, 21);
            this.typeCombo.TabIndex = 7;
            // 
            // radiusBox
            // 
            this.radiusBox.Location = new System.Drawing.Point(119, 70);
            this.radiusBox.Name = "radiusBox";
            this.radiusBox.Size = new System.Drawing.Size(206, 20);
            this.radiusBox.TabIndex = 9;
            this.radiusBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.radiusBox_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.removeButton);
            this.groupBox1.Location = new System.Drawing.Point(1046, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 143);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resetiraj mapu";
            // 
            // removeButton
            // 
            this.removeButton.Image = ((System.Drawing.Image)(resources.GetObject("removeButton.Image")));
            this.removeButton.Location = new System.Drawing.Point(17, 19);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(145, 118);
            this.removeButton.TabIndex = 10;
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // polyBox
            // 
            this.polyBox.Controls.Add(this.label15);
            this.polyBox.Controls.Add(this.label9);
            this.polyBox.Controls.Add(this.label8);
            this.polyBox.Controls.Add(this.polyCombo);
            this.polyBox.Controls.Add(this.btnAddPointToPoly);
            this.polyBox.Controls.Add(this.btnAddPoly);
            this.polyBox.Location = new System.Drawing.Point(773, 141);
            this.polyBox.Name = "polyBox";
            this.polyBox.Size = new System.Drawing.Size(264, 151);
            this.polyBox.TabIndex = 15;
            this.polyBox.TabStop = false;
            this.polyBox.Text = "Poligon";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Comic Sans MS", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(67, 46);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(174, 14);
            this.label15.TabIndex = 16;
            this.label15.Text = "Ostaviti prazno pri crtanju sa točkama";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label9.Location = new System.Drawing.Point(151, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Nacrtaj poligon";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label8.Location = new System.Drawing.Point(16, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Dodaj graničku točku";
            // 
            // polyCombo
            // 
            this.polyCombo.FormattingEnabled = true;
            this.polyCombo.Location = new System.Drawing.Point(19, 22);
            this.polyCombo.Name = "polyCombo";
            this.polyCombo.Size = new System.Drawing.Size(222, 21);
            this.polyCombo.TabIndex = 13;
            // 
            // btnAddPointToPoly
            // 
            this.btnAddPointToPoly.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddPointToPoly.BackgroundImage")));
            this.btnAddPointToPoly.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddPointToPoly.Location = new System.Drawing.Point(19, 96);
            this.btnAddPointToPoly.Name = "btnAddPointToPoly";
            this.btnAddPointToPoly.Size = new System.Drawing.Size(70, 49);
            this.btnAddPointToPoly.TabIndex = 11;
            this.btnAddPointToPoly.UseVisualStyleBackColor = true;
            this.btnAddPointToPoly.Click += new System.EventHandler(this.btnAddPointToPoly_Click);
            // 
            // btnAddPoly
            // 
            this.btnAddPoly.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddPoly.BackgroundImage")));
            this.btnAddPoly.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddPoly.Location = new System.Drawing.Point(171, 77);
            this.btnAddPoly.Name = "btnAddPoly";
            this.btnAddPoly.Size = new System.Drawing.Size(70, 49);
            this.btnAddPoly.TabIndex = 3;
            this.btnAddPoly.UseVisualStyleBackColor = true;
            this.btnAddPoly.Click += new System.EventHandler(this.btnAddPoly_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Location = new System.Drawing.Point(926, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 62);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = true;
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSearchedPlaces.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewSearchedPlaces.Location = new System.Drawing.Point(746, 391);
            this.dataGridViewSearchedPlaces.Name = "dataGridViewSearchedPlaces";
            this.dataGridViewSearchedPlaces.Size = new System.Drawing.Size(471, 233);
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
            this.savedLocationsTab.Controls.Add(this.btnSearchLocationsInGrid);
            this.savedLocationsTab.Controls.Add(this.btnSearchPolygonsInGrid);
            this.savedLocationsTab.Controls.Add(this.searchPolygonsInGridBox);
            this.savedLocationsTab.Controls.Add(this.searchLocationsInGridBox);
            this.savedLocationsTab.Controls.Add(this.label18);
            this.savedLocationsTab.Controls.Add(this.label17);
            this.savedLocationsTab.Controls.Add(this.dataGridViewSavedPolygons);
            this.savedLocationsTab.Controls.Add(this.label14);
            this.savedLocationsTab.Controls.Add(this.label6);
            this.savedLocationsTab.Controls.Add(this.dataGridViewSavedLocations);
            this.savedLocationsTab.Location = new System.Drawing.Point(4, 22);
            this.savedLocationsTab.Name = "savedLocationsTab";
            this.savedLocationsTab.Padding = new System.Windows.Forms.Padding(3);
            this.savedLocationsTab.Size = new System.Drawing.Size(1217, 624);
            this.savedLocationsTab.TabIndex = 1;
            this.savedLocationsTab.Text = "Spremljene lokacije / poligoni";
            this.savedLocationsTab.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSavedPolygons
            // 
            this.dataGridViewSavedPolygons.AllowUserToAddRows = false;
            this.dataGridViewSavedPolygons.AllowUserToDeleteRows = false;
            this.dataGridViewSavedPolygons.AllowUserToResizeColumns = false;
            this.dataGridViewSavedPolygons.AllowUserToResizeRows = false;
            this.dataGridViewSavedPolygons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSavedPolygons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RegionName,
            this.OpisRegije});
            this.dataGridViewSavedPolygons.Location = new System.Drawing.Point(-4, 382);
            this.dataGridViewSavedPolygons.Name = "dataGridViewSavedPolygons";
            this.dataGridViewSavedPolygons.Size = new System.Drawing.Size(1011, 232);
            this.dataGridViewSavedPolygons.TabIndex = 4;
            this.dataGridViewSavedPolygons.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSavedPolygons_CellContentClick);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(23, 311);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(236, 23);
            this.label14.TabIndex = 3;
            this.label14.Text = "SPREMLJENI POLIGONI";
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
            this.dataGridViewSavedLocations.Location = new System.Drawing.Point(3, 76);
            this.dataGridViewSavedLocations.Name = "dataGridViewSavedLocations";
            this.dataGridViewSavedLocations.Size = new System.Drawing.Size(1000, 231);
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
            // RegionName
            // 
            this.RegionName.DataPropertyName = "NAZIV_REGIJE";
            this.RegionName.HeaderText = "Naziv";
            this.RegionName.Name = "RegionName";
            this.RegionName.ReadOnly = true;
            this.RegionName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.RegionName.Width = 200;
            // 
            // OpisRegije
            // 
            this.OpisRegije.DataPropertyName = "OPIS_REGIJE";
            this.OpisRegije.HeaderText = "Opis";
            this.OpisRegije.Name = "OpisRegije";
            this.OpisRegije.ReadOnly = true;
            this.OpisRegije.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.OpisRegije.Width = 500;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label17.Location = new System.Drawing.Point(524, 338);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(179, 19);
            this.label17.TabIndex = 5;
            this.label17.Text = "Pretraži poligone po nazivu";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label18.Location = new System.Drawing.Point(535, 26);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(174, 19);
            this.label18.TabIndex = 6;
            this.label18.Text = "Pretraži lokacije po gradu";
            // 
            // searchLocationsInGridBox
            // 
            this.searchLocationsInGridBox.Location = new System.Drawing.Point(709, 25);
            this.searchLocationsInGridBox.Name = "searchLocationsInGridBox";
            this.searchLocationsInGridBox.Size = new System.Drawing.Size(222, 20);
            this.searchLocationsInGridBox.TabIndex = 7;
            // 
            // searchPolygonsInGridBox
            // 
            this.searchPolygonsInGridBox.Location = new System.Drawing.Point(709, 337);
            this.searchPolygonsInGridBox.Name = "searchPolygonsInGridBox";
            this.searchPolygonsInGridBox.Size = new System.Drawing.Size(222, 20);
            this.searchPolygonsInGridBox.TabIndex = 8;
            // 
            // btnSearchPolygonsInGrid
            // 
            this.btnSearchPolygonsInGrid.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchPolygonsInGrid.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchPolygonsInGrid.Image")));
            this.btnSearchPolygonsInGrid.Location = new System.Drawing.Point(937, 313);
            this.btnSearchPolygonsInGrid.Name = "btnSearchPolygonsInGrid";
            this.btnSearchPolygonsInGrid.Size = new System.Drawing.Size(66, 63);
            this.btnSearchPolygonsInGrid.TabIndex = 10;
            this.btnSearchPolygonsInGrid.UseVisualStyleBackColor = true;
            this.btnSearchPolygonsInGrid.Click += new System.EventHandler(this.btnSearchPolygonsInGrid_Click);
            this.btnSearchPolygonsInGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSearchPolygonsInGrid_KeyDown);
            // 
            // btnSearchLocationsInGrid
            // 
            this.btnSearchLocationsInGrid.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchLocationsInGrid.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchLocationsInGrid.Image")));
            this.btnSearchLocationsInGrid.Location = new System.Drawing.Point(937, 6);
            this.btnSearchLocationsInGrid.Name = "btnSearchLocationsInGrid";
            this.btnSearchLocationsInGrid.Size = new System.Drawing.Size(66, 63);
            this.btnSearchLocationsInGrid.TabIndex = 11;
            this.btnSearchLocationsInGrid.UseVisualStyleBackColor = true;
            this.btnSearchLocationsInGrid.Click += new System.EventHandler(this.btnSearchLocationsInGrid_Click);
            this.btnSearchLocationsInGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSearchLocationsInGrid_KeyDown);
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
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.polyBox.ResumeLayout(false);
            this.polyBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchedPlaces)).EndInit();
            this.savedLocationsTab.ResumeLayout(false);
            this.savedLocationsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSavedPolygons)).EndInit();
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
        private System.Windows.Forms.GroupBox polyBox;
        private System.Windows.Forms.ComboBox polyCombo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox currentLngTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox currentLatTextBox;
        private System.Windows.Forms.TextBox polyPointsReadyTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridViewSavedPolygons;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn OpisRegije;
        private System.Windows.Forms.TextBox searchPolygonsInGridBox;
        private System.Windows.Forms.TextBox searchLocationsInGridBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnSearchLocationsInGrid;
        private System.Windows.Forms.Button btnSearchPolygonsInGrid;
    }
}

