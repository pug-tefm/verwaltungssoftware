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
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.tabPageHome = new System.Windows.Forms.TabPage();
            this.scHome = new System.Windows.Forms.SplitContainer();
            this.btAbmelden = new System.Windows.Forms.Button();
            this.lbAngemeldet = new System.Windows.Forms.Label();
            this.lbTimer = new System.Windows.Forms.Label();
            this.lbMitarbeiterName = new System.Windows.Forms.Label();
            this.lbWillkommen = new System.Windows.Forms.Label();
            this.newsTabControl = new System.Windows.Forms.TabControl();
            this.tabPageAktuell = new System.Windows.Forms.TabPage();
            this.lvNewsAktuell = new System.Windows.Forms.ListView();
            this.tabPageHeute = new System.Windows.Forms.TabPage();
            this.lvNewsHeute = new System.Windows.Forms.ListView();
            this.tabPageKommend = new System.Windows.Forms.TabPage();
            this.lvNewsKommend = new System.Windows.Forms.ListView();
            this.tabPageMitarbeiter = new System.Windows.Forms.TabPage();
            this.scMitarbeiter = new System.Windows.Forms.SplitContainer();
            this.gridMitarbeiter = new System.Windows.Forms.DataGridView();
            this.tbMitarbeiterSuchen = new System.Windows.Forms.TextBox();
            this.ddlMitarbeiterSuchen = new System.Windows.Forms.ComboBox();
            this.btMaLoeschen = new System.Windows.Forms.Button();
            this.btMaOeffnen = new System.Windows.Forms.Button();
            this.btMaNeu = new System.Windows.Forms.Button();
            this.tabPageMitglieder = new System.Windows.Forms.TabPage();
            this.scMitglieder = new System.Windows.Forms.SplitContainer();
            this.gridMitglieder = new System.Windows.Forms.DataGridView();
            this.tbMitgliederSuchen = new System.Windows.Forms.TextBox();
            this.ddlMitgliederSuchen = new System.Windows.Forms.ComboBox();
            this.btMgLoeschen = new System.Windows.Forms.Button();
            this.btMgNeu = new System.Windows.Forms.Button();
            this.btMgOeffnen = new System.Windows.Forms.Button();
            this.tabPageKurse = new System.Windows.Forms.TabPage();
            this.scKurse = new System.Windows.Forms.SplitContainer();
            this.gridKurse = new System.Windows.Forms.DataGridView();
            this.tbKursSuchen = new System.Windows.Forms.TextBox();
            this.ddlKursSuchen = new System.Windows.Forms.ComboBox();
            this.btKursLoeschen = new System.Windows.Forms.Button();
            this.btKursNeu = new System.Windows.Forms.Button();
            this.btKursOeffnen = new System.Windows.Forms.Button();
            this.tabPageKursUebersicht = new System.Windows.Forms.TabPage();
            this.scKursUebersicht = new System.Windows.Forms.SplitContainer();
            this.gridKursUebersicht = new System.Windows.Forms.DataGridView();
            this.btKursUebersichtOeffnen = new System.Windows.Forms.Button();
            this.tbKursUebersichtSuchen = new System.Windows.Forms.TextBox();
            this.ddlKursUebersichtSuchen = new System.Windows.Forms.ComboBox();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.lbLoginMessage = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btExit = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.btLogin = new System.Windows.Forms.Button();
            this.mainTabControl.SuspendLayout();
            this.tabPageHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scHome)).BeginInit();
            this.scHome.Panel1.SuspendLayout();
            this.scHome.Panel2.SuspendLayout();
            this.scHome.SuspendLayout();
            this.newsTabControl.SuspendLayout();
            this.tabPageAktuell.SuspendLayout();
            this.tabPageHeute.SuspendLayout();
            this.tabPageKommend.SuspendLayout();
            this.tabPageMitarbeiter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMitarbeiter)).BeginInit();
            this.scMitarbeiter.Panel1.SuspendLayout();
            this.scMitarbeiter.Panel2.SuspendLayout();
            this.scMitarbeiter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMitarbeiter)).BeginInit();
            this.tabPageMitglieder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMitglieder)).BeginInit();
            this.scMitglieder.Panel1.SuspendLayout();
            this.scMitglieder.Panel2.SuspendLayout();
            this.scMitglieder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMitglieder)).BeginInit();
            this.tabPageKurse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scKurse)).BeginInit();
            this.scKurse.Panel1.SuspendLayout();
            this.scKurse.Panel2.SuspendLayout();
            this.scKurse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridKurse)).BeginInit();
            this.tabPageKursUebersicht.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scKursUebersicht)).BeginInit();
            this.scKursUebersicht.Panel1.SuspendLayout();
            this.scKursUebersicht.Panel2.SuspendLayout();
            this.scKursUebersicht.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridKursUebersicht)).BeginInit();
            this.loginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.mainTabControl.Controls.Add(this.tabPageHome);
            this.mainTabControl.Controls.Add(this.tabPageMitarbeiter);
            this.mainTabControl.Controls.Add(this.tabPageMitglieder);
            this.mainTabControl.Controls.Add(this.tabPageKurse);
            this.mainTabControl.Controls.Add(this.tabPageKursUebersicht);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.mainTabControl.HotTrack = true;
            this.mainTabControl.ItemSize = new System.Drawing.Size(80, 110);
            this.mainTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainTabControl.Multiline = true;
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(734, 462);
            this.mainTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.mainTabControl.TabIndex = 1;
            this.mainTabControl.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.mainTabControl_DrawItem);
            // 
            // tabPageHome
            // 
            this.tabPageHome.BackColor = System.Drawing.Color.White;
            this.tabPageHome.Controls.Add(this.scHome);
            this.tabPageHome.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageHome.Location = new System.Drawing.Point(114, 4);
            this.tabPageHome.Name = "tabPageHome";
            this.tabPageHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHome.Size = new System.Drawing.Size(616, 454);
            this.tabPageHome.TabIndex = 0;
            this.tabPageHome.Text = "Start";
            this.tabPageHome.Enter += new System.EventHandler(this.tabPageHome_Enter);
            // 
            // scHome
            // 
            this.scHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scHome.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scHome.IsSplitterFixed = true;
            this.scHome.Location = new System.Drawing.Point(3, 3);
            this.scHome.Name = "scHome";
            this.scHome.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scHome.Panel1
            // 
            this.scHome.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.scHome.Panel1.Controls.Add(this.btAbmelden);
            this.scHome.Panel1.Controls.Add(this.lbAngemeldet);
            this.scHome.Panel1.Controls.Add(this.lbTimer);
            this.scHome.Panel1.Controls.Add(this.lbMitarbeiterName);
            this.scHome.Panel1.Controls.Add(this.lbWillkommen);
            // 
            // scHome.Panel2
            // 
            this.scHome.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.scHome.Panel2.Controls.Add(this.newsTabControl);
            this.scHome.Size = new System.Drawing.Size(610, 448);
            this.scHome.SplitterDistance = 127;
            this.scHome.TabIndex = 0;
            // 
            // btAbmelden
            // 
            this.btAbmelden.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btAbmelden.BackgroundImage = global::PuG_Verwaltungssoftware.Properties.Resources.pug_logout_groß;
            this.btAbmelden.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btAbmelden.Location = new System.Drawing.Point(552, 21);
            this.btAbmelden.Name = "btAbmelden";
            this.btAbmelden.Size = new System.Drawing.Size(55, 53);
            this.btAbmelden.TabIndex = 4;
            this.btAbmelden.UseVisualStyleBackColor = true;
            this.btAbmelden.Click += new System.EventHandler(this.btAbmelden_Click);
            // 
            // lbAngemeldet
            // 
            this.lbAngemeldet.AutoSize = true;
            this.lbAngemeldet.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbAngemeldet.Location = new System.Drawing.Point(426, 0);
            this.lbAngemeldet.Name = "lbAngemeldet";
            this.lbAngemeldet.Size = new System.Drawing.Size(119, 19);
            this.lbAngemeldet.TabIndex = 3;
            this.lbAngemeldet.Text = "Angemeldet seit:";
            // 
            // lbTimer
            // 
            this.lbTimer.AutoSize = true;
            this.lbTimer.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbTimer.Location = new System.Drawing.Point(545, 0);
            this.lbTimer.Name = "lbTimer";
            this.lbTimer.Size = new System.Drawing.Size(65, 19);
            this.lbTimer.TabIndex = 2;
            this.lbTimer.Text = "00:00:00";
            // 
            // lbMitarbeiterName
            // 
            this.lbMitarbeiterName.AutoSize = true;
            this.lbMitarbeiterName.Location = new System.Drawing.Point(19, 55);
            this.lbMitarbeiterName.Name = "lbMitarbeiterName";
            this.lbMitarbeiterName.Size = new System.Drawing.Size(136, 19);
            this.lbMitarbeiterName.TabIndex = 1;
            this.lbMitarbeiterName.Text = "lbMitarbeiterName";
            // 
            // lbWillkommen
            // 
            this.lbWillkommen.AutoSize = true;
            this.lbWillkommen.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWillkommen.Location = new System.Drawing.Point(18, 16);
            this.lbWillkommen.Name = "lbWillkommen";
            this.lbWillkommen.Size = new System.Drawing.Size(196, 26);
            this.lbWillkommen.TabIndex = 0;
            this.lbWillkommen.Text = "Herzlich Willkommen";
            // 
            // newsTabControl
            // 
            this.newsTabControl.Controls.Add(this.tabPageAktuell);
            this.newsTabControl.Controls.Add(this.tabPageHeute);
            this.newsTabControl.Controls.Add(this.tabPageKommend);
            this.newsTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newsTabControl.Location = new System.Drawing.Point(0, 0);
            this.newsTabControl.Name = "newsTabControl";
            this.newsTabControl.SelectedIndex = 0;
            this.newsTabControl.Size = new System.Drawing.Size(610, 317);
            this.newsTabControl.TabIndex = 1;
            // 
            // tabPageAktuell
            // 
            this.tabPageAktuell.Controls.Add(this.lvNewsAktuell);
            this.tabPageAktuell.Location = new System.Drawing.Point(4, 28);
            this.tabPageAktuell.Name = "tabPageAktuell";
            this.tabPageAktuell.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAktuell.Size = new System.Drawing.Size(602, 285);
            this.tabPageAktuell.TabIndex = 0;
            this.tabPageAktuell.Text = "Aktuelle Kurse";
            this.tabPageAktuell.UseVisualStyleBackColor = true;
            // 
            // lvNewsAktuell
            // 
            this.lvNewsAktuell.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvNewsAktuell.Location = new System.Drawing.Point(3, 3);
            this.lvNewsAktuell.Name = "lvNewsAktuell";
            this.lvNewsAktuell.Size = new System.Drawing.Size(596, 279);
            this.lvNewsAktuell.TabIndex = 0;
            this.lvNewsAktuell.UseCompatibleStateImageBehavior = false;
            this.lvNewsAktuell.View = System.Windows.Forms.View.List;
            this.lvNewsAktuell.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvNewsAktuell_KeyDown);
            this.lvNewsAktuell.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvNewsAktuell_MouseDown);
            // 
            // tabPageHeute
            // 
            this.tabPageHeute.Controls.Add(this.lvNewsHeute);
            this.tabPageHeute.Location = new System.Drawing.Point(4, 28);
            this.tabPageHeute.Name = "tabPageHeute";
            this.tabPageHeute.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHeute.Size = new System.Drawing.Size(602, 285);
            this.tabPageHeute.TabIndex = 1;
            this.tabPageHeute.Text = "Heutige Kurse";
            this.tabPageHeute.UseVisualStyleBackColor = true;
            // 
            // lvNewsHeute
            // 
            this.lvNewsHeute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvNewsHeute.Location = new System.Drawing.Point(3, 3);
            this.lvNewsHeute.Name = "lvNewsHeute";
            this.lvNewsHeute.Size = new System.Drawing.Size(596, 279);
            this.lvNewsHeute.TabIndex = 1;
            this.lvNewsHeute.UseCompatibleStateImageBehavior = false;
            this.lvNewsHeute.View = System.Windows.Forms.View.List;
            this.lvNewsHeute.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvNewsHeute_KeyDown);
            this.lvNewsHeute.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvNewsHeute_MouseDown);
            // 
            // tabPageKommend
            // 
            this.tabPageKommend.Controls.Add(this.lvNewsKommend);
            this.tabPageKommend.Location = new System.Drawing.Point(4, 28);
            this.tabPageKommend.Name = "tabPageKommend";
            this.tabPageKommend.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageKommend.Size = new System.Drawing.Size(602, 285);
            this.tabPageKommend.TabIndex = 2;
            this.tabPageKommend.Text = "Kommende Kurse (3 Tage)";
            this.tabPageKommend.UseVisualStyleBackColor = true;
            // 
            // lvNewsKommend
            // 
            this.lvNewsKommend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvNewsKommend.Location = new System.Drawing.Point(3, 3);
            this.lvNewsKommend.Name = "lvNewsKommend";
            this.lvNewsKommend.Size = new System.Drawing.Size(596, 279);
            this.lvNewsKommend.TabIndex = 1;
            this.lvNewsKommend.UseCompatibleStateImageBehavior = false;
            this.lvNewsKommend.View = System.Windows.Forms.View.List;
            this.lvNewsKommend.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvNewsKommend_KeyDown);
            this.lvNewsKommend.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvNewsKommend_MouseDown);
            // 
            // tabPageMitarbeiter
            // 
            this.tabPageMitarbeiter.BackColor = System.Drawing.Color.White;
            this.tabPageMitarbeiter.Controls.Add(this.scMitarbeiter);
            this.tabPageMitarbeiter.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageMitarbeiter.Location = new System.Drawing.Point(114, 4);
            this.tabPageMitarbeiter.Name = "tabPageMitarbeiter";
            this.tabPageMitarbeiter.Size = new System.Drawing.Size(616, 454);
            this.tabPageMitarbeiter.TabIndex = 1;
            this.tabPageMitarbeiter.Text = "Mitarbeiter";
            this.tabPageMitarbeiter.Enter += new System.EventHandler(this.tabPageMitarbeiter_Enter);
            // 
            // scMitarbeiter
            // 
            this.scMitarbeiter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMitarbeiter.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.scMitarbeiter.IsSplitterFixed = true;
            this.scMitarbeiter.Location = new System.Drawing.Point(0, 0);
            this.scMitarbeiter.Name = "scMitarbeiter";
            this.scMitarbeiter.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scMitarbeiter.Panel1
            // 
            this.scMitarbeiter.Panel1.Controls.Add(this.gridMitarbeiter);
            // 
            // scMitarbeiter.Panel2
            // 
            this.scMitarbeiter.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.scMitarbeiter.Panel2.Controls.Add(this.tbMitarbeiterSuchen);
            this.scMitarbeiter.Panel2.Controls.Add(this.ddlMitarbeiterSuchen);
            this.scMitarbeiter.Panel2.Controls.Add(this.btMaLoeschen);
            this.scMitarbeiter.Panel2.Controls.Add(this.btMaOeffnen);
            this.scMitarbeiter.Panel2.Controls.Add(this.btMaNeu);
            this.scMitarbeiter.Size = new System.Drawing.Size(616, 454);
            this.scMitarbeiter.SplitterDistance = 395;
            this.scMitarbeiter.TabIndex = 2;
            // 
            // gridMitarbeiter
            // 
            this.gridMitarbeiter.AllowUserToAddRows = false;
            this.gridMitarbeiter.AllowUserToDeleteRows = false;
            this.gridMitarbeiter.AllowUserToOrderColumns = true;
            this.gridMitarbeiter.AllowUserToResizeColumns = false;
            this.gridMitarbeiter.AllowUserToResizeRows = false;
            this.gridMitarbeiter.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridMitarbeiter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMitarbeiter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridMitarbeiter.Location = new System.Drawing.Point(0, 0);
            this.gridMitarbeiter.Name = "gridMitarbeiter";
            this.gridMitarbeiter.ReadOnly = true;
            this.gridMitarbeiter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridMitarbeiter.Size = new System.Drawing.Size(616, 395);
            this.gridMitarbeiter.TabIndex = 0;
            this.gridMitarbeiter.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridMitarbeiter_CellDoubleClick);
            this.gridMitarbeiter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridMitarbeiter_KeyDown);
            this.gridMitarbeiter.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridMitarbeiter_MouseDown);
            // 
            // tbMitarbeiterSuchen
            // 
            this.tbMitarbeiterSuchen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMitarbeiterSuchen.Location = new System.Drawing.Point(305, 14);
            this.tbMitarbeiterSuchen.Name = "tbMitarbeiterSuchen";
            this.tbMitarbeiterSuchen.Size = new System.Drawing.Size(179, 27);
            this.tbMitarbeiterSuchen.TabIndex = 5;
            this.tbMitarbeiterSuchen.TextChanged += new System.EventHandler(this.tbMitarbeiterSuchen_TextChanged);
            // 
            // ddlMitarbeiterSuchen
            // 
            this.ddlMitarbeiterSuchen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlMitarbeiterSuchen.FormattingEnabled = true;
            this.ddlMitarbeiterSuchen.Location = new System.Drawing.Point(190, 14);
            this.ddlMitarbeiterSuchen.Name = "ddlMitarbeiterSuchen";
            this.ddlMitarbeiterSuchen.Size = new System.Drawing.Size(109, 27);
            this.ddlMitarbeiterSuchen.TabIndex = 4;
            this.ddlMitarbeiterSuchen.SelectedIndexChanged += new System.EventHandler(this.ddlMitarbeiterSuchen_SelectedIndexChanged);
            // 
            // btMaLoeschen
            // 
            this.btMaLoeschen.BackgroundImage = global::PuG_Verwaltungssoftware.Properties.Resources.pug_delete_groß;
            this.btMaLoeschen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btMaLoeschen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btMaLoeschen.Dock = System.Windows.Forms.DockStyle.Left;
            this.btMaLoeschen.Location = new System.Drawing.Point(92, 0);
            this.btMaLoeschen.Name = "btMaLoeschen";
            this.btMaLoeschen.Size = new System.Drawing.Size(92, 55);
            this.btMaLoeschen.TabIndex = 3;
            this.btMaLoeschen.UseVisualStyleBackColor = true;
            this.btMaLoeschen.Click += new System.EventHandler(this.btMaLoeschen_Click);
            // 
            // btMaOeffnen
            // 
            this.btMaOeffnen.BackgroundImage = global::PuG_Verwaltungssoftware.Properties.Resources.pug_open_groß;
            this.btMaOeffnen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btMaOeffnen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btMaOeffnen.Dock = System.Windows.Forms.DockStyle.Right;
            this.btMaOeffnen.Location = new System.Drawing.Point(490, 0);
            this.btMaOeffnen.Name = "btMaOeffnen";
            this.btMaOeffnen.Size = new System.Drawing.Size(126, 55);
            this.btMaOeffnen.TabIndex = 2;
            this.btMaOeffnen.UseVisualStyleBackColor = true;
            this.btMaOeffnen.Click += new System.EventHandler(this.btMaOeffnen_Click);
            // 
            // btMaNeu
            // 
            this.btMaNeu.BackgroundImage = global::PuG_Verwaltungssoftware.Properties.Resources.pug_add_groß;
            this.btMaNeu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btMaNeu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btMaNeu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btMaNeu.Location = new System.Drawing.Point(0, 0);
            this.btMaNeu.Name = "btMaNeu";
            this.btMaNeu.Size = new System.Drawing.Size(92, 55);
            this.btMaNeu.TabIndex = 1;
            this.btMaNeu.UseVisualStyleBackColor = true;
            this.btMaNeu.Click += new System.EventHandler(this.btMaNeu_Click);
            // 
            // tabPageMitglieder
            // 
            this.tabPageMitglieder.BackColor = System.Drawing.Color.White;
            this.tabPageMitglieder.Controls.Add(this.scMitglieder);
            this.tabPageMitglieder.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageMitglieder.Location = new System.Drawing.Point(114, 4);
            this.tabPageMitglieder.Name = "tabPageMitglieder";
            this.tabPageMitglieder.Size = new System.Drawing.Size(616, 454);
            this.tabPageMitglieder.TabIndex = 2;
            this.tabPageMitglieder.Text = "Mitglieder";
            this.tabPageMitglieder.Enter += new System.EventHandler(this.tabPageMitglieder_Enter);
            // 
            // scMitglieder
            // 
            this.scMitglieder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMitglieder.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.scMitglieder.IsSplitterFixed = true;
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
            this.scMitglieder.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.scMitglieder.Panel2.Controls.Add(this.tbMitgliederSuchen);
            this.scMitglieder.Panel2.Controls.Add(this.ddlMitgliederSuchen);
            this.scMitglieder.Panel2.Controls.Add(this.btMgLoeschen);
            this.scMitglieder.Panel2.Controls.Add(this.btMgNeu);
            this.scMitglieder.Panel2.Controls.Add(this.btMgOeffnen);
            this.scMitglieder.Size = new System.Drawing.Size(616, 454);
            this.scMitglieder.SplitterDistance = 395;
            this.scMitglieder.TabIndex = 0;
            // 
            // gridMitglieder
            // 
            this.gridMitglieder.AllowUserToAddRows = false;
            this.gridMitglieder.AllowUserToDeleteRows = false;
            this.gridMitglieder.AllowUserToOrderColumns = true;
            this.gridMitglieder.AllowUserToResizeColumns = false;
            this.gridMitglieder.AllowUserToResizeRows = false;
            this.gridMitglieder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridMitglieder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMitglieder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridMitglieder.Location = new System.Drawing.Point(0, 0);
            this.gridMitglieder.MultiSelect = false;
            this.gridMitglieder.Name = "gridMitglieder";
            this.gridMitglieder.ReadOnly = true;
            this.gridMitglieder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridMitglieder.Size = new System.Drawing.Size(616, 395);
            this.gridMitglieder.TabIndex = 1;
            this.gridMitglieder.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridMitglieder_CellDoubleClick);
            this.gridMitglieder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridMitglieder_MouseDown);
            // 
            // tbMitgliederSuchen
            // 
            this.tbMitgliederSuchen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMitgliederSuchen.Location = new System.Drawing.Point(305, 14);
            this.tbMitgliederSuchen.Name = "tbMitgliederSuchen";
            this.tbMitgliederSuchen.Size = new System.Drawing.Size(179, 27);
            this.tbMitgliederSuchen.TabIndex = 8;
            this.tbMitgliederSuchen.TextChanged += new System.EventHandler(this.tbMitgliederSuchen_TextChanged);
            // 
            // ddlMitgliederSuchen
            // 
            this.ddlMitgliederSuchen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlMitgliederSuchen.FormattingEnabled = true;
            this.ddlMitgliederSuchen.Location = new System.Drawing.Point(190, 14);
            this.ddlMitgliederSuchen.Name = "ddlMitgliederSuchen";
            this.ddlMitgliederSuchen.Size = new System.Drawing.Size(109, 27);
            this.ddlMitgliederSuchen.TabIndex = 7;
            this.ddlMitgliederSuchen.SelectedIndexChanged += new System.EventHandler(this.ddlMitgliederSuchen_SelectedIndexChanged);
            // 
            // btMgLoeschen
            // 
            this.btMgLoeschen.BackgroundImage = global::PuG_Verwaltungssoftware.Properties.Resources.pug_delete_groß;
            this.btMgLoeschen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btMgLoeschen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btMgLoeschen.Dock = System.Windows.Forms.DockStyle.Left;
            this.btMgLoeschen.Location = new System.Drawing.Point(92, 0);
            this.btMgLoeschen.Name = "btMgLoeschen";
            this.btMgLoeschen.Size = new System.Drawing.Size(92, 55);
            this.btMgLoeschen.TabIndex = 6;
            this.btMgLoeschen.UseVisualStyleBackColor = true;
            this.btMgLoeschen.Click += new System.EventHandler(this.btMgLoeschen_Click);
            // 
            // btMgNeu
            // 
            this.btMgNeu.BackgroundImage = global::PuG_Verwaltungssoftware.Properties.Resources.pug_add_groß;
            this.btMgNeu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btMgNeu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btMgNeu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btMgNeu.Location = new System.Drawing.Point(0, 0);
            this.btMgNeu.Name = "btMgNeu";
            this.btMgNeu.Size = new System.Drawing.Size(92, 55);
            this.btMgNeu.TabIndex = 4;
            this.btMgNeu.UseVisualStyleBackColor = true;
            this.btMgNeu.Click += new System.EventHandler(this.btMgNeu_Click);
            // 
            // btMgOeffnen
            // 
            this.btMgOeffnen.BackgroundImage = global::PuG_Verwaltungssoftware.Properties.Resources.pug_open_groß;
            this.btMgOeffnen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btMgOeffnen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btMgOeffnen.Dock = System.Windows.Forms.DockStyle.Right;
            this.btMgOeffnen.Location = new System.Drawing.Point(490, 0);
            this.btMgOeffnen.Name = "btMgOeffnen";
            this.btMgOeffnen.Size = new System.Drawing.Size(126, 55);
            this.btMgOeffnen.TabIndex = 5;
            this.btMgOeffnen.UseVisualStyleBackColor = true;
            this.btMgOeffnen.Click += new System.EventHandler(this.btMgOeffnen_Click);
            // 
            // tabPageKurse
            // 
            this.tabPageKurse.BackColor = System.Drawing.Color.White;
            this.tabPageKurse.Controls.Add(this.scKurse);
            this.tabPageKurse.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageKurse.Location = new System.Drawing.Point(114, 4);
            this.tabPageKurse.Name = "tabPageKurse";
            this.tabPageKurse.Size = new System.Drawing.Size(616, 454);
            this.tabPageKurse.TabIndex = 3;
            this.tabPageKurse.Text = "Kurse";
            this.tabPageKurse.Enter += new System.EventHandler(this.tabPageKurse_Enter);
            // 
            // scKurse
            // 
            this.scKurse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scKurse.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.scKurse.IsSplitterFixed = true;
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
            this.scKurse.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.scKurse.Panel2.Controls.Add(this.tbKursSuchen);
            this.scKurse.Panel2.Controls.Add(this.ddlKursSuchen);
            this.scKurse.Panel2.Controls.Add(this.btKursLoeschen);
            this.scKurse.Panel2.Controls.Add(this.btKursNeu);
            this.scKurse.Panel2.Controls.Add(this.btKursOeffnen);
            this.scKurse.Size = new System.Drawing.Size(616, 454);
            this.scKurse.SplitterDistance = 395;
            this.scKurse.TabIndex = 0;
            // 
            // gridKurse
            // 
            this.gridKurse.AllowUserToAddRows = false;
            this.gridKurse.AllowUserToDeleteRows = false;
            this.gridKurse.AllowUserToOrderColumns = true;
            this.gridKurse.AllowUserToResizeColumns = false;
            this.gridKurse.AllowUserToResizeRows = false;
            this.gridKurse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gridKurse.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.gridKurse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridKurse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridKurse.Location = new System.Drawing.Point(0, 0);
            this.gridKurse.Name = "gridKurse";
            this.gridKurse.ReadOnly = true;
            this.gridKurse.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.gridKurse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridKurse.Size = new System.Drawing.Size(616, 395);
            this.gridKurse.TabIndex = 2;
            this.gridKurse.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridKurse_CellDoubleClick);
            this.gridKurse.Sorted += new System.EventHandler(this.gridKurse_Sorted);
            this.gridKurse.Paint += new System.Windows.Forms.PaintEventHandler(this.gridKurse_Paint);
            this.gridKurse.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridKurse_KeyDown);
            this.gridKurse.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridKurse_MouseDown);
            this.gridKurse.Resize += new System.EventHandler(this.gridKurse_Resize);
            // 
            // tbKursSuchen
            // 
            this.tbKursSuchen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbKursSuchen.Location = new System.Drawing.Point(305, 14);
            this.tbKursSuchen.Name = "tbKursSuchen";
            this.tbKursSuchen.Size = new System.Drawing.Size(179, 27);
            this.tbKursSuchen.TabIndex = 11;
            this.tbKursSuchen.TextChanged += new System.EventHandler(this.textBoxSuchen_TextChanged);
            // 
            // ddlKursSuchen
            // 
            this.ddlKursSuchen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlKursSuchen.FormattingEnabled = true;
            this.ddlKursSuchen.Location = new System.Drawing.Point(190, 14);
            this.ddlKursSuchen.Name = "ddlKursSuchen";
            this.ddlKursSuchen.Size = new System.Drawing.Size(109, 27);
            this.ddlKursSuchen.TabIndex = 10;
            this.ddlKursSuchen.SelectedIndexChanged += new System.EventHandler(this.comboBoxSuchen_SelectedIndexChanged);
            // 
            // btKursLoeschen
            // 
            this.btKursLoeschen.BackgroundImage = global::PuG_Verwaltungssoftware.Properties.Resources.pug_delete_groß;
            this.btKursLoeschen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btKursLoeschen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btKursLoeschen.Dock = System.Windows.Forms.DockStyle.Left;
            this.btKursLoeschen.Location = new System.Drawing.Point(92, 0);
            this.btKursLoeschen.Name = "btKursLoeschen";
            this.btKursLoeschen.Size = new System.Drawing.Size(92, 55);
            this.btKursLoeschen.TabIndex = 7;
            this.btKursLoeschen.UseVisualStyleBackColor = true;
            this.btKursLoeschen.Click += new System.EventHandler(this.btKursLoeschen_Click);
            // 
            // btKursNeu
            // 
            this.btKursNeu.BackgroundImage = global::PuG_Verwaltungssoftware.Properties.Resources.pug_add_groß;
            this.btKursNeu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btKursNeu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btKursNeu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btKursNeu.Location = new System.Drawing.Point(0, 0);
            this.btKursNeu.Name = "btKursNeu";
            this.btKursNeu.Size = new System.Drawing.Size(92, 55);
            this.btKursNeu.TabIndex = 9;
            this.btKursNeu.UseVisualStyleBackColor = true;
            this.btKursNeu.Click += new System.EventHandler(this.btKursNeu_Click);
            // 
            // btKursOeffnen
            // 
            this.btKursOeffnen.BackgroundImage = global::PuG_Verwaltungssoftware.Properties.Resources.pug_open_groß;
            this.btKursOeffnen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btKursOeffnen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btKursOeffnen.Dock = System.Windows.Forms.DockStyle.Right;
            this.btKursOeffnen.Location = new System.Drawing.Point(490, 0);
            this.btKursOeffnen.Name = "btKursOeffnen";
            this.btKursOeffnen.Size = new System.Drawing.Size(126, 55);
            this.btKursOeffnen.TabIndex = 8;
            this.btKursOeffnen.UseVisualStyleBackColor = true;
            this.btKursOeffnen.Click += new System.EventHandler(this.btKursOeffnen_Click);
            // 
            // tabPageKursUebersicht
            // 
            this.tabPageKursUebersicht.BackColor = System.Drawing.Color.White;
            this.tabPageKursUebersicht.Controls.Add(this.scKursUebersicht);
            this.tabPageKursUebersicht.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageKursUebersicht.Location = new System.Drawing.Point(114, 4);
            this.tabPageKursUebersicht.Name = "tabPageKursUebersicht";
            this.tabPageKursUebersicht.Size = new System.Drawing.Size(616, 454);
            this.tabPageKursUebersicht.TabIndex = 4;
            this.tabPageKursUebersicht.Text = "Kurs Übersicht";
            this.tabPageKursUebersicht.Enter += new System.EventHandler(this.tabPageKursUebersicht_Enter);
            // 
            // scKursUebersicht
            // 
            this.scKursUebersicht.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scKursUebersicht.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.scKursUebersicht.Location = new System.Drawing.Point(0, 0);
            this.scKursUebersicht.Name = "scKursUebersicht";
            this.scKursUebersicht.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scKursUebersicht.Panel1
            // 
            this.scKursUebersicht.Panel1.Controls.Add(this.gridKursUebersicht);
            // 
            // scKursUebersicht.Panel2
            // 
            this.scKursUebersicht.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.scKursUebersicht.Panel2.Controls.Add(this.btKursUebersichtOeffnen);
            this.scKursUebersicht.Panel2.Controls.Add(this.tbKursUebersichtSuchen);
            this.scKursUebersicht.Panel2.Controls.Add(this.ddlKursUebersichtSuchen);
            this.scKursUebersicht.Size = new System.Drawing.Size(616, 454);
            this.scKursUebersicht.SplitterDistance = 395;
            this.scKursUebersicht.TabIndex = 0;
            // 
            // gridKursUebersicht
            // 
            this.gridKursUebersicht.AllowUserToAddRows = false;
            this.gridKursUebersicht.AllowUserToDeleteRows = false;
            this.gridKursUebersicht.AllowUserToOrderColumns = true;
            this.gridKursUebersicht.AllowUserToResizeColumns = false;
            this.gridKursUebersicht.AllowUserToResizeRows = false;
            this.gridKursUebersicht.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridKursUebersicht.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridKursUebersicht.Location = new System.Drawing.Point(0, 0);
            this.gridKursUebersicht.Name = "gridKursUebersicht";
            this.gridKursUebersicht.ReadOnly = true;
            this.gridKursUebersicht.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridKursUebersicht.Size = new System.Drawing.Size(616, 395);
            this.gridKursUebersicht.TabIndex = 0;
            this.gridKursUebersicht.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridKursUebersicht_CellDoubleClick);
            this.gridKursUebersicht.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridKursUebersicht_KeyDown);
            this.gridKursUebersicht.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridKursUebersicht_MouseDown);
            this.gridKursUebersicht.Resize += new System.EventHandler(this.gridKursUebersicht_Resize);
            // 
            // btKursUebersichtOeffnen
            // 
            this.btKursUebersichtOeffnen.BackgroundImage = global::PuG_Verwaltungssoftware.Properties.Resources.pug_open_groß;
            this.btKursUebersichtOeffnen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btKursUebersichtOeffnen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btKursUebersichtOeffnen.Dock = System.Windows.Forms.DockStyle.Right;
            this.btKursUebersichtOeffnen.Location = new System.Drawing.Point(490, 0);
            this.btKursUebersichtOeffnen.Name = "btKursUebersichtOeffnen";
            this.btKursUebersichtOeffnen.Size = new System.Drawing.Size(126, 55);
            this.btKursUebersichtOeffnen.TabIndex = 14;
            this.btKursUebersichtOeffnen.UseVisualStyleBackColor = true;
            this.btKursUebersichtOeffnen.Click += new System.EventHandler(this.btKursUebersichtOeffnen_Click);
            // 
            // tbKursUebersichtSuchen
            // 
            this.tbKursUebersichtSuchen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbKursUebersichtSuchen.Location = new System.Drawing.Point(140, 15);
            this.tbKursUebersichtSuchen.Name = "tbKursUebersichtSuchen";
            this.tbKursUebersichtSuchen.Size = new System.Drawing.Size(344, 27);
            this.tbKursUebersichtSuchen.TabIndex = 13;
            this.tbKursUebersichtSuchen.TextChanged += new System.EventHandler(this.tbKursUebersichtSuchen_TextChanged);
            // 
            // ddlKursUebersichtSuchen
            // 
            this.ddlKursUebersichtSuchen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlKursUebersichtSuchen.FormattingEnabled = true;
            this.ddlKursUebersichtSuchen.Location = new System.Drawing.Point(16, 15);
            this.ddlKursUebersichtSuchen.Name = "ddlKursUebersichtSuchen";
            this.ddlKursUebersichtSuchen.Size = new System.Drawing.Size(118, 27);
            this.ddlKursUebersichtSuchen.TabIndex = 12;
            this.ddlKursUebersichtSuchen.SelectedIndexChanged += new System.EventHandler(this.ddlKursUebersichtSuchen_SelectedIndexChanged);
            // 
            // loginPanel
            // 
            this.loginPanel.BackColor = System.Drawing.Color.Transparent;
            this.loginPanel.Controls.Add(this.lbLoginMessage);
            this.loginPanel.Controls.Add(this.pictureBox1);
            this.loginPanel.Controls.Add(this.btExit);
            this.loginPanel.Controls.Add(this.tbPassword);
            this.loginPanel.Controls.Add(this.tbUsername);
            this.loginPanel.Controls.Add(this.btLogin);
            this.loginPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginPanel.Location = new System.Drawing.Point(0, 0);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(734, 462);
            this.loginPanel.TabIndex = 2;
            // 
            // lbLoginMessage
            // 
            this.lbLoginMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbLoginMessage.AutoSize = true;
            this.lbLoginMessage.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoginMessage.ForeColor = System.Drawing.Color.Red;
            this.lbLoginMessage.Location = new System.Drawing.Point(193, 374);
            this.lbLoginMessage.Name = "lbLoginMessage";
            this.lbLoginMessage.Size = new System.Drawing.Size(0, 19);
            this.lbLoginMessage.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::PuG_Verwaltungssoftware.Properties.Resources.pug_runner;
            this.pictureBox1.Location = new System.Drawing.Point(172, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(403, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btExit
            // 
            this.btExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btExit.Location = new System.Drawing.Point(454, 321);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(93, 32);
            this.btExit.TabIndex = 3;
            this.btExit.Text = "Beenden";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPassword.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(197, 289);
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
            this.tbUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbUsername.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.Location = new System.Drawing.Point(197, 257);
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
            this.btLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btLogin.Location = new System.Drawing.Point(197, 321);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(251, 32);
            this.btLogin.TabIndex = 0;
            this.btLogin.Text = "Anmelden";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // mainWindow
            // 
            this.AcceptButton = this.btLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btExit;
            this.ClientSize = new System.Drawing.Size(734, 462);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.mainTabControl);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(750, 500);
            this.Name = "mainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "P&G Verwaltungssoftware";
            this.Resize += new System.EventHandler(this.mainWindow_Resize);
            this.mainTabControl.ResumeLayout(false);
            this.tabPageHome.ResumeLayout(false);
            this.scHome.Panel1.ResumeLayout(false);
            this.scHome.Panel1.PerformLayout();
            this.scHome.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scHome)).EndInit();
            this.scHome.ResumeLayout(false);
            this.newsTabControl.ResumeLayout(false);
            this.tabPageAktuell.ResumeLayout(false);
            this.tabPageHeute.ResumeLayout(false);
            this.tabPageKommend.ResumeLayout(false);
            this.tabPageMitarbeiter.ResumeLayout(false);
            this.scMitarbeiter.Panel1.ResumeLayout(false);
            this.scMitarbeiter.Panel2.ResumeLayout(false);
            this.scMitarbeiter.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMitarbeiter)).EndInit();
            this.scMitarbeiter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridMitarbeiter)).EndInit();
            this.tabPageMitglieder.ResumeLayout(false);
            this.scMitglieder.Panel1.ResumeLayout(false);
            this.scMitglieder.Panel2.ResumeLayout(false);
            this.scMitglieder.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMitglieder)).EndInit();
            this.scMitglieder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridMitglieder)).EndInit();
            this.tabPageKurse.ResumeLayout(false);
            this.scKurse.Panel1.ResumeLayout(false);
            this.scKurse.Panel2.ResumeLayout(false);
            this.scKurse.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scKurse)).EndInit();
            this.scKurse.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridKurse)).EndInit();
            this.tabPageKursUebersicht.ResumeLayout(false);
            this.scKursUebersicht.Panel1.ResumeLayout(false);
            this.scKursUebersicht.Panel2.ResumeLayout(false);
            this.scKursUebersicht.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scKursUebersicht)).EndInit();
            this.scKursUebersicht.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridKursUebersicht)).EndInit();
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

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
        private System.Windows.Forms.SplitContainer scHome;
        private System.Windows.Forms.Label lbTimer;
        private System.Windows.Forms.Label lbMitarbeiterName;
        private System.Windows.Forms.Label lbWillkommen;
        private System.Windows.Forms.Label lbAngemeldet;
        private System.Windows.Forms.ListView lvNewsAktuell;
        private System.Windows.Forms.TextBox tbKursSuchen;
        private System.Windows.Forms.ComboBox ddlKursSuchen;
        private System.Windows.Forms.ComboBox ddlMitarbeiterSuchen;
        private System.Windows.Forms.TextBox tbMitarbeiterSuchen;
        private System.Windows.Forms.TabPage tabPageKursUebersicht;
        private System.Windows.Forms.SplitContainer scKursUebersicht;
        private System.Windows.Forms.DataGridView gridKursUebersicht;
        private System.Windows.Forms.Button btKursUebersichtOeffnen;
        private System.Windows.Forms.TextBox tbKursUebersichtSuchen;
        private System.Windows.Forms.ComboBox ddlKursUebersichtSuchen;
        private System.Windows.Forms.TabControl newsTabControl;
        private System.Windows.Forms.TabPage tabPageAktuell;
        private System.Windows.Forms.TabPage tabPageHeute;
        private System.Windows.Forms.ListView lvNewsHeute;
        private System.Windows.Forms.TabPage tabPageKommend;
        private System.Windows.Forms.ListView lvNewsKommend;
        private System.Windows.Forms.Button btAbmelden;
        private System.Windows.Forms.DataGridView gridMitarbeiter;
        private System.Windows.Forms.TextBox tbMitgliederSuchen;
        private System.Windows.Forms.ComboBox ddlMitgliederSuchen;
    }
}

