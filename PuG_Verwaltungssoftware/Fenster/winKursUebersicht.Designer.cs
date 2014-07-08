namespace PuG_Verwaltungssoftware
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
            this.gbTeilnehmer = new System.Windows.Forms.GroupBox();
            this.gridKursUebersichtTeilnehmer = new System.Windows.Forms.DataGridView();
            this.tbBezeichnung = new System.Windows.Forms.TextBox();
            this.lbBezeichnung = new System.Windows.Forms.Label();
            this.btLoeschen = new System.Windows.Forms.Button();
            this.btKursUebersichtNeu = new System.Windows.Forms.Button();
            this.btSchliessen = new System.Windows.Forms.Button();
            this.gbButtons = new System.Windows.Forms.GroupBox();
            this.gbKursname = new System.Windows.Forms.GroupBox();
            this.gbTeilnehmer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridKursUebersichtTeilnehmer)).BeginInit();
            this.gbButtons.SuspendLayout();
            this.gbKursname.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTeilnehmer
            // 
            this.gbTeilnehmer.Controls.Add(this.gridKursUebersichtTeilnehmer);
            this.gbTeilnehmer.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbTeilnehmer.Location = new System.Drawing.Point(0, 46);
            this.gbTeilnehmer.Name = "gbTeilnehmer";
            this.gbTeilnehmer.Size = new System.Drawing.Size(434, 343);
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
            this.gridKursUebersichtTeilnehmer.Size = new System.Drawing.Size(428, 324);
            this.gridKursUebersichtTeilnehmer.TabIndex = 0;
            this.gridKursUebersichtTeilnehmer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridKursUebersichtTeilnehmer_MouseDown);
            // 
            // tbBezeichnung
            // 
            this.tbBezeichnung.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBezeichnung.Enabled = false;
            this.tbBezeichnung.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBezeichnung.Location = new System.Drawing.Point(99, 12);
            this.tbBezeichnung.MaxLength = 100;
            this.tbBezeichnung.Name = "tbBezeichnung";
            this.tbBezeichnung.Size = new System.Drawing.Size(323, 26);
            this.tbBezeichnung.TabIndex = 2;
            // 
            // lbBezeichnung
            // 
            this.lbBezeichnung.AutoSize = true;
            this.lbBezeichnung.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBezeichnung.Location = new System.Drawing.Point(12, 16);
            this.lbBezeichnung.Name = "lbBezeichnung";
            this.lbBezeichnung.Size = new System.Drawing.Size(81, 18);
            this.lbBezeichnung.TabIndex = 1;
            this.lbBezeichnung.Text = "Kurs-Name:";
            // 
            // btLoeschen
            // 
            this.btLoeschen.BackgroundImage = global::PuG_Verwaltungssoftware.Properties.Resources.pug_delete_groß;
            this.btLoeschen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btLoeschen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLoeschen.Location = new System.Drawing.Point(67, 10);
            this.btLoeschen.Name = "btLoeschen";
            this.btLoeschen.Size = new System.Drawing.Size(55, 55);
            this.btLoeschen.TabIndex = 25;
            this.btLoeschen.UseVisualStyleBackColor = true;
            this.btLoeschen.Click += new System.EventHandler(this.btLoeschen_Click);
            // 
            // btKursUebersichtNeu
            // 
            this.btKursUebersichtNeu.BackgroundImage = global::PuG_Verwaltungssoftware.Properties.Resources.pug_add_groß;
            this.btKursUebersichtNeu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btKursUebersichtNeu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btKursUebersichtNeu.Location = new System.Drawing.Point(373, 10);
            this.btKursUebersichtNeu.Name = "btKursUebersichtNeu";
            this.btKursUebersichtNeu.Size = new System.Drawing.Size(55, 55);
            this.btKursUebersichtNeu.TabIndex = 24;
            this.btKursUebersichtNeu.UseVisualStyleBackColor = true;
            this.btKursUebersichtNeu.Click += new System.EventHandler(this.btKursUebersichtNeu_Click);
            // 
            // btSchliessen
            // 
            this.btSchliessen.BackgroundImage = global::PuG_Verwaltungssoftware.Properties.Resources.pug_close_groß;
            this.btSchliessen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btSchliessen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSchliessen.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btSchliessen.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSchliessen.Location = new System.Drawing.Point(6, 10);
            this.btSchliessen.Name = "btSchliessen";
            this.btSchliessen.Size = new System.Drawing.Size(55, 55);
            this.btSchliessen.TabIndex = 23;
            this.btSchliessen.UseVisualStyleBackColor = true;
            this.btSchliessen.Click += new System.EventHandler(this.btSchliessen_Click);
            // 
            // gbButtons
            // 
            this.gbButtons.Controls.Add(this.btKursUebersichtNeu);
            this.gbButtons.Controls.Add(this.btLoeschen);
            this.gbButtons.Controls.Add(this.btSchliessen);
            this.gbButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbButtons.Location = new System.Drawing.Point(0, 395);
            this.gbButtons.Name = "gbButtons";
            this.gbButtons.Size = new System.Drawing.Size(434, 71);
            this.gbButtons.TabIndex = 0;
            this.gbButtons.TabStop = false;
            // 
            // gbKursname
            // 
            this.gbKursname.Controls.Add(this.tbBezeichnung);
            this.gbKursname.Controls.Add(this.lbBezeichnung);
            this.gbKursname.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbKursname.Location = new System.Drawing.Point(0, 0);
            this.gbKursname.Name = "gbKursname";
            this.gbKursname.Size = new System.Drawing.Size(434, 46);
            this.gbKursname.TabIndex = 1;
            this.gbKursname.TabStop = false;
            // 
            // winKursUebersicht
            // 
            this.AcceptButton = this.btKursUebersichtNeu;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btSchliessen;
            this.ClientSize = new System.Drawing.Size(434, 466);
            this.Controls.Add(this.gbButtons);
            this.Controls.Add(this.gbTeilnehmer);
            this.Controls.Add(this.gbKursname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "winKursUebersicht";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kurs Übersicht";
            this.TopMost = true;
            this.gbTeilnehmer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridKursUebersichtTeilnehmer)).EndInit();
            this.gbButtons.ResumeLayout(false);
            this.gbKursname.ResumeLayout(false);
            this.gbKursname.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbBezeichnung;
        private System.Windows.Forms.TextBox tbBezeichnung;
        private System.Windows.Forms.GroupBox gbTeilnehmer;
        private System.Windows.Forms.DataGridView gridKursUebersichtTeilnehmer;
        private System.Windows.Forms.Button btSchliessen;
        private System.Windows.Forms.Button btKursUebersichtNeu;
        private System.Windows.Forms.Button btLoeschen;
        private System.Windows.Forms.GroupBox gbButtons;
        private System.Windows.Forms.GroupBox gbKursname;
    }
}