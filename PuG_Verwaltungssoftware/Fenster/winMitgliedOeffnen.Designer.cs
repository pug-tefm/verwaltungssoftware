namespace PuG_Verwaltungssoftware
{
    partial class winMitgliedOeffnen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(winMitgliedOeffnen));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gbVertrag = new System.Windows.Forms.GroupBox();
            this.tbVertragsart = new System.Windows.Forms.TextBox();
            this.ddlVertragsart = new System.Windows.Forms.ComboBox();
            this.tbVertragsDatum = new System.Windows.Forms.TextBox();
            this.cbGesperrt = new System.Windows.Forms.CheckBox();
            this.dtpVertragsDatum = new System.Windows.Forms.DateTimePicker();
            this.tbKommentar = new System.Windows.Forms.TextBox();
            this.lbKommentar = new System.Windows.Forms.Label();
            this.lbGesperrt = new System.Windows.Forms.Label();
            this.lbVertragsdatum = new System.Windows.Forms.Label();
            this.lbVertragsart = new System.Windows.Forms.Label();
            this.gbAnschrift = new System.Windows.Forms.GroupBox();
            this.tbPlz = new System.Windows.Forms.TextBox();
            this.tbOrt = new System.Windows.Forms.TextBox();
            this.tbHausnummer = new System.Windows.Forms.TextBox();
            this.tbStrasse = new System.Windows.Forms.TextBox();
            this.lbPlz = new System.Windows.Forms.Label();
            this.lbOrt = new System.Windows.Forms.Label();
            this.lbHausnummer = new System.Windows.Forms.Label();
            this.lbStrasse = new System.Windows.Forms.Label();
            this.gbDaten = new System.Windows.Forms.GroupBox();
            this.tbDatum = new System.Windows.Forms.TextBox();
            this.lbVorname = new System.Windows.Forms.Label();
            this.lbNachname = new System.Windows.Forms.Label();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.tbVorname = new System.Windows.Forms.TextBox();
            this.lbDatum = new System.Windows.Forms.Label();
            this.tbNachname = new System.Windows.Forms.TextBox();
            this.btSchliessen = new System.Windows.Forms.Button();
            this.btSpeichern = new System.Windows.Forms.Button();
            this.btBearbeiten = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbVertrag.SuspendLayout();
            this.gbAnschrift.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.gbVertrag);
            this.splitContainer1.Panel1.Controls.Add(this.gbAnschrift);
            this.splitContainer1.Panel1.Controls.Add(this.gbDaten);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btSchliessen);
            this.splitContainer1.Panel2.Controls.Add(this.btSpeichern);
            this.splitContainer1.Panel2.Controls.Add(this.btBearbeiten);
            this.splitContainer1.Size = new System.Drawing.Size(503, 507);
            this.splitContainer1.SplitterDistance = 450;
            this.splitContainer1.TabIndex = 0;
            // 
            // gbVertrag
            // 
            this.gbVertrag.Controls.Add(this.tbVertragsart);
            this.gbVertrag.Controls.Add(this.ddlVertragsart);
            this.gbVertrag.Controls.Add(this.tbVertragsDatum);
            this.gbVertrag.Controls.Add(this.cbGesperrt);
            this.gbVertrag.Controls.Add(this.dtpVertragsDatum);
            this.gbVertrag.Controls.Add(this.tbKommentar);
            this.gbVertrag.Controls.Add(this.lbKommentar);
            this.gbVertrag.Controls.Add(this.lbGesperrt);
            this.gbVertrag.Controls.Add(this.lbVertragsdatum);
            this.gbVertrag.Controls.Add(this.lbVertragsart);
            this.gbVertrag.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbVertrag.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbVertrag.Location = new System.Drawing.Point(0, 291);
            this.gbVertrag.Name = "gbVertrag";
            this.gbVertrag.Size = new System.Drawing.Size(503, 162);
            this.gbVertrag.TabIndex = 10;
            this.gbVertrag.TabStop = false;
            this.gbVertrag.Text = "Vertragsdaten";
            // 
            // tbVertragsart
            // 
            this.tbVertragsart.Location = new System.Drawing.Point(120, 0);
            this.tbVertragsart.Name = "tbVertragsart";
            this.tbVertragsart.ReadOnly = true;
            this.tbVertragsart.Size = new System.Drawing.Size(361, 23);
            this.tbVertragsart.TabIndex = 18;
            // 
            // ddlVertragsart
            // 
            this.ddlVertragsart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlVertragsart.Enabled = false;
            this.ddlVertragsart.FormattingEnabled = true;
            this.ddlVertragsart.Location = new System.Drawing.Point(119, 23);
            this.ddlVertragsart.Name = "ddlVertragsart";
            this.ddlVertragsart.Size = new System.Drawing.Size(362, 23);
            this.ddlVertragsart.TabIndex = 17;
            // 
            // tbVertragsDatum
            // 
            this.tbVertragsDatum.Location = new System.Drawing.Point(119, 59);
            this.tbVertragsDatum.Name = "tbVertragsDatum";
            this.tbVertragsDatum.ReadOnly = true;
            this.tbVertragsDatum.Size = new System.Drawing.Size(361, 23);
            this.tbVertragsDatum.TabIndex = 16;
            // 
            // cbGesperrt
            // 
            this.cbGesperrt.AutoSize = true;
            this.cbGesperrt.Enabled = false;
            this.cbGesperrt.Location = new System.Drawing.Point(119, 98);
            this.cbGesperrt.Name = "cbGesperrt";
            this.cbGesperrt.Size = new System.Drawing.Size(15, 14);
            this.cbGesperrt.TabIndex = 15;
            this.cbGesperrt.UseVisualStyleBackColor = true;
            // 
            // dtpVertragsDatum
            // 
            this.dtpVertragsDatum.Location = new System.Drawing.Point(119, 59);
            this.dtpVertragsDatum.Name = "dtpVertragsDatum";
            this.dtpVertragsDatum.Size = new System.Drawing.Size(362, 23);
            this.dtpVertragsDatum.TabIndex = 14;
            // 
            // tbKommentar
            // 
            this.tbKommentar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKommentar.Location = new System.Drawing.Point(119, 123);
            this.tbKommentar.Name = "tbKommentar";
            this.tbKommentar.ReadOnly = true;
            this.tbKommentar.Size = new System.Drawing.Size(362, 26);
            this.tbKommentar.TabIndex = 13;
            // 
            // lbKommentar
            // 
            this.lbKommentar.AutoSize = true;
            this.lbKommentar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKommentar.Location = new System.Drawing.Point(12, 131);
            this.lbKommentar.Name = "lbKommentar";
            this.lbKommentar.Size = new System.Drawing.Size(85, 18);
            this.lbKommentar.TabIndex = 12;
            this.lbKommentar.Text = "Kommentar:";
            // 
            // lbGesperrt
            // 
            this.lbGesperrt.AutoSize = true;
            this.lbGesperrt.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGesperrt.Location = new System.Drawing.Point(12, 98);
            this.lbGesperrt.Name = "lbGesperrt";
            this.lbGesperrt.Size = new System.Drawing.Size(66, 18);
            this.lbGesperrt.TabIndex = 10;
            this.lbGesperrt.Text = "Gesperrt:";
            // 
            // lbVertragsdatum
            // 
            this.lbVertragsdatum.AutoSize = true;
            this.lbVertragsdatum.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVertragsdatum.Location = new System.Drawing.Point(12, 64);
            this.lbVertragsdatum.Name = "lbVertragsdatum";
            this.lbVertragsdatum.Size = new System.Drawing.Size(103, 18);
            this.lbVertragsdatum.TabIndex = 8;
            this.lbVertragsdatum.Text = "Vertragsdatum:";
            // 
            // lbVertragsart
            // 
            this.lbVertragsart.AutoSize = true;
            this.lbVertragsart.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVertragsart.Location = new System.Drawing.Point(12, 30);
            this.lbVertragsart.Name = "lbVertragsart";
            this.lbVertragsart.Size = new System.Drawing.Size(80, 18);
            this.lbVertragsart.TabIndex = 3;
            this.lbVertragsart.Text = "Vertragsart:";
            // 
            // gbAnschrift
            // 
            this.gbAnschrift.Controls.Add(this.tbPlz);
            this.gbAnschrift.Controls.Add(this.tbOrt);
            this.gbAnschrift.Controls.Add(this.tbHausnummer);
            this.gbAnschrift.Controls.Add(this.tbStrasse);
            this.gbAnschrift.Controls.Add(this.lbPlz);
            this.gbAnschrift.Controls.Add(this.lbOrt);
            this.gbAnschrift.Controls.Add(this.lbHausnummer);
            this.gbAnschrift.Controls.Add(this.lbStrasse);
            this.gbAnschrift.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbAnschrift.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAnschrift.Location = new System.Drawing.Point(0, 142);
            this.gbAnschrift.Name = "gbAnschrift";
            this.gbAnschrift.Size = new System.Drawing.Size(503, 149);
            this.gbAnschrift.TabIndex = 9;
            this.gbAnschrift.TabStop = false;
            this.gbAnschrift.Text = "Anschrift";
            // 
            // tbPlz
            // 
            this.tbPlz.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPlz.Location = new System.Drawing.Point(119, 81);
            this.tbPlz.Name = "tbPlz";
            this.tbPlz.ReadOnly = true;
            this.tbPlz.Size = new System.Drawing.Size(362, 26);
            this.tbPlz.TabIndex = 9;
            // 
            // tbOrt
            // 
            this.tbOrt.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOrt.Location = new System.Drawing.Point(119, 109);
            this.tbOrt.Name = "tbOrt";
            this.tbOrt.ReadOnly = true;
            this.tbOrt.Size = new System.Drawing.Size(362, 26);
            this.tbOrt.TabIndex = 8;
            // 
            // tbHausnummer
            // 
            this.tbHausnummer.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHausnummer.Location = new System.Drawing.Point(119, 53);
            this.tbHausnummer.Name = "tbHausnummer";
            this.tbHausnummer.ReadOnly = true;
            this.tbHausnummer.Size = new System.Drawing.Size(362, 26);
            this.tbHausnummer.TabIndex = 7;
            // 
            // tbStrasse
            // 
            this.tbStrasse.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStrasse.Location = new System.Drawing.Point(119, 22);
            this.tbStrasse.Name = "tbStrasse";
            this.tbStrasse.ReadOnly = true;
            this.tbStrasse.Size = new System.Drawing.Size(362, 26);
            this.tbStrasse.TabIndex = 6;
            // 
            // lbPlz
            // 
            this.lbPlz.AutoSize = true;
            this.lbPlz.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlz.Location = new System.Drawing.Point(12, 89);
            this.lbPlz.Name = "lbPlz";
            this.lbPlz.Size = new System.Drawing.Size(85, 18);
            this.lbPlz.TabIndex = 5;
            this.lbPlz.Text = "Postleitzahl:";
            // 
            // lbOrt
            // 
            this.lbOrt.AutoSize = true;
            this.lbOrt.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrt.Location = new System.Drawing.Point(12, 117);
            this.lbOrt.Name = "lbOrt";
            this.lbOrt.Size = new System.Drawing.Size(32, 18);
            this.lbOrt.TabIndex = 4;
            this.lbOrt.Text = "Ort:";
            // 
            // lbHausnummer
            // 
            this.lbHausnummer.AutoSize = true;
            this.lbHausnummer.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHausnummer.Location = new System.Drawing.Point(12, 61);
            this.lbHausnummer.Name = "lbHausnummer";
            this.lbHausnummer.Size = new System.Drawing.Size(95, 18);
            this.lbHausnummer.TabIndex = 3;
            this.lbHausnummer.Text = "Hausnummer:";
            // 
            // lbStrasse
            // 
            this.lbStrasse.AutoSize = true;
            this.lbStrasse.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStrasse.Location = new System.Drawing.Point(12, 30);
            this.lbStrasse.Name = "lbStrasse";
            this.lbStrasse.Size = new System.Drawing.Size(52, 18);
            this.lbStrasse.TabIndex = 2;
            this.lbStrasse.Text = "Straße:";
            // 
            // gbDaten
            // 
            this.gbDaten.Controls.Add(this.tbDatum);
            this.gbDaten.Controls.Add(this.lbVorname);
            this.gbDaten.Controls.Add(this.lbNachname);
            this.gbDaten.Controls.Add(this.dtpDatum);
            this.gbDaten.Controls.Add(this.tbVorname);
            this.gbDaten.Controls.Add(this.lbDatum);
            this.gbDaten.Controls.Add(this.tbNachname);
            this.gbDaten.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbDaten.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDaten.Location = new System.Drawing.Point(0, 0);
            this.gbDaten.Name = "gbDaten";
            this.gbDaten.Size = new System.Drawing.Size(503, 142);
            this.gbDaten.TabIndex = 8;
            this.gbDaten.TabStop = false;
            this.gbDaten.Text = "Persönliche Daten";
            // 
            // tbDatum
            // 
            this.tbDatum.Location = new System.Drawing.Point(119, 88);
            this.tbDatum.Name = "tbDatum";
            this.tbDatum.ReadOnly = true;
            this.tbDatum.Size = new System.Drawing.Size(361, 23);
            this.tbDatum.TabIndex = 6;
            // 
            // lbVorname
            // 
            this.lbVorname.AutoSize = true;
            this.lbVorname.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVorname.Location = new System.Drawing.Point(12, 26);
            this.lbVorname.Name = "lbVorname";
            this.lbVorname.Size = new System.Drawing.Size(68, 18);
            this.lbVorname.TabIndex = 1;
            this.lbVorname.Text = "Vorname:";
            // 
            // lbNachname
            // 
            this.lbNachname.AutoSize = true;
            this.lbNachname.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNachname.Location = new System.Drawing.Point(12, 58);
            this.lbNachname.Name = "lbNachname";
            this.lbNachname.Size = new System.Drawing.Size(78, 18);
            this.lbNachname.TabIndex = 2;
            this.lbNachname.Text = "Nachname:";
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(119, 88);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(362, 23);
            this.dtpDatum.TabIndex = 5;
            // 
            // tbVorname
            // 
            this.tbVorname.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVorname.Location = new System.Drawing.Point(119, 18);
            this.tbVorname.Name = "tbVorname";
            this.tbVorname.ReadOnly = true;
            this.tbVorname.Size = new System.Drawing.Size(362, 26);
            this.tbVorname.TabIndex = 1;
            // 
            // lbDatum
            // 
            this.lbDatum.AutoSize = true;
            this.lbDatum.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDatum.Location = new System.Drawing.Point(12, 92);
            this.lbDatum.Name = "lbDatum";
            this.lbDatum.Size = new System.Drawing.Size(101, 18);
            this.lbDatum.TabIndex = 4;
            this.lbDatum.Text = "Geburtsdatum:";
            // 
            // tbNachname
            // 
            this.tbNachname.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNachname.Location = new System.Drawing.Point(119, 50);
            this.tbNachname.Name = "tbNachname";
            this.tbNachname.ReadOnly = true;
            this.tbNachname.Size = new System.Drawing.Size(362, 26);
            this.tbNachname.TabIndex = 3;
            // 
            // btSchliessen
            // 
            this.btSchliessen.Dock = System.Windows.Forms.DockStyle.Right;
            this.btSchliessen.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSchliessen.Location = new System.Drawing.Point(398, 0);
            this.btSchliessen.Name = "btSchliessen";
            this.btSchliessen.Size = new System.Drawing.Size(105, 53);
            this.btSchliessen.TabIndex = 2;
            this.btSchliessen.Text = "Schließen";
            this.btSchliessen.UseVisualStyleBackColor = true;
            // 
            // btSpeichern
            // 
            this.btSpeichern.Dock = System.Windows.Forms.DockStyle.Left;
            this.btSpeichern.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSpeichern.Location = new System.Drawing.Point(105, 0);
            this.btSpeichern.Name = "btSpeichern";
            this.btSpeichern.Size = new System.Drawing.Size(105, 53);
            this.btSpeichern.TabIndex = 1;
            this.btSpeichern.Text = "Speichern";
            this.btSpeichern.UseVisualStyleBackColor = true;
            // 
            // btBearbeiten
            // 
            this.btBearbeiten.Dock = System.Windows.Forms.DockStyle.Left;
            this.btBearbeiten.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBearbeiten.Location = new System.Drawing.Point(0, 0);
            this.btBearbeiten.Name = "btBearbeiten";
            this.btBearbeiten.Size = new System.Drawing.Size(105, 53);
            this.btBearbeiten.TabIndex = 0;
            this.btBearbeiten.Text = "Bearbeiten";
            this.btBearbeiten.UseVisualStyleBackColor = true;
            // 
            // winMitgliedOeffnen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 507);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "winMitgliedOeffnen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mitglied anzeigen und bearbeiten";
            this.Load += new System.EventHandler(this.winMitgliedOeffnen_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gbVertrag.ResumeLayout(false);
            this.gbVertrag.PerformLayout();
            this.gbAnschrift.ResumeLayout(false);
            this.gbAnschrift.PerformLayout();
            this.gbDaten.ResumeLayout(false);
            this.gbDaten.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btSchliessen;
        private System.Windows.Forms.Button btSpeichern;
        private System.Windows.Forms.Button btBearbeiten;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.Label lbDatum;
        private System.Windows.Forms.TextBox tbNachname;
        private System.Windows.Forms.Label lbNachname;
        private System.Windows.Forms.TextBox tbVorname;
        private System.Windows.Forms.GroupBox gbDaten;
        private System.Windows.Forms.Label lbVorname;
        private System.Windows.Forms.GroupBox gbAnschrift;
        private System.Windows.Forms.Label lbPlz;
        private System.Windows.Forms.Label lbOrt;
        private System.Windows.Forms.Label lbHausnummer;
        private System.Windows.Forms.Label lbStrasse;
        private System.Windows.Forms.GroupBox gbVertrag;
        private System.Windows.Forms.Label lbVertragsart;
        private System.Windows.Forms.TextBox tbPlz;
        private System.Windows.Forms.TextBox tbOrt;
        private System.Windows.Forms.TextBox tbHausnummer;
        private System.Windows.Forms.TextBox tbStrasse;
        private System.Windows.Forms.TextBox tbKommentar;
        private System.Windows.Forms.Label lbKommentar;
        private System.Windows.Forms.Label lbGesperrt;
        private System.Windows.Forms.Label lbVertragsdatum;
        private System.Windows.Forms.DateTimePicker dtpVertragsDatum;
        private System.Windows.Forms.CheckBox cbGesperrt;
        private System.Windows.Forms.TextBox tbVertragsDatum;
        private System.Windows.Forms.TextBox tbDatum;
        private System.Windows.Forms.ComboBox ddlVertragsart;
        private System.Windows.Forms.TextBox tbVertragsart;
    }
}