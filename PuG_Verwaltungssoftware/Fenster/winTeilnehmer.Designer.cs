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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gridTeilnehmerHinzufuegen = new System.Windows.Forms.DataGridView();
            this.btHinzufuegen = new System.Windows.Forms.Button();
            this.btSchliessen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTeilnehmerHinzufuegen)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.gridTeilnehmerHinzufuegen);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btHinzufuegen);
            this.splitContainer1.Panel2.Controls.Add(this.btSchliessen);
            this.splitContainer1.Size = new System.Drawing.Size(334, 312);
            this.splitContainer1.SplitterDistance = 260;
            this.splitContainer1.TabIndex = 0;
            // 
            // gridTeilnehmerHinzufuegen
            // 
            this.gridTeilnehmerHinzufuegen.AllowUserToAddRows = false;
            this.gridTeilnehmerHinzufuegen.AllowUserToDeleteRows = false;
            this.gridTeilnehmerHinzufuegen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTeilnehmerHinzufuegen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridTeilnehmerHinzufuegen.Location = new System.Drawing.Point(0, 0);
            this.gridTeilnehmerHinzufuegen.Name = "gridTeilnehmerHinzufuegen";
            this.gridTeilnehmerHinzufuegen.ReadOnly = true;
            this.gridTeilnehmerHinzufuegen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridTeilnehmerHinzufuegen.Size = new System.Drawing.Size(334, 260);
            this.gridTeilnehmerHinzufuegen.TabIndex = 0;
            this.gridTeilnehmerHinzufuegen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridTeilnehmerHinzufuegen_KeyDown);
            this.gridTeilnehmerHinzufuegen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridTeilnehmerHinzufuegen_MouseDown);
            // 
            // btHinzufuegen
            // 
            this.btHinzufuegen.Dock = System.Windows.Forms.DockStyle.Left;
            this.btHinzufuegen.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHinzufuegen.Location = new System.Drawing.Point(0, 0);
            this.btHinzufuegen.Name = "btHinzufuegen";
            this.btHinzufuegen.Size = new System.Drawing.Size(105, 48);
            this.btHinzufuegen.TabIndex = 24;
            this.btHinzufuegen.Text = "Hinzufügen";
            this.btHinzufuegen.UseVisualStyleBackColor = true;
            this.btHinzufuegen.Click += new System.EventHandler(this.btHinzufuegen_Click);
            // 
            // btSchliessen
            // 
            this.btSchliessen.Dock = System.Windows.Forms.DockStyle.Right;
            this.btSchliessen.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSchliessen.Location = new System.Drawing.Point(229, 0);
            this.btSchliessen.Name = "btSchliessen";
            this.btSchliessen.Size = new System.Drawing.Size(105, 48);
            this.btSchliessen.TabIndex = 23;
            this.btSchliessen.Text = "Schließen";
            this.btSchliessen.UseVisualStyleBackColor = true;
            this.btSchliessen.Click += new System.EventHandler(this.btSchliessen_Click);
            // 
            // winTeilnehmer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 312);
            this.Controls.Add(this.splitContainer1);
            this.MaximumSize = new System.Drawing.Size(350, 350);
            this.MinimumSize = new System.Drawing.Size(350, 350);
            this.Name = "winTeilnehmer";
            this.Text = "winTeilnehmer";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridTeilnehmerHinzufuegen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView gridTeilnehmerHinzufuegen;
        private System.Windows.Forms.Button btSchliessen;
        private System.Windows.Forms.Button btHinzufuegen;
    }
}