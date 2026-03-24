namespace BasicFacebookFeatures
{
    partial class FormMain
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
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAuthentication = new System.Windows.Forms.TabPage();
            this.buttonConnectAsDesig = new System.Windows.Forms.Button();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.textBoxAppID = new System.Windows.Forms.TextBox();
            this.tabFriendsAnalyzer = new System.Windows.Forms.TabPage();
            this.labelStatus = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonFindGhostFriends = new System.Windows.Forms.Button();
            this.pictureBoxFriend = new System.Windows.Forms.PictureBox();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.buttonFindActiveFriends = new System.Windows.Forms.Button();
            this.tabPhotoArchive = new System.Windows.Forms.TabPage();
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.buttonMoveToArchive = new System.Windows.Forms.Button();
            this.buttonDownloadAlbum = new System.Windows.Forms.Button();
            this.pictureBoxAlbumCover = new System.Windows.Forms.PictureBox();
            this.buttonLoadAlbums = new System.Windows.Forms.Button();
            this.numericUpDownYears = new System.Windows.Forms.NumericUpDown();
            this.labelYears = new System.Windows.Forms.Label();
            this.labelFriendsTitle = new System.Windows.Forms.Label();
            this.labelAlbumsTitle = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelAppTitle = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabAuthentication.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.tabFriendsAnalyzer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriend)).BeginInit();
            this.tabPhotoArchive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbumCover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYears)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            //
            // panelHeader
            //
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.panelHeader.Controls.Add(this.labelAppTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(984, 56);
            this.panelHeader.TabIndex = 60;
            //
            // labelAppTitle
            //
            this.labelAppTitle.AutoSize = true;
            this.labelAppTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAppTitle.ForeColor = System.Drawing.Color.White;
            this.labelAppTitle.Location = new System.Drawing.Point(16, 10);
            this.labelAppTitle.Name = "labelAppTitle";
            this.labelAppTitle.Size = new System.Drawing.Size(330, 37);
            this.labelAppTitle.TabIndex = 0;
            this.labelAppTitle.Text = "\uD83C\uDF10 Facebook Desktop App";
            //
            // tabControl1
            //
            this.tabControl1.Controls.Add(this.tabAuthentication);
            this.tabControl1.Controls.Add(this.tabFriendsAnalyzer);
            this.tabControl1.Controls.Add(this.tabPhotoArchive);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 56);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(20, 6);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(984, 524);
            this.tabControl1.TabIndex = 54;
            //
            // tabAuthentication
            //
            this.tabAuthentication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.tabAuthentication.Controls.Add(this.buttonConnectAsDesig);
            this.tabAuthentication.Controls.Add(this.pictureBoxProfile);
            this.tabAuthentication.Controls.Add(this.textBoxAppID);
            this.tabAuthentication.Controls.Add(this.label1);
            this.tabAuthentication.Controls.Add(this.buttonLogout);
            this.tabAuthentication.Controls.Add(this.buttonLogin);
            this.tabAuthentication.Location = new System.Drawing.Point(4, 36);
            this.tabAuthentication.Name = "tabAuthentication";
            this.tabAuthentication.Padding = new System.Windows.Forms.Padding(20);
            this.tabAuthentication.Size = new System.Drawing.Size(976, 484);
            this.tabAuthentication.TabIndex = 0;
            this.tabAuthentication.Text = "  \uD83D\uDD12 Authentication  ";
            //
            // buttonLogin
            //
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.Location = new System.Drawing.Point(30, 30);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(350, 50);
            this.buttonLogin.TabIndex = 36;
            this.buttonLogin.Text = "\uD83D\uDD11 Login with Facebook";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            //
            // buttonConnectAsDesig
            //
            this.buttonConnectAsDesig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.buttonConnectAsDesig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonConnectAsDesig.FlatAppearance.BorderSize = 0;
            this.buttonConnectAsDesig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConnectAsDesig.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnectAsDesig.ForeColor = System.Drawing.Color.White;
            this.buttonConnectAsDesig.Location = new System.Drawing.Point(30, 95);
            this.buttonConnectAsDesig.Name = "buttonConnectAsDesig";
            this.buttonConnectAsDesig.Size = new System.Drawing.Size(350, 50);
            this.buttonConnectAsDesig.TabIndex = 56;
            this.buttonConnectAsDesig.Text = "\u26A1 Quick Connect (Desig Patter)";
            this.buttonConnectAsDesig.UseVisualStyleBackColor = false;
            this.buttonConnectAsDesig.Click += new System.EventHandler(this.buttonConnectAsDesig_Click);
            //
            // buttonLogout
            //
            this.buttonLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.buttonLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogout.Enabled = false;
            this.buttonLogout.FlatAppearance.BorderSize = 0;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.ForeColor = System.Drawing.Color.White;
            this.buttonLogout.Location = new System.Drawing.Point(30, 160);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(350, 50);
            this.buttonLogout.TabIndex = 52;
            this.buttonLogout.Text = "\uD83D\uDEAA Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            //
            // pictureBoxProfile
            //
            this.pictureBoxProfile.BackColor = System.Drawing.Color.White;
            this.pictureBoxProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxProfile.Location = new System.Drawing.Point(30, 230);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(120, 120);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 55;
            this.pictureBoxProfile.TabStop = false;
            //
            // label1
            //
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label1.Location = new System.Drawing.Point(380, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 75);
            this.label1.TabIndex = 53;
            this.label1.Text = "This is the AppID of \"Design Patterns App 2.4\".\r\nThe grader will use it to test your app.\r\nType here your own AppID to test it:";
            //
            // textBoxAppID
            //
            this.textBoxAppID.BackColor = System.Drawing.Color.White;
            this.textBoxAppID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAppID.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAppID.Location = new System.Drawing.Point(383, 115);
            this.textBoxAppID.Name = "textBoxAppID";
            this.textBoxAppID.Size = new System.Drawing.Size(500, 30);
            this.textBoxAppID.TabIndex = 54;
            this.textBoxAppID.Text = "1450160541956417";
            //
            // tabFriendsAnalyzer
            //
            this.tabFriendsAnalyzer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.tabFriendsAnalyzer.Controls.Add(this.labelFriendsTitle);
            this.tabFriendsAnalyzer.Controls.Add(this.labelStatus);
            this.tabFriendsAnalyzer.Controls.Add(this.buttonReset);
            this.tabFriendsAnalyzer.Controls.Add(this.buttonFindGhostFriends);
            this.tabFriendsAnalyzer.Controls.Add(this.pictureBoxFriend);
            this.tabFriendsAnalyzer.Controls.Add(this.listBoxFriends);
            this.tabFriendsAnalyzer.Controls.Add(this.buttonFindActiveFriends);
            this.tabFriendsAnalyzer.Location = new System.Drawing.Point(4, 36);
            this.tabFriendsAnalyzer.Name = "tabFriendsAnalyzer";
            this.tabFriendsAnalyzer.Padding = new System.Windows.Forms.Padding(20);
            this.tabFriendsAnalyzer.Size = new System.Drawing.Size(976, 484);
            this.tabFriendsAnalyzer.TabIndex = 1;
            this.tabFriendsAnalyzer.Text = "  \uD83D\uDC65 Friends Analyzer  ";
            //
            // labelFriendsTitle
            //
            this.labelFriendsTitle.AutoSize = true;
            this.labelFriendsTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFriendsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.labelFriendsTitle.Location = new System.Drawing.Point(400, 20);
            this.labelFriendsTitle.Name = "labelFriendsTitle";
            this.labelFriendsTitle.Size = new System.Drawing.Size(80, 20);
            this.labelFriendsTitle.TabIndex = 10;
            this.labelFriendsTitle.Text = "Results:";
            //
            // buttonFindActiveFriends
            //
            this.buttonFindActiveFriends.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(183)))), ((int)(((byte)(42)))));
            this.buttonFindActiveFriends.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFindActiveFriends.FlatAppearance.BorderSize = 0;
            this.buttonFindActiveFriends.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFindActiveFriends.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFindActiveFriends.ForeColor = System.Drawing.Color.White;
            this.buttonFindActiveFriends.Location = new System.Drawing.Point(30, 50);
            this.buttonFindActiveFriends.Name = "buttonFindActiveFriends";
            this.buttonFindActiveFriends.Size = new System.Drawing.Size(320, 55);
            this.buttonFindActiveFriends.TabIndex = 0;
            this.buttonFindActiveFriends.Text = "\u2B50 Find Active Friends";
            this.buttonFindActiveFriends.UseVisualStyleBackColor = false;
            this.buttonFindActiveFriends.Click += new System.EventHandler(this.buttonFindActiveFriends_Click);
            //
            // buttonFindGhostFriends
            //
            this.buttonFindGhostFriends.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.buttonFindGhostFriends.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFindGhostFriends.FlatAppearance.BorderSize = 0;
            this.buttonFindGhostFriends.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFindGhostFriends.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFindGhostFriends.ForeColor = System.Drawing.Color.White;
            this.buttonFindGhostFriends.Location = new System.Drawing.Point(30, 125);
            this.buttonFindGhostFriends.Name = "buttonFindGhostFriends";
            this.buttonFindGhostFriends.Size = new System.Drawing.Size(320, 55);
            this.buttonFindGhostFriends.TabIndex = 3;
            this.buttonFindGhostFriends.Text = "\uD83D\uDC7B Find Ghost Friends";
            this.buttonFindGhostFriends.UseVisualStyleBackColor = false;
            this.buttonFindGhostFriends.Click += new System.EventHandler(this.buttonFindGhostFriends_Click);
            //
            // buttonReset
            //
            this.buttonReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.buttonReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReset.FlatAppearance.BorderSize = 0;
            this.buttonReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReset.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.ForeColor = System.Drawing.Color.White;
            this.buttonReset.Location = new System.Drawing.Point(30, 200);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(320, 55);
            this.buttonReset.TabIndex = 4;
            this.buttonReset.Text = "\uD83D\uDD04 Reset Analysis";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            //
            // listBoxFriends
            //
            this.listBoxFriends.BackColor = System.Drawing.Color.White;
            this.listBoxFriends.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxFriends.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 23;
            this.listBoxFriends.Location = new System.Drawing.Point(400, 50);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(340, 325);
            this.listBoxFriends.TabIndex = 1;
            this.listBoxFriends.SelectedIndexChanged += new System.EventHandler(this.listBoxFriends_SelectedIndexChanged);
            //
            // pictureBoxFriend
            //
            this.pictureBoxFriend.BackColor = System.Drawing.Color.White;
            this.pictureBoxFriend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxFriend.Location = new System.Drawing.Point(770, 50);
            this.pictureBoxFriend.Name = "pictureBoxFriend";
            this.pictureBoxFriend.Size = new System.Drawing.Size(160, 160);
            this.pictureBoxFriend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFriend.TabIndex = 2;
            this.pictureBoxFriend.TabStop = false;
            //
            // labelStatus
            //
            this.labelStatus.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.labelStatus.Location = new System.Drawing.Point(30, 280);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(320, 50);
            this.labelStatus.TabIndex = 5;
            this.labelStatus.Text = "Status: Waiting for scan";
            //
            // tabPhotoArchive
            //
            this.tabPhotoArchive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.tabPhotoArchive.Controls.Add(this.labelAlbumsTitle);
            this.tabPhotoArchive.Controls.Add(this.labelYears);
            this.tabPhotoArchive.Controls.Add(this.numericUpDownYears);
            this.tabPhotoArchive.Controls.Add(this.listBoxAlbums);
            this.tabPhotoArchive.Controls.Add(this.buttonMoveToArchive);
            this.tabPhotoArchive.Controls.Add(this.buttonDownloadAlbum);
            this.tabPhotoArchive.Controls.Add(this.pictureBoxAlbumCover);
            this.tabPhotoArchive.Controls.Add(this.buttonLoadAlbums);
            this.tabPhotoArchive.Location = new System.Drawing.Point(4, 36);
            this.tabPhotoArchive.Name = "tabPhotoArchive";
            this.tabPhotoArchive.Padding = new System.Windows.Forms.Padding(20);
            this.tabPhotoArchive.Size = new System.Drawing.Size(976, 484);
            this.tabPhotoArchive.TabIndex = 2;
            this.tabPhotoArchive.Text = "  \uD83D\uDCF7 Photo Archive  ";
            //
            // labelAlbumsTitle
            //
            this.labelAlbumsTitle.AutoSize = true;
            this.labelAlbumsTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlbumsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.labelAlbumsTitle.Location = new System.Drawing.Point(400, 20);
            this.labelAlbumsTitle.Name = "labelAlbumsTitle";
            this.labelAlbumsTitle.Size = new System.Drawing.Size(80, 20);
            this.labelAlbumsTitle.TabIndex = 20;
            this.labelAlbumsTitle.Text = "Albums:";
            //
            // buttonLoadAlbums
            //
            this.buttonLoadAlbums.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.buttonLoadAlbums.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLoadAlbums.FlatAppearance.BorderSize = 0;
            this.buttonLoadAlbums.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoadAlbums.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoadAlbums.ForeColor = System.Drawing.Color.White;
            this.buttonLoadAlbums.Location = new System.Drawing.Point(30, 50);
            this.buttonLoadAlbums.Name = "buttonLoadAlbums";
            this.buttonLoadAlbums.Size = new System.Drawing.Size(320, 55);
            this.buttonLoadAlbums.TabIndex = 6;
            this.buttonLoadAlbums.Text = "\uD83D\uDCC2 Load Albums";
            this.buttonLoadAlbums.UseVisualStyleBackColor = false;
            this.buttonLoadAlbums.Click += new System.EventHandler(this.buttonLoadAlbums_Click);
            //
            // buttonDownloadAlbum
            //
            this.buttonDownloadAlbum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(183)))), ((int)(((byte)(42)))));
            this.buttonDownloadAlbum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDownloadAlbum.FlatAppearance.BorderSize = 0;
            this.buttonDownloadAlbum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDownloadAlbum.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDownloadAlbum.ForeColor = System.Drawing.Color.White;
            this.buttonDownloadAlbum.Location = new System.Drawing.Point(30, 125);
            this.buttonDownloadAlbum.Name = "buttonDownloadAlbum";
            this.buttonDownloadAlbum.Size = new System.Drawing.Size(320, 55);
            this.buttonDownloadAlbum.TabIndex = 9;
            this.buttonDownloadAlbum.Text = "\u2B07 Download Album";
            this.buttonDownloadAlbum.UseVisualStyleBackColor = false;
            this.buttonDownloadAlbum.Click += new System.EventHandler(this.buttonDownloadAlbum_Click);
            //
            // buttonMoveToArchive
            //
            this.buttonMoveToArchive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.buttonMoveToArchive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMoveToArchive.FlatAppearance.BorderSize = 0;
            this.buttonMoveToArchive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMoveToArchive.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMoveToArchive.ForeColor = System.Drawing.Color.White;
            this.buttonMoveToArchive.Location = new System.Drawing.Point(30, 250);
            this.buttonMoveToArchive.Name = "buttonMoveToArchive";
            this.buttonMoveToArchive.Size = new System.Drawing.Size(320, 55);
            this.buttonMoveToArchive.TabIndex = 10;
            this.buttonMoveToArchive.Text = "\uD83D\uDCE6 Archive Old Photos";
            this.buttonMoveToArchive.UseVisualStyleBackColor = false;
            this.buttonMoveToArchive.Click += new System.EventHandler(this.buttonMoveToArchive_Click);
            //
            // labelYears
            //
            this.labelYears.AutoSize = true;
            this.labelYears.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYears.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.labelYears.Location = new System.Drawing.Point(30, 215);
            this.labelYears.Name = "labelYears";
            this.labelYears.Size = new System.Drawing.Size(200, 23);
            this.labelYears.TabIndex = 15;
            this.labelYears.Text = "Archive photos older than:";
            //
            // numericUpDownYears
            //
            this.numericUpDownYears.BackColor = System.Drawing.Color.White;
            this.numericUpDownYears.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownYears.Location = new System.Drawing.Point(250, 212);
            this.numericUpDownYears.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            this.numericUpDownYears.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numericUpDownYears.Name = "numericUpDownYears";
            this.numericUpDownYears.Size = new System.Drawing.Size(70, 32);
            this.numericUpDownYears.TabIndex = 13;
            this.numericUpDownYears.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownYears.Value = new decimal(new int[] { 3, 0, 0, 0 });
            //
            // listBoxAlbums
            //
            this.listBoxAlbums.BackColor = System.Drawing.Color.White;
            this.listBoxAlbums.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxAlbums.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.ItemHeight = 23;
            this.listBoxAlbums.Location = new System.Drawing.Point(400, 50);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(340, 325);
            this.listBoxAlbums.TabIndex = 12;
            this.listBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.listBoxAlbums_SelectedIndexChanged);
            //
            // pictureBoxAlbumCover
            //
            this.pictureBoxAlbumCover.BackColor = System.Drawing.Color.White;
            this.pictureBoxAlbumCover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxAlbumCover.Location = new System.Drawing.Point(770, 50);
            this.pictureBoxAlbumCover.Name = "pictureBoxAlbumCover";
            this.pictureBoxAlbumCover.Size = new System.Drawing.Size(170, 170);
            this.pictureBoxAlbumCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAlbumCover.TabIndex = 8;
            this.pictureBoxAlbumCover.TabStop = false;
            //
            // FormMain
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(984, 580);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panelHeader);
            this.MinimumSize = new System.Drawing.Size(1000, 620);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook Desktop App";
            this.tabControl1.ResumeLayout(false);
            this.tabAuthentication.ResumeLayout(false);
            this.tabAuthentication.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.tabFriendsAnalyzer.ResumeLayout(false);
            this.tabFriendsAnalyzer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriend)).EndInit();
            this.tabPhotoArchive.ResumeLayout(false);
            this.tabPhotoArchive.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbumCover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYears)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Button buttonLogin;
		private System.Windows.Forms.Button buttonLogout;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabAuthentication;
		private System.Windows.Forms.TabPage tabFriendsAnalyzer;
        private System.Windows.Forms.TextBox textBoxAppID;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Button buttonConnectAsDesig;
        private System.Windows.Forms.Button buttonFindActiveFriends;
        private System.Windows.Forms.Button buttonFindGhostFriends;
        private System.Windows.Forms.PictureBox pictureBoxFriend;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.TabPage tabPhotoArchive;
        private System.Windows.Forms.Button buttonMoveToArchive;
        private System.Windows.Forms.Button buttonDownloadAlbum;
        private System.Windows.Forms.PictureBox pictureBoxAlbumCover;
        private System.Windows.Forms.Button buttonLoadAlbums;
        private System.Windows.Forms.ListBox listBoxAlbums;
        private System.Windows.Forms.NumericUpDown numericUpDownYears;
        private System.Windows.Forms.Label labelYears;
        private System.Windows.Forms.Label labelFriendsTitle;
        private System.Windows.Forms.Label labelAlbumsTitle;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelAppTitle;
    }
}