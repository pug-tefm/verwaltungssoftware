namespace PuG_Verwaltungssoftware
{
    partial class winMitarbeiterNeu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(winMitarbeiterNeu));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gbLoginDaten = new System.Windows.Forms.GroupBox();
            this.ddlPosition = new System.Windows.Forms.ComboBox();
            this.lbPosition = new System.Windows.Forms.Label();
            this.tbInitPasswort = new System.Windows.Forms.TextBox();
            this.tbInitUser = new System.Windows.Forms.TextBox();
            this.lbInitPasswort = new System.Windows.Forms.Label();
            this.lbInitUser = new System.Windows.Forms.Label();
            this.gbGehalt = new System.Windows.Forms.GroupBox();
            this.tbGehalt = new System.Windows.Forms.TextBox();
            this.lbGehalt = new System.Windows.Forms.Label();
            this.gbAnschrift = new System.Windows.Forms.GroupBox();
            this.tbOrt = new System.Windows.Forms.TextBox();
            this.tbPlz = new System.Windows.Forms.TextBox();
            this.tbHausnummer = new System.Windows.Forms.TextBox();
            this.tbStrasse = new System.Windows.Forms.TextBox();
            this.lbPlz = new System.Windows.Forms.Label();
            this.lbOrt = new System.Windows.Forms.Label();
            this.lbHausnummer = new System.Windows.Forms.Label();
            this.lbStrasse = new System.Windows.Forms.Label();
            this.gbDaten = new System.Windows.Forms.GroupBox();
            this.lbVorname = new System.Windows.Forms.Label();
            this.lbNachname = new System.Windows.Forms.Label();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.tbVorname = new System.Windows.Forms.TextBox();
            this.lbDatum = new System.Windows.Forms.Label();
            this.tbNachname = new System.Windows.Forms.TextBox();
            this.btSchliessen = new System.Windows.Forms.Button();
            this.btSpeichern = new System.Windows.Forms.Button();
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
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
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
            this.splitContainer1.Size = new System.Drawing.Size(394, 522);
            this.splitContainer1.SplitterDistance = 465;
            this.splitContainer1.TabIndex = 0;
            // 
            // gbLoginDaten
            // 
            this.gbLoginDaten.Controls.Add(this.ddlPosition);
            this.gbLoginDaten.Controls.Add(this.lbPosition);
            this.gbLoginDaten.Controls.Add(this.tbInitPasswort);
            this.gbLoginDaten.Controls.Add(this.tbInitUser);
            this.gbLoginDaten.Controls.Add(this.lbInitPasswort);
            this.gbLoginDaten.Controls.Add(this.lbInitUser);
            this.gbLoginDaten.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbLoginDaten.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLoginDaten.Location = new System.Drawing.Point(0, 353);
            this.gbLoginDaten.Name = "gbLoginDaten";
            this.gbLoginDaten.Size = new System.Drawing.Size(394, 109);
            this.gbLoginDaten.TabIndex = 11;
            this.gbLoginDaten.TabStop = false;
            this.gbLoginDaten.Text = "Login - Daten";
            // 
            // ddlPosition
            // 
            this.ddlPosition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ddlPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlPosition.FormattingEnabled = true;
            this.ddlPosition.Location = new System.Drawing.Point(116, 81);
            this.ddlPosition.Name = "ddlPosition";
            this.ddlPosition.Size = new System.Drawing.Size(253, 23);
            this.ddlPosition.TabIndex = 11;
            // 
            // lbPosition
            // 
            this.lbPosition.AutoSize = true;
            this.lbPosition.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPosition.Location = new System.Drawing.Point(7, 88);
            this.lbPosition.Name = "lbPosition";
            this.lbPosition.Size = new System.Drawing.Size(62, 18);
            this.lbPosition.TabIndex = 10;
            this.lbPosition.Text = "Position:";
            // 
            // tbInitPasswort
            // 
            this.tbInitPasswort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbInitPasswort.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInitPasswort.Location = new System.Drawing.Point(116, 48);
            this.tbInitPasswort.Name = "tbInitPasswort";
            this.tbInitPasswort.Size = new System.Drawing.Size(253, 26);
            this.tbInitPasswort.TabIndex = 9;
            // 
            // tbInitUser
            // 
            this.tbInitUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbInitUser.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInitUser.Location = new System.Drawing.Point(116, 16);
            this.tbInitUser.Name = "tbInitUser";
            this.tbInitUser.Size = new System.Drawing.Size(253, 26);
            this.tbInitUser.TabIndex = 8;
            // 
            // lbInitPasswort
            // 
            this.lbInitPasswort.AutoSize = true;
            this.lbInitPasswort.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInitPasswort.Location = new System.Drawing.Point(6, 56);
            this.lbInitPasswort.Name = "lbInitPasswort";
            this.lbInitPasswort.Size = new System.Drawing.Size(103, 18);
            this.lbInitPasswort.TabIndex = 5;
            this.lbInitPasswort.Text = "Initialpasswort:";
            // 
            // lbInitUser
            // 
            this.lbInitUser.AutoSize = true;
            this.lbInitUser.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInitUser.Location = new System.Drawing.Point(6, 24);
            this.lbInitUser.Name = "lbInitUser";
            this.lbInitUser.Size = new System.Drawing.Size(103, 18);
            this.lbInitUser.TabIndex = 4;
            this.lbInitUser.Text = "Benutzername:";
            // 
            // gbGehalt
            // 
            this.gbGehalt.Controls.Add(this.tbGehalt);
            this.gbGehalt.Controls.Add(this.lbGehalt);
            this.gbGehalt.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbGehalt.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGehalt.Location = new System.Drawing.Point(0, 291);
            this.gbGehalt.Name = "gbGehalt";
            this.gbGehalt.Size = new System.Drawing.Size(394, 62);
            this.gbGehalt.TabIndex = 10;
            this.gbGehalt.TabStop = false;
            this.gbGehalt.Text = "Gehalt";
            // 
            // tbGehalt
            // 
            this.tbGehalt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbGehalt.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGehalt.Location = new System.Drawing.Point(119, 22);
            this.tbGehalt.Name = "tbGehalt";
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
            this.gbAnschrift.Controls.Add(this.tbOrt);
            this.gbAnschrift.Controls.Add(this.tbPlz);
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
            // tbOrt
            // 
            this.tbOrt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOrt.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOrt.Location = new System.Drawing.Point(119, 113);
            this.tbOrt.Name = "tbOrt";
            this.tbOrt.Size = new System.Drawing.Size(253, 26);
            this.tbOrt.TabIndex = 9;
            // 
            // tbPlz
            // 
            this.tbPlz.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPlz.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPlz.Location = new System.Drawing.Point(119, 81);
            this.tbPlz.Name = "tbPlz";
            this.tbPlz.Size = new System.Drawing.Size(253, 26);
            this.tbPlz.TabIndex = 8;
            // 
            // tbHausnummer
            // 
            this.tbHausnummer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbHausnummer.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHausnummer.Location = new System.Drawing.Point(119, 53);
            this.tbHausnummer.Name = "tbHausnummer";
            this.tbHausnummer.Size = new System.Drawing.Size(253, 26);
            this.tbHausnummer.TabIndex = 7;
            // 
            // tbStrasse
            // 
            this.tbStrasse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbStrasse.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStrasse.Location = new System.Drawing.Point(119, 22);
            this.tbStrasse.Name = "tbStrasse";
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
            this.dtpDatum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatum.Location = new System.Drawing.Point(119, 88);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(253, 23);
            this.dtpDatum.TabIndex = 5;
            // 
            // tbVorname
            // 
            this.tbVorname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbVorname.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVorname.Location = new System.Drawing.Point(119, 18);
            this.tbVorname.Name = "tbVorname";
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
            this.tbNachname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNachname.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNachname.Location = new System.Drawing.Point(119, 50);
            this.tbNachname.Name = "tbNachname";
            this.tbNachname.Size = new System.Drawing.Size(253, 26);
            this.tbNachname.TabIndex = 3;
            // 
            // btSchliessen
            // 
            this.btSchliessen.Dock = System.Windows.Forms.DockStyle.Right;
            this.btSchliessen.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSchliessen.Location = new System.Drawing.Point(289, 0);
            this.btSchliessen.Name = "btSchliessen";
            this.btSchliessen.Size = new System.Drawing.Size(105, 53);
            this.btSchliessen.TabIndex = 2;
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
            this.btSpeichern.Size = new System.Drawing.Size(105, 53);
            this.btSpeichern.TabIndex = 1;
            this.btSpeichern.Text = "Speichern";
            this.btSpeichern.UseVisualStyleBackColor = true;
            this.btSpeichern.Click += new System.EventHandler(this.btSpeichern_Click);
            // 
            // winMitarbeiterNeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 522);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(410, 560);
            this.Name = "winMitarbeiterNeu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Neuen Mitarbeiter anlegen";
            this.Load += new System.EventHandler(this.winMitarbeiterNeu_Load);
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
        private System.Windows.Forms.TextBox tbOrt;
        private System.Windows.Forms.TextBox tbPlz;
        private System.Windows.Forms.TextBox tbHausnummer;
        private System.Windows.Forms.TextBox tbStrasse;
        private System.Windows.Forms.GroupBox gbLoginDaten;
        private System.Windows.Forms.TextBox tbInitPasswort;
        private System.Windows.Forms.TextBox tbInitUser;
        private System.Windows.Forms.Label lbInitPasswort;
        private System.Windows.Forms.Label lbInitUser;
        private System.Windows.Forms.Label lbPosition;
        private System.Windows.Forms.ComboBox ddlPosition;
    }
}