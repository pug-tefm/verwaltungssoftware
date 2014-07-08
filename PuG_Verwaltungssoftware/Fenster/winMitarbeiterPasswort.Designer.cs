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
            System.Windows.Forms.GroupBox gbButtons;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(winMitarbeiterPasswort));
            this.btSchliessen = new System.Windows.Forms.Button();
            this.btSpeichern = new System.Windows.Forms.Button();
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
            gbButtons = new System.Windows.Forms.GroupBox();
            gbButtons.SuspendLayout();
            this.panelChef.SuspendLayout();
            this.panelMitarbeiter.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbButtons
            // 
            gbButtons.Controls.Add(this.btSchliessen);
            gbButtons.Controls.Add(this.btSpeichern);
            gbButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            gbButtons.Location = new System.Drawing.Point(0, 160);
            gbButtons.Name = "gbButtons";
            gbButtons.Size = new System.Drawing.Size(450, 71);
            gbButtons.TabIndex = 2;
            gbButtons.TabStop = false;
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
            this.btSchliessen.TabIndex = 1;
            this.btSchliessen.UseVisualStyleBackColor = true;
            this.btSchliessen.Click += new System.EventHandler(this.btSchliessen_Click);
            // 
            // btSpeichern
            // 
            this.btSpeichern.BackgroundImage = global::PuG_Verwaltungssoftware.Properties.Resources.pug_save_groß;
            this.btSpeichern.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btSpeichern.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSpeichern.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSpeichern.Location = new System.Drawing.Point(389, 10);
            this.btSpeichern.Name = "btSpeichern";
            this.btSpeichern.Size = new System.Drawing.Size(55, 55);
            this.btSpeichern.TabIndex = 0;
            this.btSpeichern.UseVisualStyleBackColor = true;
            this.btSpeichern.Click += new System.EventHandler(this.btAendern_Click);
            // 
            // panelChef
            // 
            this.panelChef.Controls.Add(this.tbInitPw);
            this.panelChef.Controls.Add(this.lbInitPw);
            this.panelChef.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChef.Location = new System.Drawing.Point(0, 0);
            this.panelChef.Name = "panelChef";
            this.panelChef.Size = new System.Drawing.Size(450, 160);
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
            this.panelMitarbeiter.Size = new System.Drawing.Size(450, 164);
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
            // winMitarbeiterPasswort
            // 
            this.AcceptButton = this.btSpeichern;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btSchliessen;
            this.ClientSize = new System.Drawing.Size(450, 231);
            this.Controls.Add(this.panelChef);
            this.Controls.Add(this.panelMitarbeiter);
            this.Controls.Add(gbButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(465, 255);
            this.Name = "winMitarbeiterPasswort";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Passwort ändern";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.winMitarbeiterPasswort_Load);
            gbButtons.ResumeLayout(false);
            this.panelChef.ResumeLayout(false);
            this.panelChef.PerformLayout();
            this.panelMitarbeiter.ResumeLayout(false);
            this.panelMitarbeiter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelChef;
        private System.Windows.Forms.Panel panelMitarbeiter;
        private System.Windows.Forms.Label lbInitPw;
        private System.Windows.Forms.Button btSpeichern;
        private System.Windows.Forms.TextBox tbInitPw;
        private System.Windows.Forms.TextBox tbNeuesPw2;
        private System.Windows.Forms.Label lbNeuesPw2;
        private System.Windows.Forms.TextBox tbNeuesPw1;
        private System.Windows.Forms.Label lbNeuesPw1;
        private System.Windows.Forms.TextBox tbAltesPw;
        private System.Windows.Forms.Label lbAltesPw;
        private System.Windows.Forms.Button btSchliessen;
    }
}