namespace PuG_Verwaltungssoftware
{
    partial class winMitarbeiterPasswort
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(winMitarbeiterPasswort));
            this.panelChef = new System.Windows.Forms.Panel();
            this.tbInitPw = new System.Windows.Forms.TextBox();
            this.lbInitPw = new System.Windows.Forms.Label();
            this.panelMitarbeiter = new System.Windows.Forms.Panel();
            this.tbNeuesPw2 = new System.Windows.Forms.TextBox();
            this.lbNeuesPw2 = new System.Windows.Forms.Label();
            this.tbNeuesPw1 = new System.Windows.Forms.TextBox();
            this.lbNeuesPw1 = new System.Windows.Forms.Label();
            this.tbAltesPw = new System.Windows.Forms.TextBox();
            this.lbAltesPw = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btSchliessen = new System.Windows.Forms.Button();
            this.btAendern = new System.Windows.Forms.Button();
            this.panelChef.SuspendLayout();
            this.panelMitarbeiter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelChef
            // 
            this.panelChef.Controls.Add(this.tbInitPw);
            this.panelChef.Controls.Add(this.lbInitPw);
            this.panelChef.Location = new System.Drawing.Point(0, 0);
            this.panelChef.Name = "panelChef";
            this.panelChef.Size = new System.Drawing.Size(450, 169);
            this.panelChef.TabIndex = 0;
            // 
            // tbInitPw
            // 
            this.tbInitPw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbInitPw.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInitPw.Location = new System.Drawing.Point(165, 67);
            this.tbInitPw.MaxLength = 100;
            this.tbInitPw.Name = "tbInitPw";
            this.tbInitPw.Size = new System.Drawing.Size(273, 26);
            this.tbInitPw.TabIndex = 1;
            // 
            // lbInitPw
            // 
            this.lbInitPw.AutoSize = true;
            this.lbInitPw.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInitPw.Location = new System.Drawing.Point(12, 70);
            this.lbInitPw.Name = "lbInitPw";
            this.lbInitPw.Size = new System.Drawing.Size(146, 18);
            this.lbInitPw.TabIndex = 0;
            this.lbInitPw.Text = "Neues Initialpasswort:";
            // 
            // panelMitarbeiter
            // 
            this.panelMitarbeiter.Controls.Add(this.tbNeuesPw2);
            this.panelMitarbeiter.Controls.Add(this.lbNeuesPw2);
            this.panelMitarbeiter.Controls.Add(this.tbNeuesPw1);
            this.panelMitarbeiter.Controls.Add(this.lbNeuesPw1);
            this.panelMitarbeiter.Controls.Add(this.tbAltesPw);
            this.panelMitarbeiter.Controls.Add(this.lbAltesPw);
            this.panelMitarbeiter.Location = new System.Drawing.Point(0, 0);
            this.panelMitarbeiter.Name = "panelMitarbeiter";
            this.panelMitarbeiter.Size = new System.Drawing.Size(450, 169);
            this.panelMitarbeiter.TabIndex = 0;
            // 
            // tbNeuesPw2
            // 
            this.tbNeuesPw2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNeuesPw2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNeuesPw2.Location = new System.Drawing.Point(165, 102);
            this.tbNeuesPw2.MaxLength = 100;
            this.tbNeuesPw2.Name = "tbNeuesPw2";
            this.tbNeuesPw2.PasswordChar = '*';
            this.tbNeuesPw2.Size = new System.Drawing.Size(273, 26);
            this.tbNeuesPw2.TabIndex = 7;
            // 
            // lbNeuesPw2
            // 
            this.lbNeuesPw2.AutoSize = true;
            this.lbNeuesPw2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNeuesPw2.Location = new System.Drawing.Point(12, 105);
            this.lbNeuesPw2.Name = "lbNeuesPw2";
            this.lbNeuesPw2.Size = new System.Drawing.Size(136, 18);
            this.lbNeuesPw2.TabIndex = 6;
            this.lbNeuesPw2.Text = "Passwort bestätigen:";
            // 
            // tbNeuesPw1
            // 
            this.tbNeuesPw1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNeuesPw1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNeuesPw1.Location = new System.Drawing.Point(165, 72);
            this.tbNeuesPw1.MaxLength = 100;
            this.tbNeuesPw1.Name = "tbNeuesPw1";
            this.tbNeuesPw1.PasswordChar = '*';
            this.tbNeuesPw1.Size = new System.Drawing.Size(273, 26);
            this.tbNeuesPw1.TabIndex = 5;
            // 
            // lbNeuesPw1
            // 
            this.lbNeuesPw1.AutoSize = true;
            this.lbNeuesPw1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNeuesPw1.Location = new System.Drawing.Point(12, 75);
            this.lbNeuesPw1.Name = "lbNeuesPw1";
            this.lbNeuesPw1.Size = new System.Drawing.Size(111, 18);
            this.lbNeuesPw1.TabIndex = 4;
            this.lbNeuesPw1.Text = "Neues Passwort:";
            // 
            // tbAltesPw
            // 
            this.tbAltesPw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAltesPw.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAltesPw.Location = new System.Drawing.Point(165, 16);
            this.tbAltesPw.MaxLength = 100;
            this.tbAltesPw.Name = "tbAltesPw";
            this.tbAltesPw.PasswordChar = '*';
            this.tbAltesPw.Size = new System.Drawing.Size(273, 26);
            this.tbAltesPw.TabIndex = 3;
            // 
            // lbAltesPw
            // 
            this.lbAltesPw.AutoSize = true;
            this.lbAltesPw.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAltesPw.Location = new System.Drawing.Point(12, 19);
            this.lbAltesPw.Name = "lbAltesPw";
            this.lbAltesPw.Size = new System.Drawing.Size(103, 18);
            this.lbAltesPw.TabIndex = 2;
            this.lbAltesPw.Text = "Altes Passwort:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panelChef);
            this.splitContainer1.Panel1.Controls.Add(this.panelMitarbeiter);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btSchliessen);
            this.splitContainer1.Panel2.Controls.Add(this.btAendern);
            this.splitContainer1.Size = new System.Drawing.Size(450, 217);
            this.splitContainer1.SplitterDistance = 169;
            this.splitContainer1.TabIndex = 0;
            // 
            // btSchliessen
            // 
            this.btSchliessen.Dock = System.Windows.Forms.DockStyle.Right;
            this.btSchliessen.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSchliessen.Location = new System.Drawing.Point(333, 0);
            this.btSchliessen.Name = "btSchliessen";
            this.btSchliessen.Size = new System.Drawing.Size(117, 44);
            this.btSchliessen.TabIndex = 1;
            this.btSchliessen.Text = "Schließen";
            this.btSchliessen.UseVisualStyleBackColor = true;
            this.btSchliessen.Click += new System.EventHandler(this.btSchliessen_Click);
            // 
            // btAendern
            // 
            this.btAendern.Dock = System.Windows.Forms.DockStyle.Left;
            this.btAendern.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAendern.Location = new System.Drawing.Point(0, 0);
            this.btAendern.Name = "btAendern";
            this.btAendern.Size = new System.Drawing.Size(117, 44);
            this.btAendern.TabIndex = 0;
            this.btAendern.Text = "Speichern";
            this.btAendern.UseVisualStyleBackColor = true;
            this.btAendern.Click += new System.EventHandler(this.btAendern_Click);
            // 
            // winMitarbeiterPasswort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 217);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(465, 255);
            this.Name = "winMitarbeiterPasswort";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Passwort ändern";
            this.Load += new System.EventHandler(this.winMitarbeiterPasswort_Load);
            this.panelChef.ResumeLayout(false);
            this.panelChef.PerformLayout();
            this.panelMitarbeiter.ResumeLayout(false);
            this.panelMitarbeiter.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelChef;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panelMitarbeiter;
        private System.Windows.Forms.Label lbInitPw;
        private System.Windows.Forms.Button btSchliessen;
        private System.Windows.Forms.Button btAendern;
        private System.Windows.Forms.TextBox tbInitPw;
        private System.Windows.Forms.TextBox tbNeuesPw2;
        private System.Windows.Forms.Label lbNeuesPw2;
        private System.Windows.Forms.TextBox tbNeuesPw1;
        private System.Windows.Forms.Label lbNeuesPw1;
        private System.Windows.Forms.TextBox tbAltesPw;
        private System.Windows.Forms.Label lbAltesPw;
    }
}