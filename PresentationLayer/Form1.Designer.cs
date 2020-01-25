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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gmap = new GMap.NET.WindowsForms.GMapControl();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.mapTab = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.negativeModeRadio = new System.Windows.Forms.RadioButton();
            this.normalModeRadio = new System.Windows.Forms.RadioButton();
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
            this.apiProgressBar = new System.Windows.Forms.ProgressBar();
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
            this.typeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.savedLocationsTab = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.btnSearchPolygonsInGrid = new System.Windows.Forms.Button();
            this.searchPolygonsNameInGridBox = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.savedTypesCombo = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.searchLocationsNameInGridBox = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.btnSearchLocationsInGrid = new System.Windows.Forms.Button();
            this.searchLocationsCityInGridBox = new System.Windows.Forms.TextBox();
            this.dataGridViewSavedPolygons = new System.Windows.Forms.DataGridView();
            this.RegionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpisRegije = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewSavedLocations = new System.Windows.Forms.DataGridView();
            this.placeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.latitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.longitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.administrationTab = new System.Windows.Forms.TabPage();
            this.label27 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.searchTypesBox = new System.Windows.Forms.TextBox();
            this.searchTypesButton = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.dataGridViewAdministration = new System.Windows.Forms.DataGridView();
            this.typeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pretražiLokacijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretražiLokacijeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.spremljeneLokacijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spremljeniPoligoniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administracijaTipovaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iZLAZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.opcijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretražiLokacijeToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.spremljeneLokacijeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.spremljeniPoligoniToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.administracijaTipovaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.uputeZaKorištenjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label28 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.mapTab.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.polyBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchedPlaces)).BeginInit();
            this.savedLocationsTab.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSavedPolygons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSavedLocations)).BeginInit();
            this.administrationTab.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdministration)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
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
            this.gmap.GrayScaleMode = true;
            this.gmap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmap.LevelsKeepInMemmory = 5;
            this.gmap.Location = new System.Drawing.Point(-4, 0);
            this.gmap.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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
            this.gmap.Size = new System.Drawing.Size(752, 647);
            this.gmap.TabIndex = 1;
            this.gmap.Zoom = 5D;
            this.gmap.OnMarkerClick += new GMap.NET.WindowsForms.MarkerClick(this.gmap_OnMarkerClick);
            this.gmap.OnPolygonDoubleClick += new GMap.NET.WindowsForms.PolygonDoubleClick(this.gmap_OnPolygonDoubleClick);
            this.gmap.OnMapDrag += new GMap.NET.MapDrag(this.gmap_OnMapDrag);
            this.gmap.OnMapZoomChanged += new GMap.NET.MapZoomChanged(this.gmap_OnMapZoomChanged);
            this.gmap.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gmap_MouseClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.mapTab);
            this.tabControl1.Controls.Add(this.savedLocationsTab);
            this.tabControl1.Controls.Add(this.administrationTab);
            this.tabControl1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(100, 21);
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1225, 676);
            this.tabControl1.TabIndex = 2;
            // 
            // mapTab
            // 
            this.mapTab.BackColor = System.Drawing.Color.Transparent;
            this.mapTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mapTab.Controls.Add(this.groupBox7);
            this.mapTab.Controls.Add(this.groupBox3);
            this.mapTab.Controls.Add(this.groupBox2);
            this.mapTab.Controls.Add(this.groupBox1);
            this.mapTab.Controls.Add(this.polyBox);
            this.mapTab.Controls.Add(this.button1);
            this.mapTab.Controls.Add(this.dataGridViewSearchedPlaces);
            this.mapTab.Controls.Add(this.gmap);
            this.mapTab.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mapTab.Location = new System.Drawing.Point(4, 25);
            this.mapTab.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mapTab.Name = "mapTab";
            this.mapTab.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mapTab.Size = new System.Drawing.Size(1217, 647);
            this.mapTab.TabIndex = 0;
            this.mapTab.Text = "Pretraga lokacija";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.negativeModeRadio);
            this.groupBox7.Controls.Add(this.normalModeRadio);
            this.groupBox7.Location = new System.Drawing.Point(1028, 239);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(167, 52);
            this.groupBox7.TabIndex = 11;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Map mode";
            // 
            // negativeModeRadio
            // 
            this.negativeModeRadio.AutoSize = true;
            this.negativeModeRadio.Location = new System.Drawing.Point(83, 22);
            this.negativeModeRadio.Name = "negativeModeRadio";
            this.negativeModeRadio.Size = new System.Drawing.Size(71, 20);
            this.negativeModeRadio.TabIndex = 1;
            this.negativeModeRadio.TabStop = true;
            this.negativeModeRadio.Text = "Satellite";
            this.negativeModeRadio.UseVisualStyleBackColor = true;
            this.negativeModeRadio.CheckedChanged += new System.EventHandler(this.negativeModeRadio_CheckedChanged);
            // 
            // normalModeRadio
            // 
            this.normalModeRadio.AutoSize = true;
            this.normalModeRadio.Location = new System.Drawing.Point(13, 22);
            this.normalModeRadio.Name = "normalModeRadio";
            this.normalModeRadio.Size = new System.Drawing.Size(64, 20);
            this.normalModeRadio.TabIndex = 0;
            this.normalModeRadio.TabStop = true;
            this.normalModeRadio.Text = "Normal";
            this.normalModeRadio.UseVisualStyleBackColor = true;
            this.normalModeRadio.CheckedChanged += new System.EventHandler(this.normalModeRadio_CheckedChanged);
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
            this.groupBox3.Location = new System.Drawing.Point(756, 298);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(452, 87);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informacije";
            // 
            // currentLngTextBox
            // 
            this.currentLngTextBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.currentLngTextBox.Location = new System.Drawing.Point(143, 61);
            this.currentLngTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.currentLngTextBox.Name = "currentLngTextBox";
            this.currentLngTextBox.Size = new System.Drawing.Size(284, 23);
            this.currentLngTextBox.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(112, 56);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 16);
            this.label13.TabIndex = 20;
            this.label13.Text = "Lng";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(112, 36);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 16);
            this.label12.TabIndex = 19;
            this.label12.Text = "Lat";
            // 
            // currentLatTextBox
            // 
            this.currentLatTextBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.currentLatTextBox.Location = new System.Drawing.Point(143, 36);
            this.currentLatTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.currentLatTextBox.Name = "currentLatTextBox";
            this.currentLatTextBox.Size = new System.Drawing.Size(284, 23);
            this.currentLatTextBox.TabIndex = 18;
            // 
            // polyPointsReadyTextBox
            // 
            this.polyPointsReadyTextBox.Location = new System.Drawing.Point(263, 12);
            this.polyPointsReadyTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.polyPointsReadyTextBox.Name = "polyPointsReadyTextBox";
            this.polyPointsReadyTextBox.Size = new System.Drawing.Size(164, 23);
            this.polyPointsReadyTextBox.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(6, 35);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 16);
            this.label11.TabIndex = 16;
            this.label11.Text = "Trenutna lokacija: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(8, 17);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(251, 16);
            this.label10.TabIndex = 15;
            this.label10.Text = "Trenutno točaka spremno za crtanje poligona";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label28);
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
            this.groupBox2.Location = new System.Drawing.Point(756, 8);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(464, 127);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtriraj lokacije";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Comic Sans MS", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label16.Location = new System.Drawing.Point(116, 0);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(78, 14);
            this.label16.TabIndex = 17;
            this.label16.Text = "Kliknite na mapu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Početna lokacija";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(6, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tip lokacije";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(6, 70);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Radius (m)";
            // 
            // startLocationBox
            // 
            this.startLocationBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.startLocationBox.Location = new System.Drawing.Point(119, 16);
            this.startLocationBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.startLocationBox.Name = "startLocationBox";
            this.startLocationBox.Size = new System.Drawing.Size(206, 23);
            this.startLocationBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(336, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pretraži lokacije";
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.searchButton.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.Image")));
            this.searchButton.Location = new System.Drawing.Point(331, 14);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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
            this.searchOnlyInPolygon.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.searchOnlyInPolygon.Location = new System.Drawing.Point(142, 98);
            this.searchOnlyInPolygon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.searchOnlyInPolygon.Name = "searchOnlyInPolygon";
            this.searchOnlyInPolygon.Size = new System.Drawing.Size(183, 23);
            this.searchOnlyInPolygon.TabIndex = 12;
            this.searchOnlyInPolygon.Text = "Pretraži samo u poligonu";
            this.searchOnlyInPolygon.UseVisualStyleBackColor = true;
            // 
            // typeCombo
            // 
            this.typeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeCombo.ForeColor = System.Drawing.Color.Black;
            this.typeCombo.FormattingEnabled = true;
            this.typeCombo.Location = new System.Drawing.Point(119, 43);
            this.typeCombo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.typeCombo.Name = "typeCombo";
            this.typeCombo.Size = new System.Drawing.Size(206, 24);
            this.typeCombo.TabIndex = 7;
            // 
            // radiusBox
            // 
            this.radiusBox.ForeColor = System.Drawing.Color.Black;
            this.radiusBox.Location = new System.Drawing.Point(119, 70);
            this.radiusBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radiusBox.Name = "radiusBox";
            this.radiusBox.Size = new System.Drawing.Size(206, 23);
            this.radiusBox.TabIndex = 9;
            this.radiusBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.radiusBox_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.removeButton);
            this.groupBox1.Location = new System.Drawing.Point(1029, 140);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(185, 93);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resetiraj mapu";
            // 
            // removeButton
            // 
            this.removeButton.Image = ((System.Drawing.Image)(resources.GetObject("removeButton.Image")));
            this.removeButton.Location = new System.Drawing.Point(8, 18);
            this.removeButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(154, 61);
            this.removeButton.TabIndex = 10;
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // polyBox
            // 
            this.polyBox.Controls.Add(this.apiProgressBar);
            this.polyBox.Controls.Add(this.label15);
            this.polyBox.Controls.Add(this.label9);
            this.polyBox.Controls.Add(this.label8);
            this.polyBox.Controls.Add(this.polyCombo);
            this.polyBox.Controls.Add(this.btnAddPointToPoly);
            this.polyBox.Controls.Add(this.btnAddPoly);
            this.polyBox.Location = new System.Drawing.Point(756, 140);
            this.polyBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.polyBox.Name = "polyBox";
            this.polyBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.polyBox.Size = new System.Drawing.Size(265, 151);
            this.polyBox.TabIndex = 15;
            this.polyBox.TabStop = false;
            this.polyBox.Text = "Poligon";
            // 
            // apiProgressBar
            // 
            this.apiProgressBar.Location = new System.Drawing.Point(22, 61);
            this.apiProgressBar.Name = "apiProgressBar";
            this.apiProgressBar.Size = new System.Drawing.Size(219, 3);
            this.apiProgressBar.TabIndex = 19;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Comic Sans MS", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(68, 14);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(174, 14);
            this.label15.TabIndex = 16;
            this.label15.Text = "Ostaviti prazno pri crtanju sa točkama";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(151, 129);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Nacrtaj poligon";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(17, 73);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Dodaj graničku točku";
            // 
            // polyCombo
            // 
            this.polyCombo.FormattingEnabled = true;
            this.polyCombo.Location = new System.Drawing.Point(19, 31);
            this.polyCombo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.polyCombo.Name = "polyCombo";
            this.polyCombo.Size = new System.Drawing.Size(222, 24);
            this.polyCombo.TabIndex = 13;
            // 
            // btnAddPointToPoly
            // 
            this.btnAddPointToPoly.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddPointToPoly.BackgroundImage")));
            this.btnAddPointToPoly.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddPointToPoly.Location = new System.Drawing.Point(19, 92);
            this.btnAddPointToPoly.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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
            this.btnAddPoly.Location = new System.Drawing.Point(172, 77);
            this.btnAddPoly.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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
            this.dataGridViewSearchedPlaces.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridViewSearchedPlaces.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearchedPlaces.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.locationName,
            this.Adresa,
            this.Lat,
            this.Lng,
            this.typeId});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSearchedPlaces.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewSearchedPlaces.Location = new System.Drawing.Point(756, 391);
            this.dataGridViewSearchedPlaces.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridViewSearchedPlaces.Name = "dataGridViewSearchedPlaces";
            this.dataGridViewSearchedPlaces.Size = new System.Drawing.Size(456, 250);
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
            this.locationName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.locationName.Width = 150;
            // 
            // Adresa
            // 
            this.Adresa.DataPropertyName = "PLACE_ADDRESS";
            this.Adresa.Frozen = true;
            this.Adresa.HeaderText = "Adresa";
            this.Adresa.Name = "Adresa";
            this.Adresa.ReadOnly = true;
            this.Adresa.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Adresa.Width = 180;
            // 
            // Lat
            // 
            this.Lat.DataPropertyName = "PLACE_LAT";
            this.Lat.Frozen = true;
            this.Lat.HeaderText = "Latituda";
            this.Lat.Name = "Lat";
            this.Lat.ReadOnly = true;
            this.Lat.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Lat.Visible = false;
            // 
            // Lng
            // 
            this.Lng.DataPropertyName = "PLACE_LNG";
            this.Lng.Frozen = true;
            this.Lng.HeaderText = "Longituda";
            this.Lng.Name = "Lng";
            this.Lng.ReadOnly = true;
            this.Lng.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Lng.Visible = false;
            this.Lng.Width = 70;
            // 
            // typeId
            // 
            this.typeId.DataPropertyName = "PLACE_TYPE";
            this.typeId.Frozen = true;
            this.typeId.HeaderText = "Tip";
            this.typeId.Name = "typeId";
            this.typeId.ReadOnly = true;
            this.typeId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.typeId.Visible = false;
            // 
            // savedLocationsTab
            // 
            this.savedLocationsTab.BackColor = System.Drawing.Color.DimGray;
            this.savedLocationsTab.Controls.Add(this.label14);
            this.savedLocationsTab.Controls.Add(this.groupBox5);
            this.savedLocationsTab.Controls.Add(this.groupBox4);
            this.savedLocationsTab.Controls.Add(this.dataGridViewSavedPolygons);
            this.savedLocationsTab.Controls.Add(this.label6);
            this.savedLocationsTab.Controls.Add(this.dataGridViewSavedLocations);
            this.savedLocationsTab.Location = new System.Drawing.Point(4, 25);
            this.savedLocationsTab.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.savedLocationsTab.Name = "savedLocationsTab";
            this.savedLocationsTab.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.savedLocationsTab.Size = new System.Drawing.Size(1217, 647);
            this.savedLocationsTab.TabIndex = 1;
            this.savedLocationsTab.Text = "Spremljene lokacije / poligoni";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(11, 339);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(374, 40);
            this.label14.TabIndex = 13;
            this.label14.Text = "SPREMLJENI POLIGONI";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.DimGray;
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.btnSearchPolygonsInGrid);
            this.groupBox5.Controls.Add(this.searchPolygonsNameInGridBox);
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox5.Location = new System.Drawing.Point(1016, 374);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox5.Size = new System.Drawing.Size(191, 239);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Filtriraj poligone";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label17.Location = new System.Drawing.Point(26, 60);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 19);
            this.label17.TabIndex = 18;
            this.label17.Text = "Naziv";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Comic Sans MS", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Gainsboro;
            this.label18.Location = new System.Drawing.Point(74, 105);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(103, 14);
            this.label18.TabIndex = 17;
            this.label18.Text = "Unesite naziv poligona";
            // 
            // btnSearchPolygonsInGrid
            // 
            this.btnSearchPolygonsInGrid.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchPolygonsInGrid.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchPolygonsInGrid.Image")));
            this.btnSearchPolygonsInGrid.Location = new System.Drawing.Point(25, 147);
            this.btnSearchPolygonsInGrid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSearchPolygonsInGrid.Name = "btnSearchPolygonsInGrid";
            this.btnSearchPolygonsInGrid.Size = new System.Drawing.Size(152, 62);
            this.btnSearchPolygonsInGrid.TabIndex = 10;
            this.btnSearchPolygonsInGrid.UseVisualStyleBackColor = true;
            this.btnSearchPolygonsInGrid.Click += new System.EventHandler(this.btnSearchPolygonsInGrid_Click);
            // 
            // searchPolygonsNameInGridBox
            // 
            this.searchPolygonsNameInGridBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.searchPolygonsNameInGridBox.Location = new System.Drawing.Point(25, 82);
            this.searchPolygonsNameInGridBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.searchPolygonsNameInGridBox.Name = "searchPolygonsNameInGridBox";
            this.searchPolygonsNameInGridBox.Size = new System.Drawing.Size(152, 23);
            this.searchPolygonsNameInGridBox.TabIndex = 8;
            this.searchPolygonsNameInGridBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchPolygonsNameInGridBox_KeyUp);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.DimGray;
            this.groupBox4.Controls.Add(this.savedTypesCombo);
            this.groupBox4.Controls.Add(this.label24);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.searchLocationsNameInGridBox);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.btnSearchLocationsInGrid);
            this.groupBox4.Controls.Add(this.searchLocationsCityInGridBox);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox4.Location = new System.Drawing.Point(1016, 45);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Size = new System.Drawing.Size(191, 288);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Filtriraj lokacije";
            // 
            // savedTypesCombo
            // 
            this.savedTypesCombo.BackColor = System.Drawing.Color.White;
            this.savedTypesCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.savedTypesCombo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.savedTypesCombo.FormattingEnabled = true;
            this.savedTypesCombo.Location = new System.Drawing.Point(25, 164);
            this.savedTypesCombo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.savedTypesCombo.Name = "savedTypesCombo";
            this.savedTypesCombo.Size = new System.Drawing.Size(152, 24);
            this.savedTypesCombo.TabIndex = 26;
            this.savedTypesCombo.SelectionChangeCommitted += new System.EventHandler(this.savedTypesCombo_SelectionChangeCommitted);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Comic Sans MS", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Gainsboro;
            this.label24.Location = new System.Drawing.Point(75, 191);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(102, 14);
            this.label24.TabIndex = 25;
            this.label24.Text = "Odaberite tip lokacije";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(20, 143);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(83, 19);
            this.label23.TabIndex = 23;
            this.label23.Text = "Tip lokacije";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Comic Sans MS", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Gainsboro;
            this.label22.Location = new System.Drawing.Point(81, 65);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(102, 14);
            this.label22.TabIndex = 22;
            this.label22.Text = "Unesite naziv lokacije";
            // 
            // searchLocationsNameInGridBox
            // 
            this.searchLocationsNameInGridBox.BackColor = System.Drawing.Color.White;
            this.searchLocationsNameInGridBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.searchLocationsNameInGridBox.Location = new System.Drawing.Point(25, 42);
            this.searchLocationsNameInGridBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.searchLocationsNameInGridBox.Name = "searchLocationsNameInGridBox";
            this.searchLocationsNameInGridBox.Size = new System.Drawing.Size(152, 23);
            this.searchLocationsNameInGridBox.TabIndex = 21;
            this.searchLocationsNameInGridBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchLocationsNameInGridBox_KeyUp);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(20, 18);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(44, 19);
            this.label21.TabIndex = 20;
            this.label21.Text = "Naziv";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(20, 74);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(39, 19);
            this.label20.TabIndex = 19;
            this.label20.Text = "Grad";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Comic Sans MS", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Gainsboro;
            this.label19.Location = new System.Drawing.Point(90, 120);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(92, 14);
            this.label19.TabIndex = 18;
            this.label19.Text = "Unesite naziv grada";
            // 
            // btnSearchLocationsInGrid
            // 
            this.btnSearchLocationsInGrid.BackColor = System.Drawing.Color.White;
            this.btnSearchLocationsInGrid.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchLocationsInGrid.ForeColor = System.Drawing.Color.White;
            this.btnSearchLocationsInGrid.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchLocationsInGrid.Image")));
            this.btnSearchLocationsInGrid.Location = new System.Drawing.Point(25, 220);
            this.btnSearchLocationsInGrid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSearchLocationsInGrid.Name = "btnSearchLocationsInGrid";
            this.btnSearchLocationsInGrid.Size = new System.Drawing.Size(152, 62);
            this.btnSearchLocationsInGrid.TabIndex = 11;
            this.btnSearchLocationsInGrid.UseVisualStyleBackColor = false;
            this.btnSearchLocationsInGrid.Click += new System.EventHandler(this.btnSearchLocationsInGrid_Click);
            // 
            // searchLocationsCityInGridBox
            // 
            this.searchLocationsCityInGridBox.BackColor = System.Drawing.Color.White;
            this.searchLocationsCityInGridBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.searchLocationsCityInGridBox.Location = new System.Drawing.Point(25, 96);
            this.searchLocationsCityInGridBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.searchLocationsCityInGridBox.Name = "searchLocationsCityInGridBox";
            this.searchLocationsCityInGridBox.Size = new System.Drawing.Size(152, 23);
            this.searchLocationsCityInGridBox.TabIndex = 7;
            this.searchLocationsCityInGridBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchLocationsCityInGridBox_KeyUp);
            // 
            // dataGridViewSavedPolygons
            // 
            this.dataGridViewSavedPolygons.AllowUserToAddRows = false;
            this.dataGridViewSavedPolygons.AllowUserToDeleteRows = false;
            this.dataGridViewSavedPolygons.AllowUserToResizeColumns = false;
            this.dataGridViewSavedPolygons.AllowUserToResizeRows = false;
            this.dataGridViewSavedPolygons.BackgroundColor = System.Drawing.Color.DimGray;
            this.dataGridViewSavedPolygons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSavedPolygons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RegionName,
            this.OpisRegije});
            this.dataGridViewSavedPolygons.Location = new System.Drawing.Point(8, 382);
            this.dataGridViewSavedPolygons.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridViewSavedPolygons.Name = "dataGridViewSavedPolygons";
            this.dataGridViewSavedPolygons.ReadOnly = true;
            this.dataGridViewSavedPolygons.Size = new System.Drawing.Size(1003, 231);
            this.dataGridViewSavedPolygons.TabIndex = 4;
            this.dataGridViewSavedPolygons.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSavedPolygons_CellContentClick);
            // 
            // RegionName
            // 
            this.RegionName.DataPropertyName = "NAZIV_REGIJE";
            this.RegionName.HeaderText = "Naziv";
            this.RegionName.Name = "RegionName";
            this.RegionName.ReadOnly = true;
            this.RegionName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.RegionName.Width = 300;
            // 
            // OpisRegije
            // 
            this.OpisRegije.DataPropertyName = "OPIS_REGIJE";
            this.OpisRegije.HeaderText = "Opis";
            this.OpisRegije.Name = "OpisRegije";
            this.OpisRegije.ReadOnly = true;
            this.OpisRegije.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.OpisRegije.Width = 415;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Location = new System.Drawing.Point(9, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(449, 49);
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
            this.dataGridViewSavedLocations.BackgroundColor = System.Drawing.Color.DimGray;
            this.dataGridViewSavedLocations.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewSavedLocations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSavedLocations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.placeName,
            this.placeAddress,
            this.placeDescription,
            this.latitude,
            this.longitude});
            this.dataGridViewSavedLocations.Location = new System.Drawing.Point(8, 52);
            this.dataGridViewSavedLocations.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridViewSavedLocations.Name = "dataGridViewSavedLocations";
            this.dataGridViewSavedLocations.Size = new System.Drawing.Size(1003, 282);
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
            this.placeName.Width = 150;
            // 
            // placeAddress
            // 
            this.placeAddress.DataPropertyName = "PLACE_ADDRESS";
            this.placeAddress.HeaderText = "Adresa lokacije";
            this.placeAddress.Name = "placeAddress";
            this.placeAddress.ReadOnly = true;
            this.placeAddress.Width = 285;
            // 
            // placeDescription
            // 
            this.placeDescription.DataPropertyName = "PLACE_DESCRIPTION";
            this.placeDescription.HeaderText = "Opis lokacije";
            this.placeDescription.Name = "placeDescription";
            this.placeDescription.ReadOnly = true;
            this.placeDescription.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.placeDescription.Width = 300;
            // 
            // latitude
            // 
            this.latitude.DataPropertyName = "PLACE_LAT";
            this.latitude.HeaderText = "Latituda";
            this.latitude.Name = "latitude";
            this.latitude.ReadOnly = true;
            this.latitude.Visible = false;
            // 
            // longitude
            // 
            this.longitude.DataPropertyName = "PLACE_LNG";
            this.longitude.HeaderText = "Longituda";
            this.longitude.Name = "longitude";
            this.longitude.ReadOnly = true;
            this.longitude.Visible = false;
            // 
            // administrationTab
            // 
            this.administrationTab.BackColor = System.Drawing.Color.DimGray;
            this.administrationTab.Controls.Add(this.label27);
            this.administrationTab.Controls.Add(this.groupBox6);
            this.administrationTab.Controls.Add(this.label25);
            this.administrationTab.Controls.Add(this.dataGridViewAdministration);
            this.administrationTab.Location = new System.Drawing.Point(4, 25);
            this.administrationTab.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.administrationTab.Name = "administrationTab";
            this.administrationTab.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.administrationTab.Size = new System.Drawing.Size(1217, 647);
            this.administrationTab.TabIndex = 2;
            this.administrationTab.Text = "Administracija";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.Gainsboro;
            this.label27.Location = new System.Drawing.Point(260, 82);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(473, 19);
            this.label27.TabIndex = 20;
            this.label27.Text = "Ovdje možete odobriti ili zabraniti pretraživanje određenog tipa lokacije";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label26);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.searchTypesBox);
            this.groupBox6.Controls.Add(this.searchTypesButton);
            this.groupBox6.Location = new System.Drawing.Point(749, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(435, 125);
            this.groupBox6.TabIndex = 19;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Filtriraj tipove lokacija";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.White;
            this.label26.Location = new System.Drawing.Point(38, 25);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(93, 21);
            this.label26.TabIndex = 19;
            this.label26.Text = "Tip lokacije";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(296, 98);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Pretraži tip";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(90, 75);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 14);
            this.label5.TabIndex = 18;
            this.label5.Text = "Unesite naziv tipa lokacije";
            // 
            // searchTypesBox
            // 
            this.searchTypesBox.Location = new System.Drawing.Point(42, 49);
            this.searchTypesBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.searchTypesBox.Name = "searchTypesBox";
            this.searchTypesBox.Size = new System.Drawing.Size(170, 23);
            this.searchTypesBox.TabIndex = 5;
            this.searchTypesBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchValueBox_KeyUp);
            // 
            // searchTypesButton
            // 
            this.searchTypesButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchTypesButton.BackgroundImage")));
            this.searchTypesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.searchTypesButton.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTypesButton.Location = new System.Drawing.Point(262, 22);
            this.searchTypesButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.searchTypesButton.Name = "searchTypesButton";
            this.searchTypesButton.Size = new System.Drawing.Size(156, 73);
            this.searchTypesButton.TabIndex = 4;
            this.searchTypesButton.UseVisualStyleBackColor = true;
            this.searchTypesButton.Click += new System.EventHandler(this.searchTypesButton_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(23, 28);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(710, 49);
            this.label25.TabIndex = 7;
            this.label25.Text = "ADMINISTRACIJA TIPOVA LOKACIJA";
            // 
            // dataGridViewAdministration
            // 
            this.dataGridViewAdministration.AllowUserToAddRows = false;
            this.dataGridViewAdministration.AllowUserToDeleteRows = false;
            this.dataGridViewAdministration.AllowUserToResizeColumns = false;
            this.dataGridViewAdministration.AllowUserToResizeRows = false;
            this.dataGridViewAdministration.BackgroundColor = System.Drawing.Color.DimGray;
            this.dataGridViewAdministration.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdministration.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeName});
            this.dataGridViewAdministration.Location = new System.Drawing.Point(12, 137);
            this.dataGridViewAdministration.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridViewAdministration.Name = "dataGridViewAdministration";
            this.dataGridViewAdministration.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridViewAdministration.Size = new System.Drawing.Size(1186, 469);
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
            this.typeName.Width = 1028;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretražiLokacijeToolStripMenuItem,
            this.iZLAZToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(109, 48);
            // 
            // pretražiLokacijeToolStripMenuItem
            // 
            this.pretražiLokacijeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretražiLokacijeToolStripMenuItem1,
            this.spremljeneLokacijeToolStripMenuItem,
            this.spremljeniPoligoniToolStripMenuItem,
            this.administracijaTipovaToolStripMenuItem});
            this.pretražiLokacijeToolStripMenuItem.Name = "pretražiLokacijeToolStripMenuItem";
            this.pretražiLokacijeToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.pretražiLokacijeToolStripMenuItem.Text = "Opcije";
            // 
            // pretražiLokacijeToolStripMenuItem1
            // 
            this.pretražiLokacijeToolStripMenuItem1.Name = "pretražiLokacijeToolStripMenuItem1";
            this.pretražiLokacijeToolStripMenuItem1.Size = new System.Drawing.Size(186, 22);
            this.pretražiLokacijeToolStripMenuItem1.Text = "Pretraži lokacije";
            this.pretražiLokacijeToolStripMenuItem1.Click += new System.EventHandler(this.pretražiLokacijeToolStripMenuItem1_Click);
            // 
            // spremljeneLokacijeToolStripMenuItem
            // 
            this.spremljeneLokacijeToolStripMenuItem.Name = "spremljeneLokacijeToolStripMenuItem";
            this.spremljeneLokacijeToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.spremljeneLokacijeToolStripMenuItem.Text = "Spremljene lokacije";
            this.spremljeneLokacijeToolStripMenuItem.Click += new System.EventHandler(this.spremljeneLokacijeToolStripMenuItem_Click);
            // 
            // spremljeniPoligoniToolStripMenuItem
            // 
            this.spremljeniPoligoniToolStripMenuItem.Name = "spremljeniPoligoniToolStripMenuItem";
            this.spremljeniPoligoniToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.spremljeniPoligoniToolStripMenuItem.Text = "Spremljeni poligoni";
            this.spremljeniPoligoniToolStripMenuItem.Click += new System.EventHandler(this.spremljeniPoligoniToolStripMenuItem_Click);
            // 
            // administracijaTipovaToolStripMenuItem
            // 
            this.administracijaTipovaToolStripMenuItem.Name = "administracijaTipovaToolStripMenuItem";
            this.administracijaTipovaToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.administracijaTipovaToolStripMenuItem.Text = "Administracija tipova";
            this.administracijaTipovaToolStripMenuItem.Click += new System.EventHandler(this.administracijaTipovaToolStripMenuItem_Click);
            // 
            // iZLAZToolStripMenuItem
            // 
            this.iZLAZToolStripMenuItem.Name = "iZLAZToolStripMenuItem";
            this.iZLAZToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.iZLAZToolStripMenuItem.Text = "Izlaz";
            this.iZLAZToolStripMenuItem.Click += new System.EventHandler(this.iZLAZToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripButton1});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1224, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcijeToolStripMenuItem,
            this.izlazToolStripMenuItem1});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(62, 22);
            this.toolStripDropDownButton1.Text = "Izbornik";
            // 
            // opcijeToolStripMenuItem
            // 
            this.opcijeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pretražiLokacijeToolStripMenuItem2,
            this.spremljeneLokacijeToolStripMenuItem1,
            this.spremljeniPoligoniToolStripMenuItem1,
            this.administracijaTipovaToolStripMenuItem1});
            this.opcijeToolStripMenuItem.Name = "opcijeToolStripMenuItem";
            this.opcijeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.opcijeToolStripMenuItem.Text = "Opcije";
            // 
            // pretražiLokacijeToolStripMenuItem2
            // 
            this.pretražiLokacijeToolStripMenuItem2.Name = "pretražiLokacijeToolStripMenuItem2";
            this.pretražiLokacijeToolStripMenuItem2.Size = new System.Drawing.Size(186, 22);
            this.pretražiLokacijeToolStripMenuItem2.Text = "Pretraži lokacije";
            this.pretražiLokacijeToolStripMenuItem2.Click += new System.EventHandler(this.pretražiLokacijeToolStripMenuItem2_Click);
            // 
            // spremljeneLokacijeToolStripMenuItem1
            // 
            this.spremljeneLokacijeToolStripMenuItem1.Name = "spremljeneLokacijeToolStripMenuItem1";
            this.spremljeneLokacijeToolStripMenuItem1.Size = new System.Drawing.Size(186, 22);
            this.spremljeneLokacijeToolStripMenuItem1.Text = "Spremljene lokacije";
            this.spremljeneLokacijeToolStripMenuItem1.Click += new System.EventHandler(this.spremljeneLokacijeToolStripMenuItem1_Click);
            // 
            // spremljeniPoligoniToolStripMenuItem1
            // 
            this.spremljeniPoligoniToolStripMenuItem1.Name = "spremljeniPoligoniToolStripMenuItem1";
            this.spremljeniPoligoniToolStripMenuItem1.Size = new System.Drawing.Size(186, 22);
            this.spremljeniPoligoniToolStripMenuItem1.Text = "Spremljeni poligoni";
            this.spremljeniPoligoniToolStripMenuItem1.Click += new System.EventHandler(this.spremljeniPoligoniToolStripMenuItem1_Click);
            // 
            // administracijaTipovaToolStripMenuItem1
            // 
            this.administracijaTipovaToolStripMenuItem1.Name = "administracijaTipovaToolStripMenuItem1";
            this.administracijaTipovaToolStripMenuItem1.Size = new System.Drawing.Size(186, 22);
            this.administracijaTipovaToolStripMenuItem1.Text = "Administracija tipova";
            this.administracijaTipovaToolStripMenuItem1.Click += new System.EventHandler(this.administracijaTipovaToolStripMenuItem1_Click);
            // 
            // izlazToolStripMenuItem1
            // 
            this.izlazToolStripMenuItem1.Name = "izlazToolStripMenuItem1";
            this.izlazToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.izlazToolStripMenuItem1.Text = "Izlaz";
            this.izlazToolStripMenuItem1.Click += new System.EventHandler(this.izlazToolStripMenuItem1_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uputeZaKorištenjeToolStripMenuItem,
            this.oProgramuToolStripMenuItem});
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(58, 22);
            this.toolStripButton1.Text = "Pomoć";
            // 
            // uputeZaKorištenjeToolStripMenuItem
            // 
            this.uputeZaKorištenjeToolStripMenuItem.Name = "uputeZaKorištenjeToolStripMenuItem";
            this.uputeZaKorištenjeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.uputeZaKorištenjeToolStripMenuItem.Text = "Upute za korištenje";
            this.uputeZaKorištenjeToolStripMenuItem.Click += new System.EventHandler(this.uputeZaKorištenjeToolStripMenuItem_Click);
            // 
            // oProgramuToolStripMenuItem
            // 
            this.oProgramuToolStripMenuItem.Name = "oProgramuToolStripMenuItem";
            this.oProgramuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.oProgramuToolStripMenuItem.Text = "O programu";
            this.oProgramuToolStripMenuItem.Click += new System.EventHandler(this.oProgramuToolStripMenuItem_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Comic Sans MS", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label28.Location = new System.Drawing.Point(8, 90);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(59, 14);
            this.label28.TabIndex = 18;
            this.label28.Text = "max. 50000";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1224, 691);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1240, 730);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1240, 730);
            this.Name = "Form1";
            this.Text = "Google Places";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.mapTab.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
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
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSavedPolygons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSavedLocations)).EndInit();
            this.administrationTab.ResumeLayout(false);
            this.administrationTab.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdministration)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TabPage administrationTab;
        private System.Windows.Forms.DataGridView dataGridViewAdministration;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridViewSavedLocations;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox searchTypesBox;
        private System.Windows.Forms.Button searchTypesButton;
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
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox searchPolygonsNameInGridBox;
        private System.Windows.Forms.TextBox searchLocationsCityInGridBox;
        private System.Windows.Forms.Button btnSearchLocationsInGrid;
        private System.Windows.Forms.Button btnSearchPolygonsInGrid;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox savedTypesCombo;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox searchLocationsNameInGridBox;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn OpisRegije;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn latitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn longitude;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RadioButton negativeModeRadio;
        private System.Windows.Forms.RadioButton normalModeRadio;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pretražiLokacijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iZLAZToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretražiLokacijeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem spremljeneLokacijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spremljeniPoligoniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administracijaTipovaToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem opcijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretražiLokacijeToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem spremljeneLokacijeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem spremljeniPoligoniToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem administracijaTipovaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem izlazToolStripMenuItem1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem uputeZaKorištenjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oProgramuToolStripMenuItem;
        private System.Windows.Forms.ProgressBar apiProgressBar;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lng;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeId;
        private System.Windows.Forms.Label label28;
    }
}

