namespace PuG_Verwaltungssoftware
{
    partial class winMitarbeiterOeffnen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(winMitarbeiterOeffnen));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gbLoginDaten = new System.Windows.Forms.GroupBox();
            this.tbPosition = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbBenutzername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbGehalt = new System.Windows.Forms.GroupBox();
            this.tbGehalt = new System.Windows.Forms.TextBox();
            this.lbGehalt = new System.Windows.Forms.Label();
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
            this.ddlMitarbeiterPosition = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbLoginDaten.SuspendLayout();
            this.gbGehalt.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.gbLoginDaten);
            this.splitContainer1.Panel1.Controls.Add(this.gbGehalt);
            this.splitContainer1.Panel1.Controls.Add(this.gbAnschrift);
            this.splitContainer1.Panel1.Controls.Add(this.gbDaten);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btSchliessen);
            this.splitContainer1.Panel2.Controls.Add(this.btSpeichern);
            this.splitContainer1.Panel2.Controls.Add(this.btBearbeiten);
            this.splitContainer1.Size = new System.Drawing.Size(394, 492);
            this.splitContainer1.SplitterDistance = 438;
            this.splitContainer1.TabIndex = 0;
            // 
            // gbLoginDaten
            // 
            this.gbLoginDaten.Controls.Add(this.ddlMitarbeiterPosition);
            this.gbLoginDaten.Controls.Add(this.tbPosition);
            this.gbLoginDaten.Controls.Add(this.label2);
            this.gbLoginDaten.Controls.Add(this.tbBenutzername);
            this.gbLoginDaten.Controls.Add(this.label1);
            this.gbLoginDaten.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbLoginDaten.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLoginDaten.Location = new System.Drawing.Point(0, 359);
            this.gbLoginDaten.Name = "gbLoginDaten";
            this.gbLoginDaten.Size = new System.Drawing.Size(394, 82);
            this.gbLoginDaten.TabIndex = 11;
            this.gbLoginDaten.TabStop = false;
            this.gbLoginDaten.Text = "Login - Daten";
            // 
            // tbPosition
            // 
            this.tbPosition.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPosition.Location = new System.Drawing.Point(119, 49);
            this.tbPosition.Name = "tbPosition";
            this.tbPosition.ReadOnly = true;
            this.tbPosition.Size = new System.Drawing.Size(253, 26);
            this.tbPosition.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Position:";
            // 
            // tbBenutzername
            // 
            this.tbBenutzername.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBenutzername.Location = new System.Drawing.Point(119, 22);
            this.tbBenutzername.Name = "tbBenutzername";
            this.tbBenutzername.ReadOnly = true;
            this.tbBenutzername.Size = new System.Drawing.Size(253, 26);
            this.tbBenutzername.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Benutzername:";
            // 
            // gbGehalt
            // 
            this.gbGehalt.Controls.Add(this.tbGehalt);
            this.gbGehalt.Controls.Add(this.lbGehalt);
            this.gbGehalt.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbGehalt.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGehalt.Location = new System.Drawing.Point(0, 291);
            this.gbGehalt.Name = "gbGehalt";
            this.gbGehalt.Size = new System.Drawing.Size(394, 68);
            this.gbGehalt.TabIndex = 10;
            this.gbGehalt.TabStop = false;
            this.gbGehalt.Text = "Gehalt";
            // 
            // tbGehalt
            // 
            this.tbGehalt.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGehalt.Location = new System.Drawing.Point(119, 22);
            this.tbGehalt.Name = "tbGehalt";
            this.tbGehalt.ReadOnly = true;
            this.tbGehalt.Size = new System.Drawing.Size(253, 26);
            this.tbGehalt.TabIndex = 7;
            // 
            // lbGehalt
            // 
            this.lbGehalt.AutoSize = true;
            this.lbGehalt.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGehalt.Location = new System.Drawing.Point(12, 30);
            this.lbGehalt.Name = "lbGehalt";
            this.lbGehalt.Size = new System.Drawing.Size(53, 18);
            this.lbGehalt.TabIndex = 3;
            this.lbGehalt.Text = "Gehalt:";
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
            this.gbAnschrift.Size = new System.Drawing.Size(394, 149);
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
            this.tbPlz.Size = new System.Drawing.Size(253, 26);
            this.tbPlz.TabIndex = 9;
            // 
            // tbOrt
            // 
            this.tbOrt.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOrt.Location = new System.Drawing.Point(119, 109);
            this.tbOrt.Name = "tbOrt";
            this.tbOrt.ReadOnly = true;
            this.tbOrt.Size = new System.Drawing.Size(253, 26);
            this.tbOrt.TabIndex = 8;
            // 
            // tbHausnummer
            // 
            this.tbHausnummer.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHausnummer.Location = new System.Drawing.Point(119, 53);
            this.tbHausnummer.Name = "tbHausnummer";
            this.tbHausnummer.ReadOnly = true;
            this.tbHausnummer.Size = new System.Drawing.Size(253, 26);
            this.tbHausnummer.TabIndex = 7;
            // 
            // tbStrasse
            // 
            this.tbStrasse.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStrasse.Location = new System.Drawing.Point(119, 22);
            this.tbStrasse.Name = "tbStrasse";
            this.tbStrasse.ReadOnly = true;
            this.tbStrasse.Size = new System.Drawing.Size(253, 26);
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
            this.gbDaten.Size = new System.Drawing.Size(394, 142);
            this.gbDaten.TabIndex = 8;
            this.gbDaten.TabStop = false;
            this.gbDaten.Text = "Persönliche Daten";
            // 
            // tbDatum
            // 
            this.tbDatum.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDatum.Location = new System.Drawing.Point(119, 88);
            this.tbDatum.Name = "tbDatum";
            this.tbDatum.ReadOnly = true;
            this.tbDatum.Size = new System.Drawing.Size(253, 26);
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
            this.dtpDatum.Size = new System.Drawing.Size(214, 23);
            this.dtpDatum.TabIndex = 5;
            // 
            // tbVorname
            // 
            this.tbVorname.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVorname.Location = new System.Drawing.Point(119, 18);
            this.tbVorname.Name = "tbVorname";
            this.tbVorname.ReadOnly = true;
            this.tbVorname.Size = new System.Drawing.Size(253, 26);
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
            this.tbNachname.Size = new System.Drawing.Size(253, 26);
            this.tbNachname.TabIndex = 3;
            // 
            // btSchliessen
            // 
            this.btSchliessen.Dock = System.Windows.Forms.DockStyle.Right;
            this.btSchliessen.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSchliessen.Location = new System.Drawing.Point(289, 0);
            this.btSchliessen.Name = "btSchliessen";
            this.btSchliessen.Size = new System.Drawing.Size(105, 50);
            this.btSchliessen.TabIndex = 2;
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
            this.btSpeichern.Size = new System.Drawing.Size(105, 50);
            this.btSpeichern.TabIndex = 1;
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
            this.btBearbeiten.Size = new System.Drawing.Size(105, 50);
            this.btBearbeiten.TabIndex = 0;
            this.btBearbeiten.Text = "Bearbeiten";
            this.btBearbeiten.UseVisualStyleBackColor = true;
            this.btBearbeiten.Click += new System.EventHandler(this.btBearbeiten_Click);
            // 
            // ddlMitarbeiterPosition
            // 
            this.ddlMitarbeiterPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlMitarbeiterPosition.FormattingEnabled = true;
            this.ddlMitarbeiterPosition.Location = new System.Drawing.Point(119, 52);
            this.ddlMitarbeiterPosition.Name = "ddlMitarbeiterPosition";
            this.ddlMitarbeiterPosition.Size = new System.Drawing.Size(253, 23);
            this.ddlMitarbeiterPosition.TabIndex = 11;
            this.ddlMitarbeiterPosition.Visible = false;
            // 
            // winMitarbeiterOeffnen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 492);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(410, 530);
            this.Name = "winMitarbeiterOeffnen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mitarbeiter anzeigen und bearbeiten";
            this.Load += new System.EventHandler(this.winMitarbeiterOeffnen_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gbLoginDaten.ResumeLayout(false);
            this.gbLoginDaten.PerformLayout();
            this.gbGehalt.ResumeLayout(false);
            this.gbGehalt.PerformLayout();
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
        private System.Windows.Forms.GroupBox gbGehalt;
        private System.Windows.Forms.TextBox tbGehalt;
        private System.Windows.Forms.Label lbGehalt;
        private System.Windows.Forms.TextBox tbPlz;
        private System.Windows.Forms.TextBox tbOrt;
        private System.Windows.Forms.TextBox tbHausnummer;
        private System.Windows.Forms.TextBox tbStrasse;
        private System.Windows.Forms.TextBox tbDatum;
        private System.Windows.Forms.GroupBox gbLoginDaten;
        private System.Windows.Forms.TextBox tbBenutzername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPosition;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ddlMitarbeiterPosition;
    }
}