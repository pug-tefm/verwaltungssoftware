namespace PuG_Verwaltungssoftware
{
    partial class winKursNeu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(winKursNeu));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gbZeiten = new System.Windows.Forms.GroupBox();
            this.dtpBis = new System.Windows.Forms.DateTimePicker();
            this.dtpVon = new System.Windows.Forms.DateTimePicker();
            this.tbWochentag = new System.Windows.Forms.TextBox();
            this.tbUhrzeit = new System.Windows.Forms.TextBox();
            this.lbWochentag = new System.Windows.Forms.Label();
            this.lbUhrzeit = new System.Windows.Forms.Label();
            this.lbBis = new System.Windows.Forms.Label();
            this.lbVon = new System.Windows.Forms.Label();
            this.gbDaten = new System.Windows.Forms.GroupBox();
            this.cbKursleiter = new System.Windows.Forms.ComboBox();
            this.tbMaxTeilnehmer = new System.Windows.Forms.TextBox();
            this.lbMaxTeilnehmer = new System.Windows.Forms.Label();
            this.tbPreis = new System.Windows.Forms.TextBox();
            this.lbBezeichnung = new System.Windows.Forms.Label();
            this.lbKursleiter = new System.Windows.Forms.Label();
            this.tbBezeichnung = new System.Windows.Forms.TextBox();
            this.lbPreis = new System.Windows.Forms.Label();
            this.btSchliessen = new System.Windows.Forms.Button();
            this.btSpeichern = new System.Windows.Forms.Button();
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
            this.splitContainer1.Size = new System.Drawing.Size(394, 382);
            this.splitContainer1.SplitterDistance = 339;
            this.splitContainer1.TabIndex = 0;
            // 
            // gbZeiten
            // 
            this.gbZeiten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbZeiten.Controls.Add(this.dtpBis);
            this.gbZeiten.Controls.Add(this.dtpVon);
            this.gbZeiten.Controls.Add(this.tbWochentag);
            this.gbZeiten.Controls.Add(this.tbUhrzeit);
            this.gbZeiten.Controls.Add(this.lbWochentag);
            this.gbZeiten.Controls.Add(this.lbUhrzeit);
            this.gbZeiten.Controls.Add(this.lbBis);
            this.gbZeiten.Controls.Add(this.lbVon);
            this.gbZeiten.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbZeiten.Location = new System.Drawing.Point(0, 176);
            this.gbZeiten.Name = "gbZeiten";
            this.gbZeiten.Size = new System.Drawing.Size(394, 161);
            this.gbZeiten.TabIndex = 9;
            this.gbZeiten.TabStop = false;
            this.gbZeiten.Text = "Zeitliche Angaben";
            // 
            // dtpBis
            // 
            this.dtpBis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpBis.Location = new System.Drawing.Point(129, 57);
            this.dtpBis.Name = "dtpBis";
            this.dtpBis.Size = new System.Drawing.Size(253, 23);
            this.dtpBis.TabIndex = 11;
            // 
            // dtpVon
            // 
            this.dtpVon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpVon.Location = new System.Drawing.Point(129, 26);
            this.dtpVon.Name = "dtpVon";
            this.dtpVon.Size = new System.Drawing.Size(253, 23);
            this.dtpVon.TabIndex = 10;
            // 
            // tbWochentag
            // 
            this.tbWochentag.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbWochentag.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbWochentag.Location = new System.Drawing.Point(129, 86);
            this.tbWochentag.Name = "tbWochentag";
            this.tbWochentag.Size = new System.Drawing.Size(253, 26);
            this.tbWochentag.TabIndex = 8;
            // 
            // tbUhrzeit
            // 
            this.tbUhrzeit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUhrzeit.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUhrzeit.Location = new System.Drawing.Point(129, 118);
            this.tbUhrzeit.Name = "tbUhrzeit";
            this.tbUhrzeit.Size = new System.Drawing.Size(253, 26);
            this.tbUhrzeit.TabIndex = 9;
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
            this.gbDaten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDaten.Controls.Add(this.cbKursleiter);
            this.gbDaten.Controls.Add(this.tbMaxTeilnehmer);
            this.gbDaten.Controls.Add(this.lbMaxTeilnehmer);
            this.gbDaten.Controls.Add(this.tbPreis);
            this.gbDaten.Controls.Add(this.lbBezeichnung);
            this.gbDaten.Controls.Add(this.lbKursleiter);
            this.gbDaten.Controls.Add(this.tbBezeichnung);
            this.gbDaten.Controls.Add(this.lbPreis);
            this.gbDaten.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDaten.Location = new System.Drawing.Point(0, 0);
            this.gbDaten.Name = "gbDaten";
            this.gbDaten.Size = new System.Drawing.Size(394, 220);
            this.gbDaten.TabIndex = 8;
            this.gbDaten.TabStop = false;
            this.gbDaten.Text = "Allgemeine Daten";
            // 
            // cbKursleiter
            // 
            this.cbKursleiter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbKursleiter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKursleiter.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.cbKursleiter.FormattingEnabled = true;
            this.cbKursleiter.Location = new System.Drawing.Point(129, 53);
            this.cbKursleiter.Name = "cbKursleiter";
            this.cbKursleiter.Size = new System.Drawing.Size(253, 26);
            this.cbKursleiter.TabIndex = 2;
            // 
            // tbMaxTeilnehmer
            // 
            this.tbMaxTeilnehmer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMaxTeilnehmer.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaxTeilnehmer.Location = new System.Drawing.Point(129, 131);
            this.tbMaxTeilnehmer.Name = "tbMaxTeilnehmer";
            this.tbMaxTeilnehmer.Size = new System.Drawing.Size(253, 26);
            this.tbMaxTeilnehmer.TabIndex = 5;
            // 
            // lbMaxTeilnehmer
            // 
            this.lbMaxTeilnehmer.AutoSize = true;
            this.lbMaxTeilnehmer.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaxTeilnehmer.Location = new System.Drawing.Point(12, 131);
            this.lbMaxTeilnehmer.Name = "lbMaxTeilnehmer";
            this.lbMaxTeilnehmer.Size = new System.Drawing.Size(116, 18);
            this.lbMaxTeilnehmer.TabIndex = 0;
            this.lbMaxTeilnehmer.Text = "Max. Teilnehmer:";
            // 
            // tbPreis
            // 
            this.tbPreis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPreis.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPreis.Location = new System.Drawing.Point(129, 88);
            this.tbPreis.Name = "tbPreis";
            this.tbPreis.Size = new System.Drawing.Size(253, 26);
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
            this.tbBezeichnung.Size = new System.Drawing.Size(253, 26);
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
            // btSchliessen
            // 
            this.btSchliessen.Dock = System.Windows.Forms.DockStyle.Right;
            this.btSchliessen.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSchliessen.Location = new System.Drawing.Point(289, 0);
            this.btSchliessen.Name = "btSchliessen";
            this.btSchliessen.Size = new System.Drawing.Size(105, 39);
            this.btSchliessen.TabIndex = 11;
            this.btSchliessen.Text = "Schließen";
            this.btSchliessen.UseVisualStyleBackColor = true;
            this.btSchliessen.Click += new System.EventHandler(this.btSchliessen_Click);
            // 
            // btSpeichern
            // 
            this.btSpeichern.Dock = System.Windows.Forms.DockStyle.Left;
            this.btSpeichern.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSpeichern.Location = new System.Drawing.Point(0, 0);
            this.btSpeichern.Name = "btSpeichern";
            this.btSpeichern.Size = new System.Drawing.Size(105, 39);
            this.btSpeichern.TabIndex = 10;
            this.btSpeichern.Text = "Speichern";
            this.btSpeichern.UseVisualStyleBackColor = true;
            this.btSpeichern.Click += new System.EventHandler(this.btSpeichern_Click);
            // 
            // winKursNeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 382);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(410, 420);
            this.Name = "winKursNeu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Neuen Kurs anlegen";
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
        private System.Windows.Forms.Label lbPreis;
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
        private System.Windows.Forms.TextBox tbPreis;
        private System.Windows.Forms.TextBox tbMaxTeilnehmer;
        private System.Windows.Forms.Label lbMaxTeilnehmer;
        private System.Windows.Forms.ComboBox cbKursleiter;
        private System.Windows.Forms.DateTimePicker dtpBis;
        private System.Windows.Forms.DateTimePicker dtpVon;
    }
}