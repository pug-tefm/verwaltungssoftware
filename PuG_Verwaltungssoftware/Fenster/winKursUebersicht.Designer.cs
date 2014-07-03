namespace PuG_Verwaltungssoftware.Fenster
{
    partial class winKursUebersicht
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gbTeilnehmer = new System.Windows.Forms.GroupBox();
            this.gridKursUebersichtTeilnehmer = new System.Windows.Forms.DataGridView();
            this.tbBezeichnung = new System.Windows.Forms.TextBox();
            this.lbBezeichnung = new System.Windows.Forms.Label();
            this.btKursUebersichtLoeschen = new System.Windows.Forms.Button();
            this.btKursUebersichtNeu = new System.Windows.Forms.Button();
            this.btSchliessen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbTeilnehmer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridKursUebersichtTeilnehmer)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.gbTeilnehmer);
            this.splitContainer1.Panel1.Controls.Add(this.tbBezeichnung);
            this.splitContainer1.Panel1.Controls.Add(this.lbBezeichnung);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btKursUebersichtLoeschen);
            this.splitContainer1.Panel2.Controls.Add(this.btKursUebersichtNeu);
            this.splitContainer1.Panel2.Controls.Add(this.btSchliessen);
            this.splitContainer1.Size = new System.Drawing.Size(404, 427);
            this.splitContainer1.SplitterDistance = 371;
            this.splitContainer1.TabIndex = 0;
            // 
            // gbTeilnehmer
            // 
            this.gbTeilnehmer.Controls.Add(this.gridKursUebersichtTeilnehmer);
            this.gbTeilnehmer.Location = new System.Drawing.Point(12, 41);
            this.gbTeilnehmer.Name = "gbTeilnehmer";
            this.gbTeilnehmer.Size = new System.Drawing.Size(380, 327);
            this.gbTeilnehmer.TabIndex = 3;
            this.gbTeilnehmer.TabStop = false;
            this.gbTeilnehmer.Text = "Teilnehmer:";
            // 
            // gridKursUebersichtTeilnehmer
            // 
            this.gridKursUebersichtTeilnehmer.AllowUserToAddRows = false;
            this.gridKursUebersichtTeilnehmer.AllowUserToDeleteRows = false;
            this.gridKursUebersichtTeilnehmer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridKursUebersichtTeilnehmer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridKursUebersichtTeilnehmer.Location = new System.Drawing.Point(3, 16);
            this.gridKursUebersichtTeilnehmer.Name = "gridKursUebersichtTeilnehmer";
            this.gridKursUebersichtTeilnehmer.ReadOnly = true;
            this.gridKursUebersichtTeilnehmer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridKursUebersichtTeilnehmer.Size = new System.Drawing.Size(374, 308);
            this.gridKursUebersichtTeilnehmer.TabIndex = 0;
            // 
            // tbBezeichnung
            // 
            this.tbBezeichnung.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBezeichnung.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBezeichnung.Location = new System.Drawing.Point(124, 9);
            this.tbBezeichnung.MaxLength = 100;
            this.tbBezeichnung.Name = "tbBezeichnung";
            this.tbBezeichnung.Size = new System.Drawing.Size(268, 26);
            this.tbBezeichnung.TabIndex = 2;
            // 
            // lbBezeichnung
            // 
            this.lbBezeichnung.AutoSize = true;
            this.lbBezeichnung.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBezeichnung.Location = new System.Drawing.Point(12, 12);
            this.lbBezeichnung.Name = "lbBezeichnung";
            this.lbBezeichnung.Size = new System.Drawing.Size(81, 18);
            this.lbBezeichnung.TabIndex = 1;
            this.lbBezeichnung.Text = "Kurs-Name:";
            // 
            // btKursUebersichtLoeschen
            // 
            this.btKursUebersichtLoeschen.Dock = System.Windows.Forms.DockStyle.Left;
            this.btKursUebersichtLoeschen.Location = new System.Drawing.Point(92, 0);
            this.btKursUebersichtLoeschen.Name = "btKursUebersichtLoeschen";
            this.btKursUebersichtLoeschen.Size = new System.Drawing.Size(92, 52);
            this.btKursUebersichtLoeschen.TabIndex = 25;
            this.btKursUebersichtLoeschen.Text = "Löschen";
            this.btKursUebersichtLoeschen.UseVisualStyleBackColor = true;
            this.btKursUebersichtLoeschen.Click += new System.EventHandler(this.btKursUebersichtLoeschen_Click);
            // 
            // btKursUebersichtNeu
            // 
            this.btKursUebersichtNeu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btKursUebersichtNeu.Location = new System.Drawing.Point(0, 0);
            this.btKursUebersichtNeu.Name = "btKursUebersichtNeu";
            this.btKursUebersichtNeu.Size = new System.Drawing.Size(92, 52);
            this.btKursUebersichtNeu.TabIndex = 24;
            this.btKursUebersichtNeu.Text = "Hinzufügen";
            this.btKursUebersichtNeu.UseVisualStyleBackColor = true;
            this.btKursUebersichtNeu.Click += new System.EventHandler(this.btKursUebersichtNeu_Click);
            // 
            // btSchliessen
            // 
            this.btSchliessen.Dock = System.Windows.Forms.DockStyle.Right;
            this.btSchliessen.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSchliessen.Location = new System.Drawing.Point(299, 0);
            this.btSchliessen.Name = "btSchliessen";
            this.btSchliessen.Size = new System.Drawing.Size(105, 52);
            this.btSchliessen.TabIndex = 23;
            this.btSchliessen.Text = "Schließen";
            this.btSchliessen.UseVisualStyleBackColor = true;
            this.btSchliessen.Click += new System.EventHandler(this.btSchliessen_Click);
            // 
            // winKursUebersicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 427);
            this.Controls.Add(this.splitContainer1);
            this.MaximumSize = new System.Drawing.Size(420, 465);
            this.MinimumSize = new System.Drawing.Size(420, 465);
            this.Name = "winKursUebersicht";
            this.Text = "Kurs Übersicht";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gbTeilnehmer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridKursUebersichtTeilnehmer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lbBezeichnung;
        private System.Windows.Forms.TextBox tbBezeichnung;
        private System.Windows.Forms.GroupBox gbTeilnehmer;
        private System.Windows.Forms.DataGridView gridKursUebersichtTeilnehmer;
        private System.Windows.Forms.Button btSchliessen;
        private System.Windows.Forms.Button btKursUebersichtNeu;
        private System.Windows.Forms.Button btKursUebersichtLoeschen;
    }
}