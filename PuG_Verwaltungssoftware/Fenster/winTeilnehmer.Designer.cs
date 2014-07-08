namespace PuG_Verwaltungssoftware
{
    partial class winTeilnehmer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(winTeilnehmer));
            this.gridTeilnehmerHinzufuegen = new System.Windows.Forms.DataGridView();
            this.btHinzufuegen = new System.Windows.Forms.Button();
            this.btSchliessen = new System.Windows.Forms.Button();
            this.gbButtons = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridTeilnehmerHinzufuegen)).BeginInit();
            this.gbButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridTeilnehmerHinzufuegen
            // 
            this.gridTeilnehmerHinzufuegen.AllowUserToAddRows = false;
            this.gridTeilnehmerHinzufuegen.AllowUserToDeleteRows = false;
            this.gridTeilnehmerHinzufuegen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTeilnehmerHinzufuegen.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridTeilnehmerHinzufuegen.Location = new System.Drawing.Point(0, 0);
            this.gridTeilnehmerHinzufuegen.Name = "gridTeilnehmerHinzufuegen";
            this.gridTeilnehmerHinzufuegen.ReadOnly = true;
            this.gridTeilnehmerHinzufuegen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridTeilnehmerHinzufuegen.Size = new System.Drawing.Size(334, 290);
            this.gridTeilnehmerHinzufuegen.TabIndex = 0;
            this.gridTeilnehmerHinzufuegen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridTeilnehmerHinzufuegen_KeyDown);
            this.gridTeilnehmerHinzufuegen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridTeilnehmerHinzufuegen_MouseDown);
            // 
            // btHinzufuegen
            // 
            this.btHinzufuegen.BackgroundImage = global::PuG_Verwaltungssoftware.Properties.Resources.pug_add_groß;
            this.btHinzufuegen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btHinzufuegen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btHinzufuegen.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHinzufuegen.Location = new System.Drawing.Point(273, 10);
            this.btHinzufuegen.Name = "btHinzufuegen";
            this.btHinzufuegen.Size = new System.Drawing.Size(55, 55);
            this.btHinzufuegen.TabIndex = 24;
            this.btHinzufuegen.UseVisualStyleBackColor = true;
            this.btHinzufuegen.Click += new System.EventHandler(this.btHinzufuegen_Click);
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
            this.gbButtons.Controls.Add(this.btHinzufuegen);
            this.gbButtons.Controls.Add(this.btSchliessen);
            this.gbButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbButtons.Location = new System.Drawing.Point(0, 295);
            this.gbButtons.Name = "gbButtons";
            this.gbButtons.Size = new System.Drawing.Size(334, 71);
            this.gbButtons.TabIndex = 25;
            this.gbButtons.TabStop = false;
            // 
            // winTeilnehmer
            // 
            this.AcceptButton = this.btHinzufuegen;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btSchliessen;
            this.ClientSize = new System.Drawing.Size(334, 366);
            this.Controls.Add(this.gridTeilnehmerHinzufuegen);
            this.Controls.Add(this.gbButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(350, 400);
            this.MinimumSize = new System.Drawing.Size(350, 400);
            this.Name = "winTeilnehmer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teilnehmer hinzufügen";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.gridTeilnehmerHinzufuegen)).EndInit();
            this.gbButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridTeilnehmerHinzufuegen;
        private System.Windows.Forms.Button btSchliessen;
        private System.Windows.Forms.Button btHinzufuegen;
        private System.Windows.Forms.GroupBox gbButtons;
    }
}