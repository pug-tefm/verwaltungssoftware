namespace PuG_Verwaltungssoftware
{
    partial class winKursOeffnen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(winKursOeffnen));
            this.gbDaten = new System.Windows.Forms.GroupBox();
            this.cbKursleiter = new System.Windows.Forms.ComboBox();
            this.tbMaxTeilnehmer = new System.Windows.Forms.TextBox();
            this.lbMaxTeilnehmer = new System.Windows.Forms.Label();
            this.tbAktTeilnehmer = new System.Windows.Forms.TextBox();
            this.lbAktTeilnehmer = new System.Windows.Forms.Label();
            this.tbPreis = new System.Windows.Forms.TextBox();
            this.lbBezeichnung = new System.Windows.Forms.Label();
            this.lbKursleiter = new System.Windows.Forms.Label();
            this.tbBezeichnung = new System.Windows.Forms.TextBox();
            this.lbPreis = new System.Windows.Forms.Label();
            this.tbKursleiter = new System.Windows.Forms.TextBox();
            this.gbZeiten = new System.Windows.Forms.GroupBox();
            this.dtpUhrzeitBis = new System.Windows.Forms.DateTimePicker();
            this.tbUhrzeitBis = new System.Windows.Forms.TextBox();
            this.lbUhrzeitBis = new System.Windows.Forms.Label();
            this.dtpUhrzeitVon = new System.Windows.Forms.DateTimePicker();
            this.cbWochentag = new System.Windows.Forms.ComboBox();
            this.dtpDatumVon = new System.Windows.Forms.DateTimePicker();
            this.dtpDatumBis = new System.Windows.Forms.DateTimePicker();
            this.tbDatumVon = new System.Windows.Forms.TextBox();
            this.tbWochentag = new System.Windows.Forms.TextBox();
            this.tbUhrzeitVon = new System.Windows.Forms.TextBox();
            this.tbDatumBis = new System.Windows.Forms.TextBox();
            this.lbWochentag = new System.Windows.Forms.Label();
            this.lbUhrzeitVon = new System.Windows.Forms.Label();
            this.lbDatumBis = new System.Windows.Forms.Label();
            this.lbDatumVon = new System.Windows.Forms.Label();
            this.btSchliessen = new System.Windows.Forms.Button();
            this.btSpeichern = new System.Windows.Forms.Button();
            this.btBearbeiten = new System.Windows.Forms.Button();
            this.gbButtons = new System.Windows.Forms.GroupBox();
            this.gbDaten.SuspendLayout();
            this.gbZeiten.SuspendLayout();
            this.gbButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDaten
            // 
            this.gbDaten.Controls.Add(this.cbKursleiter);
            this.gbDaten.Controls.Add(this.tbMaxTeilnehmer);
            this.gbDaten.Controls.Add(this.lbMaxTeilnehmer);
            this.gbDaten.Controls.Add(this.tbAktTeilnehmer);
            this.gbDaten.Controls.Add(this.lbAktTeilnehmer);
            this.gbDaten.Controls.Add(this.tbPreis);
            this.gbDaten.Controls.Add(this.lbBezeichnung);
            this.gbDaten.Controls.Add(this.lbKursleiter);
            this.gbDaten.Controls.Add(this.tbBezeichnung);
            this.gbDaten.Controls.Add(this.lbPreis);
            this.gbDaten.Controls.Add(this.tbKursleiter);
            this.gbDaten.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbDaten.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDaten.Location = new System.Drawing.Point(0, 0);
            this.gbDaten.Name = "gbDaten";
            this.gbDaten.Size = new System.Drawing.Size(384, 190);
            this.gbDaten.TabIndex = 1;
            this.gbDaten.TabStop = false;
            this.gbDaten.Text = "Allgemeine Daten";
            // 
            // cbKursleiter
            // 
            this.cbKursleiter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbKursleiter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKursleiter.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.cbKursleiter.FormattingEnabled = true;
            this.cbKursleiter.Location = new System.Drawing.Point(129, 47);
            this.cbKursleiter.Name = "cbKursleiter";
            this.cbKursleiter.Size = new System.Drawing.Size(232, 26);
            this.cbKursleiter.TabIndex = 4;
            // 
            // tbMaxTeilnehmer
            // 
            this.tbMaxTeilnehmer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMaxTeilnehmer.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaxTeilnehmer.Location = new System.Drawing.Point(129, 148);
            this.tbMaxTeilnehmer.MaxLength = 5;
            this.tbMaxTeilnehmer.Name = "tbMaxTeilnehmer";
            this.tbMaxTeilnehmer.ReadOnly = true;
            this.tbMaxTeilnehmer.Size = new System.Drawing.Size(232, 26);
            this.tbMaxTeilnehmer.TabIndex = 7;
            // 
            // lbMaxTeilnehmer
            // 
            this.lbMaxTeilnehmer.AutoSize = true;
            this.lbMaxTeilnehmer.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaxTeilnehmer.Location = new System.Drawing.Point(12, 151);
            this.lbMaxTeilnehmer.Name = "lbMaxTeilnehmer";
            this.lbMaxTeilnehmer.Size = new System.Drawing.Size(116, 18);
            this.lbMaxTeilnehmer.TabIndex = 0;
            this.lbMaxTeilnehmer.Text = "Max. Teilnehmer:";
            // 
            // tbAktTeilnehmer
            // 
            this.tbAktTeilnehmer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAktTeilnehmer.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAktTeilnehmer.Location = new System.Drawing.Point(129, 112);
            this.tbAktTeilnehmer.MaxLength = 5;
            this.tbAktTeilnehmer.Name = "tbAktTeilnehmer";
            this.tbAktTeilnehmer.ReadOnly = true;
            this.tbAktTeilnehmer.Size = new System.Drawing.Size(232, 26);
            this.tbAktTeilnehmer.TabIndex = 6;
            // 
            // lbAktTeilnehmer
            // 
            this.lbAktTeilnehmer.AutoSize = true;
            this.lbAktTeilnehmer.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAktTeilnehmer.Location = new System.Drawing.Point(12, 115);
            this.lbAktTeilnehmer.Name = "lbAktTeilnehmer";
            this.lbAktTeilnehmer.Size = new System.Drawing.Size(111, 18);
            this.lbAktTeilnehmer.TabIndex = 0;
            this.lbAktTeilnehmer.Text = "Akt. Teilnehmer:";
            // 
            // tbPreis
            // 
            this.tbPreis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPreis.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPreis.Location = new System.Drawing.Point(129, 80);
            this.tbPreis.MaxLength = 20;
            this.tbPreis.Name = "tbPreis";
            this.tbPreis.ReadOnly = true;
            this.tbPreis.Size = new System.Drawing.Size(232, 26);
            this.tbPreis.TabIndex = 5;
            // 
            // lbBezeichnung
            // 
            this.lbBezeichnung.AutoSize = true;
            this.lbBezeichnung.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBezeichnung.Location = new System.Drawing.Point(12, 18);
            this.lbBezeichnung.Name = "lbBezeichnung";
            this.lbBezeichnung.Size = new System.Drawing.Size(91, 18);
            this.lbBezeichnung.TabIndex = 0;
            this.lbBezeichnung.Text = "Bezeichnung:";
            // 
            // lbKursleiter
            // 
            this.lbKursleiter.AutoSize = true;
            this.lbKursleiter.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKursleiter.Location = new System.Drawing.Point(12, 50);
            this.lbKursleiter.Name = "lbKursleiter";
            this.lbKursleiter.Size = new System.Drawing.Size(73, 18);
            this.lbKursleiter.TabIndex = 0;
            this.lbKursleiter.Text = "Kursleiter:";
            // 
            // tbBezeichnung
            // 
            this.tbBezeichnung.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBezeichnung.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBezeichnung.Location = new System.Drawing.Point(129, 15);
            this.tbBezeichnung.MaxLength = 100;
            this.tbBezeichnung.Name = "tbBezeichnung";
            this.tbBezeichnung.ReadOnly = true;
            this.tbBezeichnung.Size = new System.Drawing.Size(232, 26);
            this.tbBezeichnung.TabIndex = 2;
            // 
            // lbPreis
            // 
            this.lbPreis.AutoSize = true;
            this.lbPreis.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPreis.Location = new System.Drawing.Point(12, 83);
            this.lbPreis.Name = "lbPreis";
            this.lbPreis.Size = new System.Drawing.Size(43, 18);
            this.lbPreis.TabIndex = 0;
            this.lbPreis.Text = "Preis:";
            // 
            // tbKursleiter
            // 
            this.tbKursleiter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbKursleiter.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKursleiter.Location = new System.Drawing.Point(129, 47);
            this.tbKursleiter.Name = "tbKursleiter";
            this.tbKursleiter.ReadOnly = true;
            this.tbKursleiter.Size = new System.Drawing.Size(232, 26);
            this.tbKursleiter.TabIndex = 3;
            // 
            // gbZeiten
            // 
            this.gbZeiten.Controls.Add(this.dtpUhrzeitBis);
            this.gbZeiten.Controls.Add(this.tbUhrzeitBis);
            this.gbZeiten.Controls.Add(this.lbUhrzeitBis);
            this.gbZeiten.Controls.Add(this.dtpUhrzeitVon);
            this.gbZeiten.Controls.Add(this.cbWochentag);
            this.gbZeiten.Controls.Add(this.dtpDatumVon);
            this.gbZeiten.Controls.Add(this.dtpDatumBis);
            this.gbZeiten.Controls.Add(this.tbDatumVon);
            this.gbZeiten.Controls.Add(this.tbWochentag);
            this.gbZeiten.Controls.Add(this.tbUhrzeitVon);
            this.gbZeiten.Controls.Add(this.tbDatumBis);
            this.gbZeiten.Controls.Add(this.lbWochentag);
            this.gbZeiten.Controls.Add(this.lbUhrzeitVon);
            this.gbZeiten.Controls.Add(this.lbDatumBis);
            this.gbZeiten.Controls.Add(this.lbDatumVon);
            this.gbZeiten.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbZeiten.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbZeiten.Location = new System.Drawing.Point(0, 190);
            this.gbZeiten.Name = "gbZeiten";
            this.gbZeiten.Size = new System.Drawing.Size(384, 189);
            this.gbZeiten.TabIndex = 8;
            this.gbZeiten.TabStop = false;
            this.gbZeiten.Text = "Zeitliche Angaben";
            // 
            // dtpUhrzeitBis
            // 
            this.dtpUhrzeitBis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpUhrzeitBis.CustomFormat = "HH:mm";
            this.dtpUhrzeitBis.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.dtpUhrzeitBis.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpUhrzeitBis.Location = new System.Drawing.Point(129, 155);
            this.dtpUhrzeitBis.Name = "dtpUhrzeitBis";
            this.dtpUhrzeitBis.ShowUpDown = true;
            this.dtpUhrzeitBis.Size = new System.Drawing.Size(54, 26);
            this.dtpUhrzeitBis.TabIndex = 19;
            this.dtpUhrzeitBis.Visible = false;
            // 
            // tbUhrzeitBis
            // 
            this.tbUhrzeitBis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUhrzeitBis.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUhrzeitBis.Location = new System.Drawing.Point(129, 155);
            this.tbUhrzeitBis.Name = "tbUhrzeitBis";
            this.tbUhrzeitBis.ReadOnly = true;
            this.tbUhrzeitBis.Size = new System.Drawing.Size(54, 26);
            this.tbUhrzeitBis.TabIndex = 18;
            // 
            // lbUhrzeitBis
            // 
            this.lbUhrzeitBis.AutoSize = true;
            this.lbUhrzeitBis.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUhrzeitBis.Location = new System.Drawing.Point(12, 159);
            this.lbUhrzeitBis.Name = "lbUhrzeitBis";
            this.lbUhrzeitBis.Size = new System.Drawing.Size(78, 18);
            this.lbUhrzeitBis.TabIndex = 17;
            this.lbUhrzeitBis.Text = "Uhrzeit Bis:";
            // 
            // dtpUhrzeitVon
            // 
            this.dtpUhrzeitVon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpUhrzeitVon.CustomFormat = "HH:mm";
            this.dtpUhrzeitVon.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.dtpUhrzeitVon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpUhrzeitVon.Location = new System.Drawing.Point(129, 121);
            this.dtpUhrzeitVon.Name = "dtpUhrzeitVon";
            this.dtpUhrzeitVon.ShowUpDown = true;
            this.dtpUhrzeitVon.Size = new System.Drawing.Size(54, 26);
            this.dtpUhrzeitVon.TabIndex = 16;
            this.dtpUhrzeitVon.Visible = false;
            // 
            // cbWochentag
            // 
            this.cbWochentag.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbWochentag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWochentag.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.cbWochentag.FormattingEnabled = true;
            this.cbWochentag.Location = new System.Drawing.Point(129, 89);
            this.cbWochentag.Name = "cbWochentag";
            this.cbWochentag.Size = new System.Drawing.Size(232, 26);
            this.cbWochentag.TabIndex = 14;
            // 
            // dtpDatumVon
            // 
            this.dtpDatumVon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDatumVon.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.dtpDatumVon.Location = new System.Drawing.Point(129, 22);
            this.dtpDatumVon.Name = "dtpDatumVon";
            this.dtpDatumVon.Size = new System.Drawing.Size(232, 26);
            this.dtpDatumVon.TabIndex = 10;
            this.dtpDatumVon.ValueChanged += new System.EventHandler(this.dtpDatumVon_ValueChanged);
            // 
            // dtpDatumBis
            // 
            this.dtpDatumBis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDatumBis.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.dtpDatumBis.Location = new System.Drawing.Point(129, 56);
            this.dtpDatumBis.Name = "dtpDatumBis";
            this.dtpDatumBis.Size = new System.Drawing.Size(232, 26);
            this.dtpDatumBis.TabIndex = 12;
            this.dtpDatumBis.ValueChanged += new System.EventHandler(this.dtpDatumBis_ValueChanged);
            // 
            // tbDatumVon
            // 
            this.tbDatumVon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDatumVon.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDatumVon.Location = new System.Drawing.Point(129, 22);
            this.tbDatumVon.Name = "tbDatumVon";
            this.tbDatumVon.ReadOnly = true;
            this.tbDatumVon.Size = new System.Drawing.Size(216, 26);
            this.tbDatumVon.TabIndex = 9;
            // 
            // tbWochentag
            // 
            this.tbWochentag.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbWochentag.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbWochentag.Location = new System.Drawing.Point(129, 89);
            this.tbWochentag.Name = "tbWochentag";
            this.tbWochentag.ReadOnly = true;
            this.tbWochentag.Size = new System.Drawing.Size(216, 26);
            this.tbWochentag.TabIndex = 13;
            // 
            // tbUhrzeitVon
            // 
            this.tbUhrzeitVon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUhrzeitVon.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUhrzeitVon.Location = new System.Drawing.Point(129, 121);
            this.tbUhrzeitVon.Name = "tbUhrzeitVon";
            this.tbUhrzeitVon.ReadOnly = true;
            this.tbUhrzeitVon.Size = new System.Drawing.Size(54, 26);
            this.tbUhrzeitVon.TabIndex = 15;
            // 
            // tbDatumBis
            // 
            this.tbDatumBis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDatumBis.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDatumBis.Location = new System.Drawing.Point(129, 56);
            this.tbDatumBis.Name = "tbDatumBis";
            this.tbDatumBis.ReadOnly = true;
            this.tbDatumBis.Size = new System.Drawing.Size(216, 26);
            this.tbDatumBis.TabIndex = 11;
            // 
            // lbWochentag
            // 
            this.lbWochentag.AutoSize = true;
            this.lbWochentag.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWochentag.Location = new System.Drawing.Point(12, 92);
            this.lbWochentag.Name = "lbWochentag";
            this.lbWochentag.Size = new System.Drawing.Size(81, 18);
            this.lbWochentag.TabIndex = 0;
            this.lbWochentag.Text = "Wochentag:";
            // 
            // lbUhrzeitVon
            // 
            this.lbUhrzeitVon.AutoSize = true;
            this.lbUhrzeitVon.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUhrzeitVon.Location = new System.Drawing.Point(12, 124);
            this.lbUhrzeitVon.Name = "lbUhrzeitVon";
            this.lbUhrzeitVon.Size = new System.Drawing.Size(84, 18);
            this.lbUhrzeitVon.TabIndex = 0;
            this.lbUhrzeitVon.Text = "Uhrzeit Von:";
            // 
            // lbDatumBis
            // 
            this.lbDatumBis.AutoSize = true;
            this.lbDatumBis.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDatumBis.Location = new System.Drawing.Point(12, 59);
            this.lbDatumBis.Name = "lbDatumBis";
            this.lbDatumBis.Size = new System.Drawing.Size(74, 18);
            this.lbDatumBis.TabIndex = 0;
            this.lbDatumBis.Text = "Datum Bis:";
            // 
            // lbDatumVon
            // 
            this.lbDatumVon.AutoSize = true;
            this.lbDatumVon.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDatumVon.Location = new System.Drawing.Point(12, 28);
            this.lbDatumVon.Name = "lbDatumVon";
            this.lbDatumVon.Size = new System.Drawing.Size(80, 18);
            this.lbDatumVon.TabIndex = 0;
            this.lbDatumVon.Text = "Datum Von:";
            // 
            // btSchliessen
            // 
            this.btSchliessen.BackgroundImage = global::PuG_Verwaltungssoftware.Properties.Resources.pug_close_groß;
            this.btSchliessen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btSchliessen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSchliessen.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSchliessen.Location = new System.Drawing.Point(6, 10);
            this.btSchliessen.Name = "btSchliessen";
            this.btSchliessen.Size = new System.Drawing.Size(55, 55);
            this.btSchliessen.TabIndex = 19;
            this.btSchliessen.UseVisualStyleBackColor = true;
            this.btSchliessen.Click += new System.EventHandler(this.btSchliessen_Click);
            // 
            // btSpeichern
            // 
            this.btSpeichern.BackgroundImage = global::PuG_Verwaltungssoftware.Properties.Resources.pug_save_groß;
            this.btSpeichern.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btSpeichern.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSpeichern.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSpeichern.Location = new System.Drawing.Point(323, 10);
            this.btSpeichern.Name = "btSpeichern";
            this.btSpeichern.Size = new System.Drawing.Size(55, 55);
            this.btSpeichern.TabIndex = 18;
            this.btSpeichern.UseVisualStyleBackColor = true;
            this.btSpeichern.Click += new System.EventHandler(this.btSpeichern_Click);
            // 
            // btBearbeiten
            // 
            this.btBearbeiten.BackgroundImage = global::PuG_Verwaltungssoftware.Properties.Resources.pug_edit_groß;
            this.btBearbeiten.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btBearbeiten.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btBearbeiten.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBearbeiten.Location = new System.Drawing.Point(262, 10);
            this.btBearbeiten.Name = "btBearbeiten";
            this.btBearbeiten.Size = new System.Drawing.Size(55, 55);
            this.btBearbeiten.TabIndex = 17;
            this.btBearbeiten.UseVisualStyleBackColor = true;
            this.btBearbeiten.Click += new System.EventHandler(this.btBearbeiten_Click);
            // 
            // gbButtons
            // 
            this.gbButtons.Controls.Add(this.btBearbeiten);
            this.gbButtons.Controls.Add(this.btSpeichern);
            this.gbButtons.Controls.Add(this.btSchliessen);
            this.gbButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbButtons.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbButtons.Location = new System.Drawing.Point(0, 385);
            this.gbButtons.Name = "gbButtons";
            this.gbButtons.Size = new System.Drawing.Size(384, 71);
            this.gbButtons.TabIndex = 9;
            this.gbButtons.TabStop = false;
            // 
            // winKursOeffnen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 456);
            this.Controls.Add(this.gbButtons);
            this.Controls.Add(this.gbZeiten);
            this.Controls.Add(this.gbDaten);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 490);
            this.MinimumSize = new System.Drawing.Size(400, 490);
            this.Name = "winKursOeffnen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kurs anzeigen und bearbeiten";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.winKursOeffnen_FormClosing);
            this.gbDaten.ResumeLayout(false);
            this.gbDaten.PerformLayout();
            this.gbZeiten.ResumeLayout(false);
            this.gbZeiten.PerformLayout();
            this.gbButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btSchliessen;
        private System.Windows.Forms.Button btSpeichern;
        private System.Windows.Forms.Button btBearbeiten;
        private System.Windows.Forms.Label lbPreis;
        private System.Windows.Forms.TextBox tbKursleiter;
        private System.Windows.Forms.Label lbKursleiter;
        private System.Windows.Forms.TextBox tbBezeichnung;
        private System.Windows.Forms.GroupBox gbDaten;
        private System.Windows.Forms.Label lbBezeichnung;
        private System.Windows.Forms.GroupBox gbZeiten;
        private System.Windows.Forms.Label lbWochentag;
        private System.Windows.Forms.Label lbUhrzeitVon;
        private System.Windows.Forms.Label lbDatumBis;
        private System.Windows.Forms.Label lbDatumVon;
        private System.Windows.Forms.TextBox tbWochentag;
        private System.Windows.Forms.TextBox tbUhrzeitVon;
        private System.Windows.Forms.TextBox tbDatumBis;
        private System.Windows.Forms.TextBox tbDatumVon;
        private System.Windows.Forms.TextBox tbPreis;
        private System.Windows.Forms.TextBox tbMaxTeilnehmer;
        private System.Windows.Forms.Label lbMaxTeilnehmer;
        private System.Windows.Forms.TextBox tbAktTeilnehmer;
        private System.Windows.Forms.Label lbAktTeilnehmer;
        private System.Windows.Forms.DateTimePicker dtpDatumBis;
        private System.Windows.Forms.DateTimePicker dtpDatumVon;
        private System.Windows.Forms.ComboBox cbKursleiter;
        private System.Windows.Forms.ComboBox cbWochentag;
        private System.Windows.Forms.DateTimePicker dtpUhrzeitVon;
        private System.Windows.Forms.DateTimePicker dtpUhrzeitBis;
        private System.Windows.Forms.TextBox tbUhrzeitBis;
        private System.Windows.Forms.Label lbUhrzeitBis;
        private System.Windows.Forms.GroupBox gbButtons;
    }
}