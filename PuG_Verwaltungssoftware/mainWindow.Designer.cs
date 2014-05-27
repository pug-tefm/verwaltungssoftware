namespace PuG_Verwaltungssoftware
{
    partial class mainWindow
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.neuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mitarbeiterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mitgliederToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.löschenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mitarbeiterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mitgliederToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kursToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sperrenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mitgliederToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.miBeenden = new System.Windows.Forms.ToolStripMenuItem();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rückgängigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ausschneidenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kopierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.einfügenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.dateiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuToolStripMenuItem,
            this.löschenToolStripMenuItem,
            this.sperrenToolStripMenuItem,
            this.toolStripSeparator1,
            this.miBeenden});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(46, 20);
            this.toolStripMenuItem1.Text = "Datei";
            // 
            // neuToolStripMenuItem
            // 
            this.neuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitarbeiterToolStripMenuItem,
            this.mitgliederToolStripMenuItem,
            this.kursToolStripMenuItem});
            this.neuToolStripMenuItem.Name = "neuToolStripMenuItem";
            this.neuToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.neuToolStripMenuItem.Text = "Neu";
            // 
            // mitarbeiterToolStripMenuItem
            // 
            this.mitarbeiterToolStripMenuItem.Name = "mitarbeiterToolStripMenuItem";
            this.mitarbeiterToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.mitarbeiterToolStripMenuItem.Text = "Mitarbeiter";
            this.mitarbeiterToolStripMenuItem.Click += new System.EventHandler(this.mitarbeiterToolStripMenuItem_Click);
            // 
            // mitgliederToolStripMenuItem
            // 
            this.mitgliederToolStripMenuItem.Name = "mitgliederToolStripMenuItem";
            this.mitgliederToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.mitgliederToolStripMenuItem.Text = "Mitglieder";
            // 
            // kursToolStripMenuItem
            // 
            this.kursToolStripMenuItem.Name = "kursToolStripMenuItem";
            this.kursToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.kursToolStripMenuItem.Text = "Kurs";
            // 
            // löschenToolStripMenuItem
            // 
            this.löschenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitarbeiterToolStripMenuItem1,
            this.mitgliederToolStripMenuItem1,
            this.kursToolStripMenuItem1});
            this.löschenToolStripMenuItem.Name = "löschenToolStripMenuItem";
            this.löschenToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.löschenToolStripMenuItem.Text = "Löschen";
            // 
            // mitarbeiterToolStripMenuItem1
            // 
            this.mitarbeiterToolStripMenuItem1.Name = "mitarbeiterToolStripMenuItem1";
            this.mitarbeiterToolStripMenuItem1.Size = new System.Drawing.Size(132, 22);
            this.mitarbeiterToolStripMenuItem1.Text = "Mitarbeiter";
            // 
            // mitgliederToolStripMenuItem1
            // 
            this.mitgliederToolStripMenuItem1.Name = "mitgliederToolStripMenuItem1";
            this.mitgliederToolStripMenuItem1.Size = new System.Drawing.Size(132, 22);
            this.mitgliederToolStripMenuItem1.Text = "Mitglieder";
            // 
            // kursToolStripMenuItem1
            // 
            this.kursToolStripMenuItem1.Name = "kursToolStripMenuItem1";
            this.kursToolStripMenuItem1.Size = new System.Drawing.Size(132, 22);
            this.kursToolStripMenuItem1.Text = "Kurs";
            // 
            // sperrenToolStripMenuItem
            // 
            this.sperrenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitgliederToolStripMenuItem2});
            this.sperrenToolStripMenuItem.Name = "sperrenToolStripMenuItem";
            this.sperrenToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.sperrenToolStripMenuItem.Text = "Sperren";
            // 
            // mitgliederToolStripMenuItem2
            // 
            this.mitgliederToolStripMenuItem2.Name = "mitgliederToolStripMenuItem2";
            this.mitgliederToolStripMenuItem2.Size = new System.Drawing.Size(128, 22);
            this.mitgliederToolStripMenuItem2.Text = "Mitglieder";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(117, 6);
            // 
            // miBeenden
            // 
            this.miBeenden.Name = "miBeenden";
            this.miBeenden.Size = new System.Drawing.Size(120, 22);
            this.miBeenden.Text = "Beenden";
            this.miBeenden.Click += new System.EventHandler(this.miBeenden_Click);
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rückgängigToolStripMenuItem,
            this.ausschneidenToolStripMenuItem,
            this.kopierenToolStripMenuItem,
            this.einfügenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.dateiToolStripMenuItem.Text = "Bearbeiten";
            // 
            // rückgängigToolStripMenuItem
            // 
            this.rückgängigToolStripMenuItem.Name = "rückgängigToolStripMenuItem";
            this.rückgängigToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.rückgängigToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.rückgängigToolStripMenuItem.Text = "Rückgängig";
            // 
            // ausschneidenToolStripMenuItem
            // 
            this.ausschneidenToolStripMenuItem.Name = "ausschneidenToolStripMenuItem";
            this.ausschneidenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.ausschneidenToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.ausschneidenToolStripMenuItem.Text = "Ausschneiden";
            // 
            // kopierenToolStripMenuItem
            // 
            this.kopierenToolStripMenuItem.Name = "kopierenToolStripMenuItem";
            this.kopierenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.kopierenToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.kopierenToolStripMenuItem.Text = "Kopieren";
            // 
            // einfügenToolStripMenuItem
            // 
            this.einfügenToolStripMenuItem.Name = "einfügenToolStripMenuItem";
            this.einfügenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.einfügenToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.einfügenToolStripMenuItem.Text = "Einfügen";
            // 
            // mainTabControl
            // 
            this.mainTabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.mainTabControl.Controls.Add(this.tabPage1);
            this.mainTabControl.Controls.Add(this.tabPage2);
            this.mainTabControl.Controls.Add(this.tabPage3);
            this.mainTabControl.Controls.Add(this.tabPage4);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.mainTabControl.ItemSize = new System.Drawing.Size(80, 110);
            this.mainTabControl.Location = new System.Drawing.Point(0, 24);
            this.mainTabControl.Multiline = true;
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(584, 388);
            this.mainTabControl.TabIndex = 1;
            this.mainTabControl.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.mainTabControl_DrawItem);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Silver;
            this.tabPage1.Location = new System.Drawing.Point(114, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(442, 365);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Silver;
            this.tabPage2.Location = new System.Drawing.Point(114, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(466, 380);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mitarbeiter";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Silver;
            this.tabPage3.Location = new System.Drawing.Point(114, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(442, 365);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Mitglieder";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Silver;
            this.tabPage4.Location = new System.Drawing.Point(114, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(442, 365);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Kurse";
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 412);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "mainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "P&G Verwaltungssoftware";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.mainTabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem neuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mitarbeiterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mitgliederToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem löschenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mitarbeiterToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mitgliederToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kursToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sperrenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mitgliederToolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem miBeenden;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rückgängigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ausschneidenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kopierenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem einfügenToolStripMenuItem;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
    }
}

