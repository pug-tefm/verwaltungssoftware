﻿namespace PuG_Verwaltungssoftware
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
            this.gbDaten = new System.Windows.Forms.GroupBox();
            this.cbKursleiter = new System.Windows.Forms.ComboBox();
            this.tbMaxTeilnehmer = new System.Windows.Forms.TextBox();
            this.lbMaxTeilnehmer = new System.Windows.Forms.Label();
            this.tbPreis = new System.Windows.Forms.TextBox();
            this.lbBezeichnung = new System.Windows.Forms.Label();
            this.lbKursleiter = new System.Windows.Forms.Label();
            this.tbBezeichnung = new System.Windows.Forms.TextBox();
            this.lbPreis = new System.Windows.Forms.Label();
            this.gbZeiten = new System.Windows.Forms.GroupBox();
            this.dtpUhrzeitBis = new System.Windows.Forms.DateTimePicker();
            this.lbUhrzeitBis = new System.Windows.Forms.Label();
            this.dtpUhrzeitVon = new System.Windows.Forms.DateTimePicker();
            this.cbWochentag = new System.Windows.Forms.ComboBox();
            this.lbUhrzeitVon = new System.Windows.Forms.Label();
            this.lbWochentag = new System.Windows.Forms.Label();
            this.lbDatumVon = new System.Windows.Forms.Label();
            this.lbDatumBis = new System.Windows.Forms.Label();
            this.dtpDatumBis = new System.Windows.Forms.DateTimePicker();
            this.dtpDatumVon = new System.Windows.Forms.DateTimePicker();
            this.btSchliessen = new System.Windows.Forms.Button();
            this.btSpeichern = new System.Windows.Forms.Button();
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
            this.gbDaten.Controls.Add(this.tbPreis);
            this.gbDaten.Controls.Add(this.lbBezeichnung);
            this.gbDaten.Controls.Add(this.lbKursleiter);
            this.gbDaten.Controls.Add(this.tbBezeichnung);
            this.gbDaten.Controls.Add(this.lbPreis);
            this.gbDaten.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbDaten.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDaten.Location = new System.Drawing.Point(0, 0);
            this.gbDaten.Name = "gbDaten";
            this.gbDaten.Size = new System.Drawing.Size(384, 151);
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
            this.cbKursleiter.Location = new System.Drawing.Point(129, 47);
            this.cbKursleiter.Name = "cbKursleiter";
            this.cbKursleiter.Size = new System.Drawing.Size(232, 26);
            this.cbKursleiter.TabIndex = 2;
            // 
            // tbMaxTeilnehmer
            // 
            this.tbMaxTeilnehmer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMaxTeilnehmer.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaxTeilnehmer.Location = new System.Drawing.Point(129, 112);
            this.tbMaxTeilnehmer.MaxLength = 5;
            this.tbMaxTeilnehmer.Name = "tbMaxTeilnehmer";
            this.tbMaxTeilnehmer.Size = new System.Drawing.Size(232, 26);
            this.tbMaxTeilnehmer.TabIndex = 4;
            // 
            // lbMaxTeilnehmer
            // 
            this.lbMaxTeilnehmer.AutoSize = true;
            this.lbMaxTeilnehmer.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaxTeilnehmer.Location = new System.Drawing.Point(12, 115);
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
            this.tbPreis.Location = new System.Drawing.Point(129, 80);
            this.tbPreis.MaxLength = 20;
            this.tbPreis.Name = "tbPreis";
            this.tbPreis.Size = new System.Drawing.Size(232, 26);
            this.tbPreis.TabIndex = 3;
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
            this.tbBezeichnung.Size = new System.Drawing.Size(232, 26);
            this.tbBezeichnung.TabIndex = 1;
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
            // gbZeiten
            // 
            this.gbZeiten.Controls.Add(this.dtpUhrzeitBis);
            this.gbZeiten.Controls.Add(this.lbUhrzeitBis);
            this.gbZeiten.Controls.Add(this.dtpUhrzeitVon);
            this.gbZeiten.Controls.Add(this.cbWochentag);
            this.gbZeiten.Controls.Add(this.lbUhrzeitVon);
            this.gbZeiten.Controls.Add(this.lbWochentag);
            this.gbZeiten.Controls.Add(this.lbDatumVon);
            this.gbZeiten.Controls.Add(this.lbDatumBis);
            this.gbZeiten.Controls.Add(this.dtpDatumBis);
            this.gbZeiten.Controls.Add(this.dtpDatumVon);
            this.gbZeiten.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbZeiten.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbZeiten.Location = new System.Drawing.Point(0, 151);
            this.gbZeiten.Name = "gbZeiten";
            this.gbZeiten.Size = new System.Drawing.Size(384, 185);
            this.gbZeiten.TabIndex = 9;
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
            this.dtpUhrzeitBis.Location = new System.Drawing.Point(130, 150);
            this.dtpUhrzeitBis.Name = "dtpUhrzeitBis";
            this.dtpUhrzeitBis.ShowUpDown = true;
            this.dtpUhrzeitBis.Size = new System.Drawing.Size(75, 26);
            this.dtpUhrzeitBis.TabIndex = 22;
            // 
            // lbUhrzeitBis
            // 
            this.lbUhrzeitBis.AutoSize = true;
            this.lbUhrzeitBis.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUhrzeitBis.Location = new System.Drawing.Point(14, 156);
            this.lbUhrzeitBis.Name = "lbUhrzeitBis";
            this.lbUhrzeitBis.Size = new System.Drawing.Size(78, 18);
            this.lbUhrzeitBis.TabIndex = 20;
            this.lbUhrzeitBis.Text = "Uhrzeit Bis:";
            // 
            // dtpUhrzeitVon
            // 
            this.dtpUhrzeitVon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpUhrzeitVon.CalendarFont = new System.Drawing.Font("Calibri", 11.25F);
            this.dtpUhrzeitVon.CustomFormat = "HH:mm";
            this.dtpUhrzeitVon.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.dtpUhrzeitVon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpUhrzeitVon.Location = new System.Drawing.Point(130, 118);
            this.dtpUhrzeitVon.Name = "dtpUhrzeitVon";
            this.dtpUhrzeitVon.ShowUpDown = true;
            this.dtpUhrzeitVon.Size = new System.Drawing.Size(75, 26);
            this.dtpUhrzeitVon.TabIndex = 10;
            // 
            // cbWochentag
            // 
            this.cbWochentag.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbWochentag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWochentag.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.cbWochentag.FormattingEnabled = true;
            this.cbWochentag.Location = new System.Drawing.Point(128, 86);
            this.cbWochentag.Name = "cbWochentag";
            this.cbWochentag.Size = new System.Drawing.Size(242, 26);
            this.cbWochentag.TabIndex = 9;
            // 
            // lbUhrzeitVon
            // 
            this.lbUhrzeitVon.AutoSize = true;
            this.lbUhrzeitVon.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.lbUhrzeitVon.Location = new System.Drawing.Point(14, 124);
            this.lbUhrzeitVon.Name = "lbUhrzeitVon";
            this.lbUhrzeitVon.Size = new System.Drawing.Size(84, 18);
            this.lbUhrzeitVon.TabIndex = 8;
            this.lbUhrzeitVon.Text = "Uhrzeit Von:";
            // 
            // lbWochentag
            // 
            this.lbWochentag.AutoSize = true;
            this.lbWochentag.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.lbWochentag.Location = new System.Drawing.Point(14, 89);
            this.lbWochentag.Name = "lbWochentag";
            this.lbWochentag.Size = new System.Drawing.Size(77, 18);
            this.lbWochentag.TabIndex = 7;
            this.lbWochentag.Text = "Wochentag";
            // 
            // lbDatumVon
            // 
            this.lbDatumVon.AutoSize = true;
            this.lbDatumVon.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDatumVon.Location = new System.Drawing.Point(14, 28);
            this.lbDatumVon.Name = "lbDatumVon";
            this.lbDatumVon.Size = new System.Drawing.Size(80, 18);
            this.lbDatumVon.TabIndex = 0;
            this.lbDatumVon.Text = "Datum Von:";
            // 
            // lbDatumBis
            // 
            this.lbDatumBis.AutoSize = true;
            this.lbDatumBis.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDatumBis.Location = new System.Drawing.Point(14, 60);
            this.lbDatumBis.Name = "lbDatumBis";
            this.lbDatumBis.Size = new System.Drawing.Size(74, 18);
            this.lbDatumBis.TabIndex = 0;
            this.lbDatumBis.Text = "Datum Bis:";
            // 
            // dtpDatumBis
            // 
            this.dtpDatumBis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDatumBis.CalendarFont = new System.Drawing.Font("Calibri", 11.25F);
            this.dtpDatumBis.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.dtpDatumBis.Location = new System.Drawing.Point(129, 54);
            this.dtpDatumBis.Name = "dtpDatumBis";
            this.dtpDatumBis.Size = new System.Drawing.Size(241, 26);
            this.dtpDatumBis.TabIndex = 6;
            this.dtpDatumBis.ValueChanged += new System.EventHandler(this.dtpDatumBis_ValueChanged);
            // 
            // dtpDatumVon
            // 
            this.dtpDatumVon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDatumVon.CalendarFont = new System.Drawing.Font("Calibri", 11.25F);
            this.dtpDatumVon.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.dtpDatumVon.Location = new System.Drawing.Point(129, 22);
            this.dtpDatumVon.Name = "dtpDatumVon";
            this.dtpDatumVon.Size = new System.Drawing.Size(242, 26);
            this.dtpDatumVon.TabIndex = 5;
            this.dtpDatumVon.ValueChanged += new System.EventHandler(this.dtpDatumVon_ValueChanged);
            // 
            // btSchliessen
            // 
            this.btSchliessen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btSchliessen.BackgroundImage = global::PuG_Verwaltungssoftware.Properties.Resources.pug_close_groß;
            this.btSchliessen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btSchliessen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSchliessen.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btSchliessen.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSchliessen.Location = new System.Drawing.Point(6, 10);
            this.btSchliessen.Name = "btSchliessen";
            this.btSchliessen.Size = new System.Drawing.Size(55, 55);
            this.btSchliessen.TabIndex = 22;
            this.btSchliessen.UseVisualStyleBackColor = true;
            this.btSchliessen.Click += new System.EventHandler(this.btSchliessen_Click);
            // 
            // btSpeichern
            // 
            this.btSpeichern.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btSpeichern.BackgroundImage = global::PuG_Verwaltungssoftware.Properties.Resources.pug_save_groß;
            this.btSpeichern.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btSpeichern.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSpeichern.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btSpeichern.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSpeichern.Location = new System.Drawing.Point(323, 10);
            this.btSpeichern.Name = "btSpeichern";
            this.btSpeichern.Size = new System.Drawing.Size(55, 55);
            this.btSpeichern.TabIndex = 21;
            this.btSpeichern.UseVisualStyleBackColor = true;
            this.btSpeichern.Click += new System.EventHandler(this.btSpeichern_Click);
            // 
            // gbButtons
            // 
            this.gbButtons.Controls.Add(this.btSpeichern);
            this.gbButtons.Controls.Add(this.btSchliessen);
            this.gbButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbButtons.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbButtons.Location = new System.Drawing.Point(0, 385);
            this.gbButtons.Name = "gbButtons";
            this.gbButtons.Size = new System.Drawing.Size(384, 71);
            this.gbButtons.TabIndex = 10;
            this.gbButtons.TabStop = false;
            // 
            // winKursNeu
            // 
            this.AcceptButton = this.btSpeichern;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btSchliessen;
            this.ClientSize = new System.Drawing.Size(384, 456);
            this.Controls.Add(this.gbButtons);
            this.Controls.Add(this.gbZeiten);
            this.Controls.Add(this.gbDaten);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 490);
            this.MinimumSize = new System.Drawing.Size(400, 490);
            this.Name = "winKursNeu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Neuen Kurs anlegen";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.winKursNeu_FormClosing);
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
    private System.Windows.Forms.Label lbPreis;
    private System.Windows.Forms.Label lbKursleiter;
    private System.Windows.Forms.TextBox tbBezeichnung;
    private System.Windows.Forms.GroupBox gbDaten;
    private System.Windows.Forms.Label lbBezeichnung;
    private System.Windows.Forms.GroupBox gbZeiten;
    private System.Windows.Forms.TextBox tbPreis;
    private System.Windows.Forms.TextBox tbMaxTeilnehmer;
    private System.Windows.Forms.Label lbMaxTeilnehmer;
    private System.Windows.Forms.ComboBox cbKursleiter;
    private System.Windows.Forms.Label lbUhrzeitVon;
    private System.Windows.Forms.Label lbWochentag;
    private System.Windows.Forms.Label lbDatumVon;
    private System.Windows.Forms.Label lbDatumBis;
    private System.Windows.Forms.DateTimePicker dtpDatumBis;
    private System.Windows.Forms.DateTimePicker dtpDatumVon;
    private System.Windows.Forms.ComboBox cbWochentag;
    private System.Windows.Forms.DateTimePicker dtpUhrzeitVon;
    private System.Windows.Forms.DateTimePicker dtpUhrzeitBis;
    private System.Windows.Forms.Label lbUhrzeitBis;
    private System.Windows.Forms.GroupBox gbButtons;
  }
}