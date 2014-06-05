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
            this.tabPageHome = new System.Windows.Forms.TabPage();
            this.tabPageMitarbeiter = new System.Windows.Forms.TabPage();
            this.scMitarbeiter = new System.Windows.Forms.SplitContainer();
            this.gridMitarbeiter = new System.Windows.Forms.DataGridView();
            this.btMaLoeschen = new System.Windows.Forms.Button();
            this.btMaOeffnen = new System.Windows.Forms.Button();
            this.btMaNeu = new System.Windows.Forms.Button();
            this.tabPageMitglieder = new System.Windows.Forms.TabPage();
            this.tabPageKurse = new System.Windows.Forms.TabPage();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.lbLoginMessage = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btExit = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.btLogin = new System.Windows.Forms.Button();
            this.scMitglieder = new System.Windows.Forms.SplitContainer();
            this.gridMitglieder = new System.Windows.Forms.DataGridView();
            this.btMgNeu = new System.Windows.Forms.Button();
            this.btMgOeffnen = new System.Windows.Forms.Button();
            this.btMgLoeschen = new System.Windows.Forms.Button();
            this.scKurse = new System.Windows.Forms.SplitContainer();
            this.gridKurse = new System.Windows.Forms.DataGridView();
            this.btKursLoeschen = new System.Windows.Forms.Button();
            this.btKursOeffnen = new System.Windows.Forms.Button();
            this.btKursNeu = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.tabPageMitarbeiter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMitarbeiter)).BeginInit();
            this.scMitarbeiter.Panel1.SuspendLayout();
            this.scMitarbeiter.Panel2.SuspendLayout();
            this.scMitarbeiter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMitarbeiter)).BeginInit();
            this.tabPageMitglieder.SuspendLayout();
            this.tabPageKurse.SuspendLayout();
            this.loginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scMitglieder)).BeginInit();
            this.scMitglieder.Panel1.SuspendLayout();
            this.scMitglieder.Panel2.SuspendLayout();
            this.scMitglieder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMitglieder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scKurse)).BeginInit();
            this.scKurse.Panel1.SuspendLayout();
            this.scKurse.Panel2.SuspendLayout();
            this.scKurse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridKurse)).BeginInit();
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
            this.mainTabControl.Controls.Add(this.tabPageHome);
            this.mainTabControl.Controls.Add(this.tabPageMitarbeiter);
            this.mainTabControl.Controls.Add(this.tabPageMitglieder);
            this.mainTabControl.Controls.Add(this.tabPageKurse);
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
            // tabPageHome
            // 
            this.tabPageHome.BackColor = System.Drawing.Color.Silver;
            this.tabPageHome.Location = new System.Drawing.Point(114, 4);
            this.tabPageHome.Name = "tabPageHome";
            this.tabPageHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHome.Size = new System.Drawing.Size(466, 380);
            this.tabPageHome.TabIndex = 0;
            this.tabPageHome.Text = "Home";
            // 
            // tabPageMitarbeiter
            // 
            this.tabPageMitarbeiter.BackColor = System.Drawing.Color.Silver;
            this.tabPageMitarbeiter.Controls.Add(this.scMitarbeiter);
            this.tabPageMitarbeiter.Location = new System.Drawing.Point(114, 4);
            this.tabPageMitarbeiter.Name = "tabPageMitarbeiter";
            this.tabPageMitarbeiter.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMitarbeiter.Size = new System.Drawing.Size(466, 380);
            this.tabPageMitarbeiter.TabIndex = 1;
            this.tabPageMitarbeiter.Text = "Mitarbeiter";
            this.tabPageMitarbeiter.Enter += new System.EventHandler(this.tabPageMitarbeiter_Enter);
            // 
            // scMitarbeiter
            // 
            this.scMitarbeiter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMitarbeiter.IsSplitterFixed = true;
            this.scMitarbeiter.Location = new System.Drawing.Point(3, 3);
            this.scMitarbeiter.Name = "scMitarbeiter";
            this.scMitarbeiter.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scMitarbeiter.Panel1
            // 
            this.scMitarbeiter.Panel1.Controls.Add(this.gridMitarbeiter);
            // 
            // scMitarbeiter.Panel2
            // 
            this.scMitarbeiter.Panel2.Controls.Add(this.btMaLoeschen);
            this.scMitarbeiter.Panel2.Controls.Add(this.btMaOeffnen);
            this.scMitarbeiter.Panel2.Controls.Add(this.btMaNeu);
            this.scMitarbeiter.Size = new System.Drawing.Size(460, 374);
            this.scMitarbeiter.SplitterDistance = 330;
            this.scMitarbeiter.TabIndex = 2;
            // 
            // gridMitarbeiter
            // 
            this.gridMitarbeiter.AllowUserToAddRows = false;
            this.gridMitarbeiter.AllowUserToDeleteRows = false;
            this.gridMitarbeiter.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridMitarbeiter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMitarbeiter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridMitarbeiter.Location = new System.Drawing.Point(0, 0);
            this.gridMitarbeiter.MultiSelect = false;
            this.gridMitarbeiter.Name = "gridMitarbeiter";
            this.gridMitarbeiter.ReadOnly = true;
            this.gridMitarbeiter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridMitarbeiter.Size = new System.Drawing.Size(460, 330);
            this.gridMitarbeiter.TabIndex = 0;
            this.gridMitarbeiter.SelectionChanged += new System.EventHandler(this.gridMitarbeiter_SelectionChanged);
            // 
            // btMaLoeschen
            // 
            this.btMaLoeschen.Dock = System.Windows.Forms.DockStyle.Left;
            this.btMaLoeschen.Location = new System.Drawing.Point(92, 0);
            this.btMaLoeschen.Name = "btMaLoeschen";
            this.btMaLoeschen.Size = new System.Drawing.Size(92, 40);
            this.btMaLoeschen.TabIndex = 3;
            this.btMaLoeschen.Text = "Löschen";
            this.btMaLoeschen.UseVisualStyleBackColor = true;
            this.btMaLoeschen.Click += new System.EventHandler(this.btMaLoeschen_Click);
            // 
            // btMaOeffnen
            // 
            this.btMaOeffnen.Dock = System.Windows.Forms.DockStyle.Right;
            this.btMaOeffnen.Location = new System.Drawing.Point(334, 0);
            this.btMaOeffnen.Name = "btMaOeffnen";
            this.btMaOeffnen.Size = new System.Drawing.Size(126, 40);
            this.btMaOeffnen.TabIndex = 2;
            this.btMaOeffnen.Text = "Öffnen";
            this.btMaOeffnen.UseVisualStyleBackColor = true;
            this.btMaOeffnen.Click += new System.EventHandler(this.btMaOeffnen_Click);
            // 
            // btMaNeu
            // 
            this.btMaNeu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btMaNeu.Location = new System.Drawing.Point(0, 0);
            this.btMaNeu.Name = "btMaNeu";
            this.btMaNeu.Size = new System.Drawing.Size(92, 40);
            this.btMaNeu.TabIndex = 1;
            this.btMaNeu.Text = "Neu";
            this.btMaNeu.UseVisualStyleBackColor = true;
            this.btMaNeu.Click += new System.EventHandler(this.btMaNeu_Click);
            // 
            // tabPageMitglieder
            // 
            this.tabPageMitglieder.BackColor = System.Drawing.Color.Silver;
            this.tabPageMitglieder.Controls.Add(this.scMitglieder);
            this.tabPageMitglieder.Location = new System.Drawing.Point(114, 4);
            this.tabPageMitglieder.Name = "tabPageMitglieder";
            this.tabPageMitglieder.Size = new System.Drawing.Size(466, 380);
            this.tabPageMitglieder.TabIndex = 2;
            this.tabPageMitglieder.Text = "Mitglieder";
            // 
            // tabPageKurse
            // 
            this.tabPageKurse.BackColor = System.Drawing.Color.Silver;
            this.tabPageKurse.Controls.Add(this.scKurse);
            this.tabPageKurse.Location = new System.Drawing.Point(114, 4);
            this.tabPageKurse.Name = "tabPageKurse";
            this.tabPageKurse.Size = new System.Drawing.Size(466, 380);
            this.tabPageKurse.TabIndex = 3;
            this.tabPageKurse.Text = "Kurse";
            this.tabPageKurse.Enter += new System.EventHandler(this.tabPageKurse_Enter);
            // 
            // loginPanel
            // 
            this.loginPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginPanel.Controls.Add(this.lbLoginMessage);
            this.loginPanel.Controls.Add(this.pictureBox1);
            this.loginPanel.Controls.Add(this.btExit);
            this.loginPanel.Controls.Add(this.tbPassword);
            this.loginPanel.Controls.Add(this.tbUsername);
            this.loginPanel.Controls.Add(this.btLogin);
            this.loginPanel.Location = new System.Drawing.Point(0, 0);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(583, 412);
            this.loginPanel.TabIndex = 2;
            // 
            // lbLoginMessage
            // 
            this.lbLoginMessage.AutoSize = true;
            this.lbLoginMessage.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoginMessage.ForeColor = System.Drawing.Color.Red;
            this.lbLoginMessage.Location = new System.Drawing.Point(119, 330);
            this.lbLoginMessage.Name = "lbLoginMessage";
            this.lbLoginMessage.Size = new System.Drawing.Size(0, 19);
            this.lbLoginMessage.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PuG_Verwaltungssoftware.Properties.Resources.pug_runner;
            this.pictureBox1.Location = new System.Drawing.Point(119, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(347, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(373, 275);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(93, 32);
            this.btExit.TabIndex = 3;
            this.btExit.Text = "Beenden";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(116, 239);
            this.tbPassword.MaxLength = 50;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(350, 26);
            this.tbPassword.TabIndex = 2;
            this.tbPassword.Text = "Passwort";
            this.tbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPassword.Enter += new System.EventHandler(this.tbPassword_Enter);
            this.tbPassword.Leave += new System.EventHandler(this.tbPassword_Leave);
            // 
            // tbUsername
            // 
            this.tbUsername.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.Location = new System.Drawing.Point(116, 203);
            this.tbUsername.MaxLength = 50;
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(350, 26);
            this.tbUsername.TabIndex = 1;
            this.tbUsername.Text = "Benutzername";
            this.tbUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbUsername.Enter += new System.EventHandler(this.tbUsername_Enter);
            this.tbUsername.Leave += new System.EventHandler(this.tbUsername_Leave);
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(116, 275);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(251, 32);
            this.btLogin.TabIndex = 0;
            this.btLogin.Text = "Anmelden";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // scMitglieder
            // 
            this.scMitglieder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMitglieder.Location = new System.Drawing.Point(0, 0);
            this.scMitglieder.Name = "scMitglieder";
            this.scMitglieder.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scMitglieder.Panel1
            // 
            this.scMitglieder.Panel1.Controls.Add(this.gridMitglieder);
            // 
            // scMitglieder.Panel2
            // 
            this.scMitglieder.Panel2.Controls.Add(this.btMgLoeschen);
            this.scMitglieder.Panel2.Controls.Add(this.btMgNeu);
            this.scMitglieder.Panel2.Controls.Add(this.btMgOeffnen);
            this.scMitglieder.Size = new System.Drawing.Size(466, 380);
            this.scMitglieder.SplitterDistance = 330;
            this.scMitglieder.TabIndex = 0;
            // 
            // gridMitglieder
            // 
            this.gridMitglieder.AllowUserToAddRows = false;
            this.gridMitglieder.AllowUserToDeleteRows = false;
            this.gridMitglieder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridMitglieder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMitglieder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridMitglieder.Location = new System.Drawing.Point(0, 0);
            this.gridMitglieder.MultiSelect = false;
            this.gridMitglieder.Name = "gridMitglieder";
            this.gridMitglieder.ReadOnly = true;
            this.gridMitglieder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridMitglieder.Size = new System.Drawing.Size(466, 330);
            this.gridMitglieder.TabIndex = 1;
            // 
            // btMgNeu
            // 
            this.btMgNeu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btMgNeu.Location = new System.Drawing.Point(0, 0);
            this.btMgNeu.Name = "btMgNeu";
            this.btMgNeu.Size = new System.Drawing.Size(92, 46);
            this.btMgNeu.TabIndex = 4;
            this.btMgNeu.Text = "Neu";
            this.btMgNeu.UseVisualStyleBackColor = true;
            // 
            // btMgOeffnen
            // 
            this.btMgOeffnen.Dock = System.Windows.Forms.DockStyle.Right;
            this.btMgOeffnen.Location = new System.Drawing.Point(340, 0);
            this.btMgOeffnen.Name = "btMgOeffnen";
            this.btMgOeffnen.Size = new System.Drawing.Size(126, 46);
            this.btMgOeffnen.TabIndex = 5;
            this.btMgOeffnen.Text = "Öffnen";
            this.btMgOeffnen.UseVisualStyleBackColor = true;
            // 
            // btMgLoeschen
            // 
            this.btMgLoeschen.Dock = System.Windows.Forms.DockStyle.Left;
            this.btMgLoeschen.Location = new System.Drawing.Point(92, 0);
            this.btMgLoeschen.Name = "btMgLoeschen";
            this.btMgLoeschen.Size = new System.Drawing.Size(92, 46);
            this.btMgLoeschen.TabIndex = 6;
            this.btMgLoeschen.Text = "Löschen";
            this.btMgLoeschen.UseVisualStyleBackColor = true;
            this.btMgLoeschen.Click += new System.EventHandler(this.btMgLoeschen_Click);
            // 
            // scKurse
            // 
            this.scKurse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scKurse.Location = new System.Drawing.Point(0, 0);
            this.scKurse.Name = "scKurse";
            this.scKurse.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scKurse.Panel1
            // 
            this.scKurse.Panel1.Controls.Add(this.gridKurse);
            // 
            // scKurse.Panel2
            // 
            this.scKurse.Panel2.Controls.Add(this.btKursLoeschen);
            this.scKurse.Panel2.Controls.Add(this.btKursNeu);
            this.scKurse.Panel2.Controls.Add(this.btKursOeffnen);
            this.scKurse.Size = new System.Drawing.Size(466, 380);
            this.scKurse.SplitterDistance = 330;
            this.scKurse.TabIndex = 0;
            // 
            // gridKurse
            // 
            this.gridKurse.AllowUserToAddRows = false;
            this.gridKurse.AllowUserToDeleteRows = false;
            this.gridKurse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridKurse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridKurse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridKurse.Location = new System.Drawing.Point(0, 0);
            this.gridKurse.MultiSelect = false;
            this.gridKurse.Name = "gridKurse";
            this.gridKurse.ReadOnly = true;
            this.gridKurse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridKurse.Size = new System.Drawing.Size(466, 330);
            this.gridKurse.TabIndex = 2;
            // 
            // btKursLoeschen
            // 
            this.btKursLoeschen.Dock = System.Windows.Forms.DockStyle.Left;
            this.btKursLoeschen.Location = new System.Drawing.Point(92, 0);
            this.btKursLoeschen.Name = "btKursLoeschen";
            this.btKursLoeschen.Size = new System.Drawing.Size(92, 46);
            this.btKursLoeschen.TabIndex = 7;
            this.btKursLoeschen.Text = "Löschen";
            this.btKursLoeschen.UseVisualStyleBackColor = true;
            this.btKursLoeschen.Click += new System.EventHandler(this.btKursLoeschen_Click);
            // 
            // btKursOeffnen
            // 
            this.btKursOeffnen.Dock = System.Windows.Forms.DockStyle.Right;
            this.btKursOeffnen.Location = new System.Drawing.Point(340, 0);
            this.btKursOeffnen.Name = "btKursOeffnen";
            this.btKursOeffnen.Size = new System.Drawing.Size(126, 46);
            this.btKursOeffnen.TabIndex = 8;
            this.btKursOeffnen.Text = "Öffnen";
            this.btKursOeffnen.UseVisualStyleBackColor = true;
            // 
            // btKursNeu
            // 
            this.btKursNeu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btKursNeu.Location = new System.Drawing.Point(0, 0);
            this.btKursNeu.Name = "btKursNeu";
            this.btKursNeu.Size = new System.Drawing.Size(92, 46);
            this.btKursNeu.TabIndex = 9;
            this.btKursNeu.Text = "Neu";
            this.btKursNeu.UseVisualStyleBackColor = true;
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 412);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(600, 450);
            this.Name = "mainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "P&G Verwaltungssoftware";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.mainTabControl.ResumeLayout(false);
            this.tabPageMitarbeiter.ResumeLayout(false);
            this.scMitarbeiter.Panel1.ResumeLayout(false);
            this.scMitarbeiter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMitarbeiter)).EndInit();
            this.scMitarbeiter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridMitarbeiter)).EndInit();
            this.tabPageMitglieder.ResumeLayout(false);
            this.tabPageKurse.ResumeLayout(false);
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.scMitglieder.Panel1.ResumeLayout(false);
            this.scMitglieder.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMitglieder)).EndInit();
            this.scMitglieder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridMitglieder)).EndInit();
            this.scKurse.Panel1.ResumeLayout(false);
            this.scKurse.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scKurse)).EndInit();
            this.scKurse.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridKurse)).EndInit();
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
        private System.Windows.Forms.TabPage tabPageHome;
        private System.Windows.Forms.TabPage tabPageMitarbeiter;
        private System.Windows.Forms.TabPage tabPageMitglieder;
        private System.Windows.Forms.TabPage tabPageKurse;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbLoginMessage;
        private System.Windows.Forms.Button btMaNeu;
        private System.Windows.Forms.DataGridView gridMitarbeiter;
        private System.Windows.Forms.SplitContainer scMitarbeiter;
        private System.Windows.Forms.Button btMaLoeschen;
        private System.Windows.Forms.Button btMaOeffnen;
        private System.Windows.Forms.SplitContainer scMitglieder;
        private System.Windows.Forms.DataGridView gridMitglieder;
        private System.Windows.Forms.Button btMgLoeschen;
        private System.Windows.Forms.Button btMgOeffnen;
        private System.Windows.Forms.Button btMgNeu;
        private System.Windows.Forms.SplitContainer scKurse;
        private System.Windows.Forms.DataGridView gridKurse;
        private System.Windows.Forms.Button btKursNeu;
        private System.Windows.Forms.Button btKursOeffnen;
        private System.Windows.Forms.Button btKursLoeschen;
    }
}

