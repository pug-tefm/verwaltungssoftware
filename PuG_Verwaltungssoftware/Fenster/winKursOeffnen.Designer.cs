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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gbZeiten = new System.Windows.Forms.GroupBox();
            this.tbWochentag = new System.Windows.Forms.TextBox();
            this.tbUhrzeit = new System.Windows.Forms.TextBox();
            this.tbBis = new System.Windows.Forms.TextBox();
            this.tbVon = new System.Windows.Forms.TextBox();
            this.lbWochentag = new System.Windows.Forms.Label();
            this.lbUhrzeit = new System.Windows.Forms.Label();
            this.lbBis = new System.Windows.Forms.Label();
            this.lbVon = new System.Windows.Forms.Label();
            this.gbDaten = new System.Windows.Forms.GroupBox();
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
            this.btSchliessen = new System.Windows.Forms.Button();
            this.btSpeichern = new System.Windows.Forms.Button();
            this.btBearbeiten = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbZeiten.SuspendLayout();
            this.gbDaten.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gbZeiten);
            this.splitContainer1.Panel1.Controls.Add(this.gbDaten);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btSchliessen);
            this.splitContainer1.Panel2.Controls.Add(this.btSpeichern);
            this.splitContainer1.Panel2.Controls.Add(this.btBearbeiten);
            this.splitContainer1.Size = new System.Drawing.Size(564, 442);
            this.splitContainer1.SplitterDistance = 393;
            this.splitContainer1.TabIndex = 0;
            // 
            // gbZeiten
            // 
            this.gbZeiten.Controls.Add(this.tbWochentag);
            this.gbZeiten.Controls.Add(this.tbUhrzeit);
            this.gbZeiten.Controls.Add(this.tbBis);
            this.gbZeiten.Controls.Add(this.tbVon);
            this.gbZeiten.Controls.Add(this.lbWochentag);
            this.gbZeiten.Controls.Add(this.lbUhrzeit);
            this.gbZeiten.Controls.Add(this.lbBis);
            this.gbZeiten.Controls.Add(this.lbVon);
            this.gbZeiten.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbZeiten.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbZeiten.Location = new System.Drawing.Point(0, 208);
            this.gbZeiten.Name = "gbZeiten";
            this.gbZeiten.Size = new System.Drawing.Size(564, 201);
            this.gbZeiten.TabIndex = 9;
            this.gbZeiten.TabStop = false;
            this.gbZeiten.Text = "Zeitliche Angaben";
            // 
            // tbWochentag
            // 
            this.tbWochentag.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbWochentag.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbWochentag.Location = new System.Drawing.Point(129, 81);
            this.tbWochentag.Name = "tbWochentag";
            this.tbWochentag.ReadOnly = true;
            this.tbWochentag.Size = new System.Drawing.Size(214, 26);
            this.tbWochentag.TabIndex = 8;
            // 
            // tbUhrzeit
            // 
            this.tbUhrzeit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUhrzeit.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUhrzeit.Location = new System.Drawing.Point(129, 109);
            this.tbUhrzeit.Name = "tbUhrzeit";
            this.tbUhrzeit.ReadOnly = true;
            this.tbUhrzeit.Size = new System.Drawing.Size(214, 26);
            this.tbUhrzeit.TabIndex = 9;
            // 
            // tbBis
            // 
            this.tbBis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBis.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBis.Location = new System.Drawing.Point(129, 54);
            this.tbBis.Name = "tbBis";
            this.tbBis.ReadOnly = true;
            this.tbBis.Size = new System.Drawing.Size(214, 26);
            this.tbBis.TabIndex = 7;
            // 
            // tbVon
            // 
            this.tbVon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbVon.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVon.Location = new System.Drawing.Point(129, 22);
            this.tbVon.Name = "tbVon";
            this.tbVon.ReadOnly = true;
            this.tbVon.Size = new System.Drawing.Size(214, 26);
            this.tbVon.TabIndex = 6;
            // 
            // lbWochentag
            // 
            this.lbWochentag.AutoSize = true;
            this.lbWochentag.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWochentag.Location = new System.Drawing.Point(12, 89);
            this.lbWochentag.Name = "lbWochentag";
            this.lbWochentag.Size = new System.Drawing.Size(81, 18);
            this.lbWochentag.TabIndex = 0;
            this.lbWochentag.Text = "Wochentag:";
            // 
            // lbUhrzeit
            // 
            this.lbUhrzeit.AutoSize = true;
            this.lbUhrzeit.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUhrzeit.Location = new System.Drawing.Point(12, 117);
            this.lbUhrzeit.Name = "lbUhrzeit";
            this.lbUhrzeit.Size = new System.Drawing.Size(57, 18);
            this.lbUhrzeit.TabIndex = 0;
            this.lbUhrzeit.Text = "Uhrzeit:";
            // 
            // lbBis
            // 
            this.lbBis.AutoSize = true;
            this.lbBis.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBis.Location = new System.Drawing.Point(12, 61);
            this.lbBis.Name = "lbBis";
            this.lbBis.Size = new System.Drawing.Size(30, 18);
            this.lbBis.TabIndex = 0;
            this.lbBis.Text = "Bis:";
            // 
            // lbVon
            // 
            this.lbVon.AutoSize = true;
            this.lbVon.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVon.Location = new System.Drawing.Point(12, 30);
            this.lbVon.Name = "lbVon";
            this.lbVon.Size = new System.Drawing.Size(36, 18);
            this.lbVon.TabIndex = 0;
            this.lbVon.Text = "Von:";
            // 
            // gbDaten
            // 
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
            this.gbDaten.Size = new System.Drawing.Size(564, 208);
            this.gbDaten.TabIndex = 8;
            this.gbDaten.TabStop = false;
            this.gbDaten.Text = "Allgemeine Daten";
            // 
            // tbMaxTeilnehmer
            // 
            this.tbMaxTeilnehmer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMaxTeilnehmer.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaxTeilnehmer.Location = new System.Drawing.Point(129, 152);
            this.tbMaxTeilnehmer.Name = "tbMaxTeilnehmer";
            this.tbMaxTeilnehmer.ReadOnly = true;
            this.tbMaxTeilnehmer.Size = new System.Drawing.Size(214, 26);
            this.tbMaxTeilnehmer.TabIndex = 5;
            // 
            // lbMaxTeilnehmer
            // 
            this.lbMaxTeilnehmer.AutoSize = true;
            this.lbMaxTeilnehmer.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaxTeilnehmer.Location = new System.Drawing.Point(12, 156);
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
            this.tbAktTeilnehmer.Location = new System.Drawing.Point(129, 120);
            this.tbAktTeilnehmer.Name = "tbAktTeilnehmer";
            this.tbAktTeilnehmer.ReadOnly = true;
            this.tbAktTeilnehmer.Size = new System.Drawing.Size(214, 26);
            this.tbAktTeilnehmer.TabIndex = 4;
            // 
            // lbAktTeilnehmer
            // 
            this.lbAktTeilnehmer.AutoSize = true;
            this.lbAktTeilnehmer.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAktTeilnehmer.Location = new System.Drawing.Point(12, 124);
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
            this.tbPreis.Location = new System.Drawing.Point(129, 88);
            this.tbPreis.Name = "tbPreis";
            this.tbPreis.ReadOnly = true;
            this.tbPreis.Size = new System.Drawing.Size(214, 26);
            this.tbPreis.TabIndex = 3;
            // 
            // lbBezeichnung
            // 
            this.lbBezeichnung.AutoSize = true;
            this.lbBezeichnung.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBezeichnung.Location = new System.Drawing.Point(12, 26);
            this.lbBezeichnung.Name = "lbBezeichnung";
            this.lbBezeichnung.Size = new System.Drawing.Size(91, 18);
            this.lbBezeichnung.TabIndex = 0;
            this.lbBezeichnung.Text = "Bezeichnung:";
            // 
            // lbKursleiter
            // 
            this.lbKursleiter.AutoSize = true;
            this.lbKursleiter.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKursleiter.Location = new System.Drawing.Point(12, 58);
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
            this.tbBezeichnung.Location = new System.Drawing.Point(129, 18);
            this.tbBezeichnung.Name = "tbBezeichnung";
            this.tbBezeichnung.ReadOnly = true;
            this.tbBezeichnung.Size = new System.Drawing.Size(214, 26);
            this.tbBezeichnung.TabIndex = 1;
            // 
            // lbPreis
            // 
            this.lbPreis.AutoSize = true;
            this.lbPreis.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPreis.Location = new System.Drawing.Point(12, 92);
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
            this.tbKursleiter.Location = new System.Drawing.Point(129, 50);
            this.tbKursleiter.Name = "tbKursleiter";
            this.tbKursleiter.ReadOnly = true;
            this.tbKursleiter.Size = new System.Drawing.Size(214, 26);
            this.tbKursleiter.TabIndex = 2;
            // 
            // btSchliessen
            // 
            this.btSchliessen.Dock = System.Windows.Forms.DockStyle.Right;
            this.btSchliessen.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSchliessen.Location = new System.Drawing.Point(459, 0);
            this.btSchliessen.Name = "btSchliessen";
            this.btSchliessen.Size = new System.Drawing.Size(105, 45);
            this.btSchliessen.TabIndex = 12;
            this.btSchliessen.Text = "Schließen";
            this.btSchliessen.UseVisualStyleBackColor = true;
            this.btSchliessen.Click += new System.EventHandler(this.btSchliessen_Click);
            // 
            // btSpeichern
            // 
            this.btSpeichern.Dock = System.Windows.Forms.DockStyle.Left;
            this.btSpeichern.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSpeichern.Location = new System.Drawing.Point(105, 0);
            this.btSpeichern.Name = "btSpeichern";
            this.btSpeichern.Size = new System.Drawing.Size(105, 45);
            this.btSpeichern.TabIndex = 11;
            this.btSpeichern.Text = "Speichern";
            this.btSpeichern.UseVisualStyleBackColor = true;
            this.btSpeichern.Click += new System.EventHandler(this.btSpeichern_Click);
            // 
            // btBearbeiten
            // 
            this.btBearbeiten.Dock = System.Windows.Forms.DockStyle.Left;
            this.btBearbeiten.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBearbeiten.Location = new System.Drawing.Point(0, 0);
            this.btBearbeiten.Name = "btBearbeiten";
            this.btBearbeiten.Size = new System.Drawing.Size(105, 45);
            this.btBearbeiten.TabIndex = 10;
            this.btBearbeiten.Text = "Bearbeiten";
            this.btBearbeiten.UseVisualStyleBackColor = true;
            this.btBearbeiten.Click += new System.EventHandler(this.btBearbeiten_Click);
            // 
            // winKursOeffnen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 442);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(580, 480);
            this.Name = "winKursOeffnen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kurs anzeigen und bearbeiten";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gbZeiten.ResumeLayout(false);
            this.gbZeiten.PerformLayout();
            this.gbDaten.ResumeLayout(false);
            this.gbDaten.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
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
        private System.Windows.Forms.Label lbUhrzeit;
        private System.Windows.Forms.Label lbBis;
        private System.Windows.Forms.Label lbVon;
        private System.Windows.Forms.TextBox tbWochentag;
        private System.Windows.Forms.TextBox tbUhrzeit;
        private System.Windows.Forms.TextBox tbBis;
        private System.Windows.Forms.TextBox tbVon;
        private System.Windows.Forms.TextBox tbPreis;
        private System.Windows.Forms.TextBox tbMaxTeilnehmer;
        private System.Windows.Forms.Label lbMaxTeilnehmer;
        private System.Windows.Forms.TextBox tbAktTeilnehmer;
        private System.Windows.Forms.Label lbAktTeilnehmer;
    }
}