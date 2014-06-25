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
            this.lbAngemeldet = new System.Windows.Forms.Label();
            this.lbTimer = new System.Windows.Forms.Label();
            this.lbMitarbeiterName = new System.Windows.Forms.Label();
            this.lbWillkommen = new System.Windows.Forms.Label();
            this.lvNachrichten = new System.Windows.Forms.ListView();
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
            this.mainTabControl.ItemSize = new System.Drawing.Size(80, 110);
            this.mainTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainTabControl.Multiline = true;
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(678, 442);
            this.mainTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.mainTabControl.TabIndex = 1;
            this.mainTabControl.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.mainTabControl_DrawItem);
            // 
            // tabPageHome
            // 
            this.tabPageHome.BackColor = System.Drawing.Color.Silver;
            this.tabPageHome.Controls.Add(this.scHome);
            this.tabPageHome.Location = new System.Drawing.Point(114, 4);
            this.tabPageHome.Name = "tabPageHome";
            this.tabPageHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHome.Size = new System.Drawing.Size(560, 434);
            this.tabPageHome.TabIndex = 0;
            this.tabPageHome.Text = "Home";
            this.tabPageHome.Enter += new System.EventHandler(this.tabPageHome_Enter);
            // 
            // scHome
            // 
            this.scHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scHome.Location = new System.Drawing.Point(3, 3);
            this.scHome.Name = "scHome";
            this.scHome.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scHome.Panel1
            // 
            this.scHome.Panel1.Controls.Add(this.lbAngemeldet);
            this.scHome.Panel1.Controls.Add(this.lbTimer);
            this.scHome.Panel1.Controls.Add(this.lbMitarbeiterName);
            this.scHome.Panel1.Controls.Add(this.lbWillkommen);
            // 
            // scHome.Panel2
            // 
            this.scHome.Panel2.Controls.Add(this.lvNachrichten);
            this.scHome.Size = new System.Drawing.Size(554, 428);
            this.scHome.SplitterDistance = 127;
            this.scHome.TabIndex = 0;
            // 
            // lbAngemeldet
            // 
            this.lbAngemeldet.AutoSize = true;
            this.lbAngemeldet.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbAngemeldet.Location = new System.Drawing.Point(381, 0);
            this.lbAngemeldet.Name = "lbAngemeldet";
            this.lbAngemeldet.Size = new System.Drawing.Size(115, 18);
            this.lbAngemeldet.TabIndex = 3;
            this.lbAngemeldet.Text = "Angemeldet seit:";
            // 
            // lbTimer
            // 
            this.lbTimer.AutoSize = true;
            this.lbTimer.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbTimer.Location = new System.Drawing.Point(496, 0);
            this.lbTimer.Name = "lbTimer";
            this.lbTimer.Size = new System.Drawing.Size(58, 18);
            this.lbTimer.TabIndex = 2;
            this.lbTimer.Text = "00:00:00";
            // 
            // lbMitarbeiterName
            // 
            this.lbMitarbeiterName.AutoSize = true;
            this.lbMitarbeiterName.Location = new System.Drawing.Point(23, 56);
            this.lbMitarbeiterName.Name = "lbMitarbeiterName";
            this.lbMitarbeiterName.Size = new System.Drawing.Size(128, 18);
            this.lbMitarbeiterName.TabIndex = 1;
            this.lbMitarbeiterName.Text = "lbMitarbeiterName";
            // 
            // lbWillkommen
            // 
            this.lbWillkommen.AutoSize = true;
            this.lbWillkommen.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWillkommen.Location = new System.Drawing.Point(18, 16);
            this.lbWillkommen.Name = "lbWillkommen";
            this.lbWillkommen.Size = new System.Drawing.Size(127, 26);
            this.lbWillkommen.TabIndex = 0;
            this.lbWillkommen.Text = "Willkommen,";
            // 
            // lvNachrichten
            // 
            this.lvNachrichten.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvNachrichten.Location = new System.Drawing.Point(0, 0);
            this.lvNachrichten.Name = "lvNachrichten";
            this.lvNachrichten.Size = new System.Drawing.Size(554, 297);
            this.lvNachrichten.TabIndex = 0;
            this.lvNachrichten.UseCompatibleStateImageBehavior = false;
            this.lvNachrichten.View = System.Windows.Forms.View.List;
            // 
            // tabPageMitarbeiter
            // 
            this.tabPageMitarbeiter.BackColor = System.Drawing.Color.Silver;
            this.tabPageMitarbeiter.Controls.Add(this.scMitarbeiter);
            this.tabPageMitarbeiter.Location = new System.Drawing.Point(114, 4);
            this.tabPageMitarbeiter.Name = "tabPageMitarbeiter";
            this.tabPageMitarbeiter.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMitarbeiter.Size = new System.Drawing.Size(560, 434);
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
            this.scMitarbeiter.Panel2.Controls.Add(this.tbMitarbeiterSuchen);
            this.scMitarbeiter.Panel2.Controls.Add(this.ddlMitarbeiterSuchen);
            this.scMitarbeiter.Panel2.Controls.Add(this.btMaLoeschen);
            this.scMitarbeiter.Panel2.Controls.Add(this.btMaOeffnen);
            this.scMitarbeiter.Panel2.Controls.Add(this.btMaNeu);
            this.scMitarbeiter.Size = new System.Drawing.Size(554, 428);
            this.scMitarbeiter.SplitterDistance = 376;
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
            this.gridMitarbeiter.Name = "gridMitarbeiter";
            this.gridMitarbeiter.ReadOnly = true;
            this.gridMitarbeiter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridMitarbeiter.Size = new System.Drawing.Size(554, 376);
            this.gridMitarbeiter.TabIndex = 0;
            this.gridMitarbeiter.SelectionChanged += new System.EventHandler(this.gridMitarbeiter_SelectionChanged);
            this.gridMitarbeiter.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridMitarbeiter_MouseDown);
            // 
            // tbMitarbeiterSuchen
            // 
            this.tbMitarbeiterSuchen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMitarbeiterSuchen.Location = new System.Drawing.Point(305, 12);
            this.tbMitarbeiterSuchen.Name = "tbMitarbeiterSuchen";
            this.tbMitarbeiterSuchen.Size = new System.Drawing.Size(117, 26);
            this.tbMitarbeiterSuchen.TabIndex = 5;
            this.tbMitarbeiterSuchen.TextChanged += new System.EventHandler(this.tbMitarbeiterSuchen_TextChanged);
            // 
            // ddlMitarbeiterSuchen
            // 
            this.ddlMitarbeiterSuchen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlMitarbeiterSuchen.FormattingEnabled = true;
            this.ddlMitarbeiterSuchen.Location = new System.Drawing.Point(190, 12);
            this.ddlMitarbeiterSuchen.Name = "ddlMitarbeiterSuchen";
            this.ddlMitarbeiterSuchen.Size = new System.Drawing.Size(109, 26);
            this.ddlMitarbeiterSuchen.TabIndex = 4;
            this.ddlMitarbeiterSuchen.SelectedIndexChanged += new System.EventHandler(this.ddlMitarbeiterSuchen_SelectedIndexChanged);
            // 
            // btMaLoeschen
            // 
            this.btMaLoeschen.Dock = System.Windows.Forms.DockStyle.Left;
            this.btMaLoeschen.Location = new System.Drawing.Point(92, 0);
            this.btMaLoeschen.Name = "btMaLoeschen";
            this.btMaLoeschen.Size = new System.Drawing.Size(92, 48);
            this.btMaLoeschen.TabIndex = 3;
            this.btMaLoeschen.Text = "Löschen";
            this.btMaLoeschen.UseVisualStyleBackColor = true;
            this.btMaLoeschen.Click += new System.EventHandler(this.btMaLoeschen_Click);
            // 
            // btMaOeffnen
            // 
            this.btMaOeffnen.Dock = System.Windows.Forms.DockStyle.Right;
            this.btMaOeffnen.Location = new System.Drawing.Point(428, 0);
            this.btMaOeffnen.Name = "btMaOeffnen";
            this.btMaOeffnen.Size = new System.Drawing.Size(126, 48);
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
            this.btMaNeu.Size = new System.Drawing.Size(92, 48);
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
            this.tabPageMitglieder.Size = new System.Drawing.Size(560, 434);
            this.tabPageMitglieder.TabIndex = 2;
            this.tabPageMitglieder.Text = "Mitglieder";
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
            this.scMitglieder.Size = new System.Drawing.Size(560, 434);
            this.scMitglieder.SplitterDistance = 375;
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
            this.gridMitglieder.Size = new System.Drawing.Size(560, 375);
            this.gridMitglieder.TabIndex = 1;
            // 
            // btMgLoeschen
            // 
            this.btMgLoeschen.Dock = System.Windows.Forms.DockStyle.Left;
            this.btMgLoeschen.Location = new System.Drawing.Point(92, 0);
            this.btMgLoeschen.Name = "btMgLoeschen";
            this.btMgLoeschen.Size = new System.Drawing.Size(92, 55);
            this.btMgLoeschen.TabIndex = 6;
            this.btMgLoeschen.Text = "Löschen";
            this.btMgLoeschen.UseVisualStyleBackColor = true;
            this.btMgLoeschen.Click += new System.EventHandler(this.btMgLoeschen_Click);
            // 
            // btMgNeu
            // 
            this.btMgNeu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btMgNeu.Location = new System.Drawing.Point(0, 0);
            this.btMgNeu.Name = "btMgNeu";
            this.btMgNeu.Size = new System.Drawing.Size(92, 55);
            this.btMgNeu.TabIndex = 4;
            this.btMgNeu.Text = "Neu";
            this.btMgNeu.UseVisualStyleBackColor = true;
            this.btMgNeu.Click += new System.EventHandler(this.btMgNeu_Click);
            // 
            // btMgOeffnen
            // 
            this.btMgOeffnen.Dock = System.Windows.Forms.DockStyle.Right;
            this.btMgOeffnen.Location = new System.Drawing.Point(434, 0);
            this.btMgOeffnen.Name = "btMgOeffnen";
            this.btMgOeffnen.Size = new System.Drawing.Size(126, 55);
            this.btMgOeffnen.TabIndex = 5;
            this.btMgOeffnen.Text = "Öffnen";
            this.btMgOeffnen.UseVisualStyleBackColor = true;
            this.btMgOeffnen.Click += new System.EventHandler(this.btMgOeffnen_Click);
            // 
            // tabPageKurse
            // 
            this.tabPageKurse.BackColor = System.Drawing.Color.Silver;
            this.tabPageKurse.Controls.Add(this.scKurse);
            this.tabPageKurse.Location = new System.Drawing.Point(114, 4);
            this.tabPageKurse.Name = "tabPageKurse";
            this.tabPageKurse.Size = new System.Drawing.Size(560, 434);
            this.tabPageKurse.TabIndex = 3;
            this.tabPageKurse.Text = "Kurse";
            this.tabPageKurse.Enter += new System.EventHandler(this.tabPageKurse_Enter);
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
            this.scKurse.Panel2.Controls.Add(this.tbKursSuchen);
            this.scKurse.Panel2.Controls.Add(this.ddlKursSuchen);
            this.scKurse.Panel2.Controls.Add(this.btKursLoeschen);
            this.scKurse.Panel2.Controls.Add(this.btKursNeu);
            this.scKurse.Panel2.Controls.Add(this.btKursOeffnen);
            this.scKurse.Size = new System.Drawing.Size(560, 434);
            this.scKurse.SplitterDistance = 375;
            this.scKurse.TabIndex = 0;
            // 
            // gridKurse
            // 
            this.gridKurse.AllowUserToAddRows = false;
            this.gridKurse.AllowUserToDeleteRows = false;
            this.gridKurse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridKurse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridKurse.Location = new System.Drawing.Point(0, 0);
            this.gridKurse.MultiSelect = false;
            this.gridKurse.Name = "gridKurse";
            this.gridKurse.ReadOnly = true;
            this.gridKurse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridKurse.Size = new System.Drawing.Size(560, 375);
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
            this.tbKursSuchen.Location = new System.Drawing.Point(301, 14);
            this.tbKursSuchen.Name = "tbKursSuchen";
            this.tbKursSuchen.Size = new System.Drawing.Size(127, 26);
            this.tbKursSuchen.TabIndex = 11;
            this.tbKursSuchen.TextChanged += new System.EventHandler(this.textBoxSuchen_TextChanged);
            // 
            // ddlKursSuchen
            // 
            this.ddlKursSuchen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlKursSuchen.FormattingEnabled = true;
            this.ddlKursSuchen.Location = new System.Drawing.Point(190, 14);
            this.ddlKursSuchen.Name = "ddlKursSuchen";
            this.ddlKursSuchen.Size = new System.Drawing.Size(105, 26);
            this.ddlKursSuchen.TabIndex = 10;
            this.ddlKursSuchen.SelectedIndexChanged += new System.EventHandler(this.comboBoxSuchen_SelectedIndexChanged);
            // 
            // btKursLoeschen
            // 
            this.btKursLoeschen.Dock = System.Windows.Forms.DockStyle.Left;
            this.btKursLoeschen.Location = new System.Drawing.Point(92, 0);
            this.btKursLoeschen.Name = "btKursLoeschen";
            this.btKursLoeschen.Size = new System.Drawing.Size(92, 55);
            this.btKursLoeschen.TabIndex = 7;
            this.btKursLoeschen.Text = "Löschen";
            this.btKursLoeschen.UseVisualStyleBackColor = true;
            this.btKursLoeschen.Click += new System.EventHandler(this.btKursLoeschen_Click);
            // 
            // btKursNeu
            // 
            this.btKursNeu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btKursNeu.Location = new System.Drawing.Point(0, 0);
            this.btKursNeu.Name = "btKursNeu";
            this.btKursNeu.Size = new System.Drawing.Size(92, 55);
            this.btKursNeu.TabIndex = 9;
            this.btKursNeu.Text = "Neu";
            this.btKursNeu.UseVisualStyleBackColor = true;
            this.btKursNeu.Click += new System.EventHandler(this.btKursNeu_Click);
            // 
            // btKursOeffnen
            // 
            this.btKursOeffnen.Dock = System.Windows.Forms.DockStyle.Right;
            this.btKursOeffnen.Location = new System.Drawing.Point(434, 0);
            this.btKursOeffnen.Name = "btKursOeffnen";
            this.btKursOeffnen.Size = new System.Drawing.Size(126, 55);
            this.btKursOeffnen.TabIndex = 8;
            this.btKursOeffnen.Text = "Öffnen";
            this.btKursOeffnen.UseVisualStyleBackColor = true;
            this.btKursOeffnen.Click += new System.EventHandler(this.btKursOeffnen_Click);
            // 
            // tabPageKursUebersicht
            // 
            this.tabPageKursUebersicht.Location = new System.Drawing.Point(114, 4);
            this.tabPageKursUebersicht.Name = "tabPageKursUebersicht";
            this.tabPageKursUebersicht.Size = new System.Drawing.Size(560, 434);
            this.tabPageKursUebersicht.TabIndex = 4;
            this.tabPageKursUebersicht.Text = "Kurs Übersicht";
            this.tabPageKursUebersicht.UseVisualStyleBackColor = true;
            this.tabPageKursUebersicht.Enter += new System.EventHandler(this.tabPageKursUebersicht_Enter);
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
            this.loginPanel.Size = new System.Drawing.Size(677, 442);
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
            this.btExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
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
            // mainWindow
            // 
            this.AcceptButton = this.btLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btExit;
            this.ClientSize = new System.Drawing.Size(678, 442);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.loginPanel);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(600, 450);
            this.Name = "mainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "P&G Verwaltungssoftware";
            this.Load += new System.EventHandler(this.mainWindow_Load);
            this.mainTabControl.ResumeLayout(false);
            this.tabPageHome.ResumeLayout(false);
            this.scHome.Panel1.ResumeLayout(false);
            this.scHome.Panel1.PerformLayout();
            this.scHome.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scHome)).EndInit();
            this.scHome.ResumeLayout(false);
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
        private System.Windows.Forms.SplitContainer scHome;
        private System.Windows.Forms.Label lbTimer;
        private System.Windows.Forms.Label lbMitarbeiterName;
        private System.Windows.Forms.Label lbWillkommen;
        private System.Windows.Forms.Label lbAngemeldet;
        private System.Windows.Forms.ListView lvNachrichten;
        private System.Windows.Forms.TextBox tbKursSuchen;
        private System.Windows.Forms.ComboBox ddlKursSuchen;
        private System.Windows.Forms.ComboBox ddlMitarbeiterSuchen;
        private System.Windows.Forms.TextBox tbMitarbeiterSuchen;
        private System.Windows.Forms.TabPage tabPageKursUebersicht;
    }
}

