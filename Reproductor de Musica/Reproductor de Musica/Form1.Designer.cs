using System;
using System.Windows.Forms;
using AxWMPLib;

namespace Reproductor_de_Musica
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playlistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.addFileToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFolderToLibraryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.songToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.albumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.songsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shuffleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repeatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.leftButton = new System.Windows.Forms.ToolStripButton();
            this.playButton = new System.Windows.Forms.ToolStripButton();
            this.rightButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.lblSong = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.Player = new AxWMPLib.AxWindowsMediaPlayer();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStripContainer2 = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.volumeBar = new XComponent.SliderBar.MACTrackBar();
            this.trackBar = new XComponent.SliderBar.MACTrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.songInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playNextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playLaterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer4 = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.AlbumForArtist = new System.Windows.Forms.ImageList(this.components);
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstSongs = new System.Windows.Forms.ListView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStripContainer2.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.toolStripContainer4.ContentPanel.SuspendLayout();
            this.toolStripContainer4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.songToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.controlsToolStripMenuItem,
            this.accountToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1350, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.toolStripSeparator1,
            this.addFileToToolStripMenuItem,
            this.addFolderToLibraryToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playlistToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // playlistToolStripMenuItem
            // 
            this.playlistToolStripMenuItem.Name = "playlistToolStripMenuItem";
            this.playlistToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.playlistToolStripMenuItem.Text = "Playlist";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(182, 6);
            // 
            // addFileToToolStripMenuItem
            // 
            this.addFileToToolStripMenuItem.Name = "addFileToToolStripMenuItem";
            this.addFileToToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.addFileToToolStripMenuItem.Text = "Add File to Library";
            this.addFileToToolStripMenuItem.Click += new System.EventHandler(this.addFileToToolStripMenuItem_Click);
            // 
            // addFolderToLibraryToolStripMenuItem
            // 
            this.addFolderToLibraryToolStripMenuItem.Name = "addFolderToLibraryToolStripMenuItem";
            this.addFolderToLibraryToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.addFolderToLibraryToolStripMenuItem.Text = "Add Folder to Library";
            this.addFolderToLibraryToolStripMenuItem.Click += new System.EventHandler(this.addFolderToLibraryToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // songToolStripMenuItem
            // 
            this.songToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.songToolStripMenuItem.Name = "songToolStripMenuItem";
            this.songToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.songToolStripMenuItem.Text = "Song";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.artistToolStripMenuItem,
            this.albumToolStripMenuItem,
            this.songsToolStripMenuItem});
            this.viewToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // artistToolStripMenuItem
            // 
            this.artistToolStripMenuItem.Name = "artistToolStripMenuItem";
            this.artistToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.artistToolStripMenuItem.Text = "Artist";
            // 
            // albumToolStripMenuItem
            // 
            this.albumToolStripMenuItem.Name = "albumToolStripMenuItem";
            this.albumToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.albumToolStripMenuItem.Text = "Album";
            // 
            // songsToolStripMenuItem
            // 
            this.songsToolStripMenuItem.Name = "songsToolStripMenuItem";
            this.songsToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.songsToolStripMenuItem.Text = "Songs";
            // 
            // controlsToolStripMenuItem
            // 
            this.controlsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shuffleToolStripMenuItem,
            this.repeatToolStripMenuItem});
            this.controlsToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.controlsToolStripMenuItem.Name = "controlsToolStripMenuItem";
            this.controlsToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.controlsToolStripMenuItem.Text = "Controls";
            // 
            // shuffleToolStripMenuItem
            // 
            this.shuffleToolStripMenuItem.Name = "shuffleToolStripMenuItem";
            this.shuffleToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.shuffleToolStripMenuItem.Text = "Shuffle";
            // 
            // repeatToolStripMenuItem
            // 
            this.repeatToolStripMenuItem.Name = "repeatToolStripMenuItem";
            this.repeatToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.repeatToolStripMenuItem.Text = "Repeat";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AccessibleName = "Search";
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStrip1.BackgroundImage")));
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leftButton,
            this.playButton,
            this.rightButton,
            this.toolStripSeparator6,
            this.lblSong,
            this.toolStripSeparator5,
            this.toolStripSeparator2,
            this.toolStripSeparator8,
            this.toolStripSeparator3,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripButton6});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1350, 70);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // leftButton
            // 
            this.leftButton.AutoSize = false;
            this.leftButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.leftButton.Image = ((System.Drawing.Image)(resources.GetObject("leftButton.Image")));
            this.leftButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.leftButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.leftButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(60, 60);
            this.leftButton.Text = "toolStripButton1";
            this.leftButton.Click += new System.EventHandler(this.leftButton_Click);
            // 
            // playButton
            // 
            this.playButton.AutoSize = false;
            this.playButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.playButton.Image = global::Reproductor_de_Musica.Properties.Resources.play;
            this.playButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.playButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.playButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(60, 60);
            this.playButton.Text = "toolStripButton2";
            this.playButton.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // rightButton
            // 
            this.rightButton.AutoSize = false;
            this.rightButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rightButton.Image = ((System.Drawing.Image)(resources.GetObject("rightButton.Image")));
            this.rightButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.rightButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(60, 60);
            this.rightButton.Text = "toolStripButton3";
            this.rightButton.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 70);
            // 
            // lblSong
            // 
            this.lblSong.AutoSize = false;
            this.lblSong.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lblSong.BackgroundImage")));
            this.lblSong.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSong.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSong.Image = ((System.Drawing.Image)(resources.GetObject("lblSong.Image")));
            this.lblSong.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.lblSong.Name = "lblSong";
            this.lblSong.Size = new System.Drawing.Size(350, 67);
            this.lblSong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSong.Click += new System.EventHandler(this.toolStripLabel3_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 70);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 70);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 70);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 70);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 67);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 67);
            this.toolStripButton5.Text = "toolStripButton5";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(23, 67);
            this.toolStripButton6.Text = "toolStripButton6";
            // 
            // Player
            // 
            this.Player.Enabled = true;
            this.Player.Location = new System.Drawing.Point(214, 183);
            this.Player.Name = "Player";
            this.Player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Player.OcxState")));
            this.Player.Size = new System.Drawing.Size(323, 47);
            this.Player.TabIndex = 6;
            this.Player.Visible = false;
            this.Player.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.Player_PlayStateChange);
            this.Player.Enter += new System.EventHandler(this.Player_Enter);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 94);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 635);
            this.splitter1.TabIndex = 9;
            this.splitter1.TabStop = false;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.BackColor = System.Drawing.Color.Transparent;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.toolStripContainer2);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.toolStrip2);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(182, 440);
            // 
            // toolStripContainer1.LeftToolStripPanel
            // 
            this.toolStripContainer1.LeftToolStripPanel.BackColor = System.Drawing.Color.Transparent;
            this.toolStripContainer1.Location = new System.Drawing.Point(9, 128);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(182, 465);
            this.toolStripContainer1.TabIndex = 11;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Click += new System.EventHandler(this.toolStripContainer1_TopToolStripPanel_Click);
            // 
            // toolStripContainer2
            // 
            // 
            // toolStripContainer2.ContentPanel
            // 
            this.toolStripContainer2.ContentPanel.BackColor = System.Drawing.Color.Transparent;
            this.toolStripContainer2.ContentPanel.Size = new System.Drawing.Size(182, 440);
            this.toolStripContainer2.ContentPanel.Load += new System.EventHandler(this.toolStripContainer2_ContentPanel_Load);
            this.toolStripContainer2.Location = new System.Drawing.Point(182, 3);
            this.toolStripContainer2.Name = "toolStripContainer2";
            this.toolStripContainer2.Size = new System.Drawing.Size(182, 465);
            this.toolStripContainer2.TabIndex = 16;
            this.toolStripContainer2.Text = "toolStripContainer2";
            // 
            // toolStrip2
            // 
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripButton10,
            this.toolStripButton7,
            this.toolStripButton8,
            this.toolStripSeparator4,
            this.toolStripLabel2});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(182, 440);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(180, 20);
            this.toolStripLabel1.Text = "Library";
            this.toolStripLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripLabel1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.AutoSize = false;
            this.toolStripButton10.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripButton10.Image = global::Reproductor_de_Musica.Properties.Resources.descarga__2_;
            this.toolStripButton10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButton10.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.Size = new System.Drawing.Size(180, 30);
            this.toolStripButton10.Text = "Artists";
            this.toolStripButton10.Click += new System.EventHandler(this.toolStripButton10_Click);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.AutoSize = false;
            this.toolStripButton7.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButton7.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(180, 30);
            this.toolStripButton7.Text = "Albums";
            this.toolStripButton7.Click += new System.EventHandler(this.toolStripButton7_Click);
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.AutoSize = false;
            this.toolStripButton8.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButton8.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(180, 30);
            this.toolStripButton8.Text = "Songs";
            this.toolStripButton8.Click += new System.EventHandler(this.toolStripButton8_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(180, 6);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(180, 20);
            this.toolStripLabel2.Text = "Playlist";
            this.toolStripLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripLabel2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // volumeBar
            // 
            this.volumeBar.BackColor = System.Drawing.Color.Transparent;
            this.volumeBar.BorderColor = System.Drawing.Color.Transparent;
            this.volumeBar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volumeBar.ForeColor = System.Drawing.Color.Red;
            this.volumeBar.IndentHeight = 6;
            this.volumeBar.Location = new System.Drawing.Point(544, 24);
            this.volumeBar.Maximum = 10;
            this.volumeBar.Minimum = 0;
            this.volumeBar.Name = "volumeBar";
            this.volumeBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.volumeBar.Size = new System.Drawing.Size(28, 70);
            this.volumeBar.TabIndex = 13;
            this.volumeBar.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.volumeBar.TickColor = System.Drawing.Color.Transparent;
            this.volumeBar.TickHeight = 4;
            this.volumeBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.volumeBar.TrackerColor = System.Drawing.Color.White;
            this.volumeBar.TrackerSize = new System.Drawing.Size(16, 16);
            this.volumeBar.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.volumeBar.TrackLineHeight = 3;
            this.volumeBar.TrackLineSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.volumeBar.Value = 0;
            this.volumeBar.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.volumeBar_ValueChanged);
            // 
            // trackBar
            // 
            this.trackBar.BackColor = System.Drawing.Color.Transparent;
            this.trackBar.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.trackBar.CausesValidation = false;
            this.trackBar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trackBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.trackBar.IndentHeight = 6;
            this.trackBar.Location = new System.Drawing.Point(9, 94);
            this.trackBar.Maximum = 10;
            this.trackBar.Minimum = 0;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(563, 28);
            this.trackBar.TabIndex = 14;
            this.trackBar.TabStop = false;
            this.trackBar.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar.TickColor = System.Drawing.Color.Transparent;
            this.trackBar.TickHeight = 4;
            this.trackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar.TrackerColor = System.Drawing.Color.White;
            this.trackBar.TrackerSize = new System.Drawing.Size(16, 16);
            this.trackBar.TrackLineColor = System.Drawing.SystemColors.ButtonFace;
            this.trackBar.TrackLineHeight = 3;
            this.trackBar.TrackLineSelectedColor = System.Drawing.Color.Transparent;
            this.trackBar.Value = 0;
            this.trackBar.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.trackBar_ValueChanged);
            this.trackBar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.trackBar_MouseClick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.songInfoToolStripMenuItem,
            this.playNextToolStripMenuItem,
            this.playLaterToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(126, 92);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // songInfoToolStripMenuItem
            // 
            this.songInfoToolStripMenuItem.Name = "songInfoToolStripMenuItem";
            this.songInfoToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.songInfoToolStripMenuItem.Text = "Song Info";
            this.songInfoToolStripMenuItem.Click += new System.EventHandler(this.songInfoToolStripMenuItem_Click);
            // 
            // playNextToolStripMenuItem
            // 
            this.playNextToolStripMenuItem.Name = "playNextToolStripMenuItem";
            this.playNextToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.playNextToolStripMenuItem.Text = "Play Next";
            // 
            // playLaterToolStripMenuItem
            // 
            this.playLaterToolStripMenuItem.Name = "playLaterToolStripMenuItem";
            this.playLaterToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.playLaterToolStripMenuItem.Text = "Play Later";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // toolStripContainer4
            // 
            // 
            // toolStripContainer4.ContentPanel
            // 
            this.toolStripContainer4.ContentPanel.BackColor = System.Drawing.Color.Transparent;
            this.toolStripContainer4.ContentPanel.Controls.Add(this.toolStrip3);
            this.toolStripContainer4.ContentPanel.Size = new System.Drawing.Size(182, 437);
            this.toolStripContainer4.ContentPanel.Load += new System.EventHandler(this.toolStripContainer4_ContentPanel_Load);
            this.toolStripContainer4.Location = new System.Drawing.Point(191, 128);
            this.toolStripContainer4.Name = "toolStripContainer4";
            this.toolStripContainer4.Size = new System.Drawing.Size(182, 462);
            this.toolStripContainer4.TabIndex = 17;
            this.toolStripContainer4.Text = "toolStripContainer4";
            // 
            // toolStrip3
            // 
            this.toolStrip3.AutoSize = false;
            this.toolStrip3.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip3.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip3.Location = new System.Drawing.Point(0, 0);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(182, 437);
            this.toolStrip3.TabIndex = 0;
            this.toolStrip3.Text = "toolStrip3";
            this.toolStrip3.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip3_ItemClicked_1);
            // 
            // AlbumForArtist
            // 
            this.AlbumForArtist.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.AlbumForArtist.ImageSize = new System.Drawing.Size(100, 100);
            this.AlbumForArtist.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Song";
            this.columnHeader1.Width = 322;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Time";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Artist";
            this.columnHeader3.Width = 165;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Album";
            this.columnHeader4.Width = 169;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Tag = "";
            this.columnHeader5.Text = "Year";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Rating";
            // 
            // lstSongs
            // 
            this.lstSongs.BackColor = System.Drawing.SystemColors.Window;
            this.lstSongs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lstSongs.BackgroundImage")));
            this.lstSongs.BackgroundImageTiled = true;
            this.lstSongs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lstSongs.LargeImageList = this.AlbumForArtist;
            this.lstSongs.Location = new System.Drawing.Point(191, 128);
            this.lstSongs.Name = "lstSongs";
            this.lstSongs.Size = new System.Drawing.Size(1159, 465);
            this.lstSongs.TabIndex = 15;
            this.lstSongs.UseCompatibleStateImageBehavior = false;
            this.lstSongs.View = System.Windows.Forms.View.Details;
            this.lstSongs.Visible = false;
            this.lstSongs.SelectedIndexChanged += new System.EventHandler(this.lstSongs_SelectedIndexChanged);
            this.lstSongs.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstSongs_MouseClick);
            this.lstSongs.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstSongs_MouseDoubleClick);
            // 
            // listView1
            // 
            this.listView1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("listView1.BackgroundImage")));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.listView1.LargeImageList = this.AlbumForArtist;
            this.listView1.Location = new System.Drawing.Point(373, 128);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(977, 459);
            this.listView1.TabIndex = 18;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Visible = false;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick_1);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "";
            this.columnHeader7.Width = 23;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Song";
            this.columnHeader8.Width = 871;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Duration";
            this.columnHeader9.Width = 303;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Art";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // listView2
            // 
            this.listView2.LargeImageList = this.AlbumForArtist;
            this.listView2.Location = new System.Drawing.Point(191, 128);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(1159, 466);
            this.listView2.TabIndex = 19;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.lstSongs);
            this.Controls.Add(this.toolStripContainer4);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.volumeBar);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.listView2);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Odyssey";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStripContainer2.ResumeLayout(false);
            this.toolStripContainer2.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStripContainer4.ContentPanel.ResumeLayout(false);
            this.toolStripContainer4.ResumeLayout(false);
            this.toolStripContainer4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateDataSong();
            trackBar.Value = (int)Player.Ctlcontrols.currentPosition;
            volumeBar.Value = Player.settings.volume;

        }
        private void lstSongs_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            foreach (ListViewItem lista in lstSongs.SelectedItems)
            {
                Form2 data = new Form2();
            }
            
        }

        /*private void lstSongs_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }*/

        

        private void trackBar_MouseClick(object sender, MouseEventArgs e)
        {
            trackBarClick = true;
        }

        private void trackBar_ValueChanged(object sender, decimal value)
        {
            if (trackBarClick)
            {
                Player.Ctlcontrols.currentPosition = trackBar.Value;
                trackBarClick = false;
            }
        }

        private void volumeBar_ValueChanged(object sender, decimal value)
        {
            Player.settings.volume = volumeBar.Value;
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            if (!Artists.empty())
            {
                mode = 2;
                toolStrip3.Visible = false;
                listView2.Visible = false;
                listView1.Visible = false;
                lstSongs.Visible = true;
                drawOnSongList();
            }
        }

        private void Player_Enter(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Player_PlayStateChange(object sender, _WMPOCXEvents_PlayStateChangeEvent e)
        {
            UpdateDataSong();
        }
        public void UpdateDataSong()
        {
            if (Player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                //Max time of the actual mp3
                trackBar.Maximum = (int)Player.Ctlcontrols.currentItem.duration;
                timer1.Start();
                playButton.Image = Properties.Resources.pausa;
                Play = true;
                if(trackBar.Maximum-1 == trackBar.Value)
                {
                    playNext();
                }
                
            }
            else if (Player.playState == WMPLib.WMPPlayState.wmppsMediaEnded)//Not worked at all
            {
                //Console.WriteLine(Player.playState);
                playNext();
                Player.Ctlcontrols.play();
                //Console.WriteLine(Player.playState);

            }
            else if (Player.playState == WMPLib.WMPPlayState.wmppsTransitioning)
            {
                Player.Ctlcontrols.play();
            }
            else if (Player.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                timer1.Stop();
                playButton.Image = Properties.Resources.play;
                Play = false;
                if (trackBar.Maximum == trackBar.Value)
                {
                    playNext();
                }
            }
            
        }
        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            playNext();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playlistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFileToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem songToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton leftButton;
        private System.Windows.Forms.ToolStripButton playButton;
        private System.Windows.Forms.ToolStripButton rightButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem artistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem albumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem songsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shuffleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repeatToolStripMenuItem;
        private AxWMPLib.AxWindowsMediaPlayer Player;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton10;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripMenuItem addFolderToLibraryToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel lblSong;
        private XComponent.SliderBar.MACTrackBar trackBar;
        private XComponent.SliderBar.MACTrackBar volumeBar;
        private System.Windows.Forms.Timer timer1;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripSeparator toolStripSeparator8;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem songInfoToolStripMenuItem;
        private ToolStripMenuItem playNextToolStripMenuItem;
        private ToolStripMenuItem playLaterToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripContainer toolStripContainer2;
        private ToolStripContainer toolStripContainer4;
        private ToolStrip toolStrip3;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ListView lstSongs;
        private ImageList AlbumForArtist;
        private ListView listView1;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ListView listView2;
    }
}

