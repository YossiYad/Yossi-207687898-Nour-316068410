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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBoxAlbumCover = new System.Windows.Forms.PictureBox();
            this.buttonLoadAlbums = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabAuthentication.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.tabFriendsAnalyzer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriend)).BeginInit();
            this.tabPhotoArchive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbumCover)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(18, 17);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(268, 44);
            this.buttonLogin.TabIndex = 36;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Enabled = false;
            this.buttonLogout.Location = new System.Drawing.Point(18, 121);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(268, 43);
            this.buttonLogout.TabIndex = 52;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 54);
            this.label1.TabIndex = 53;
            this.label1.Text = "This is the AppID of \"Design Patterns App 2.4\".\r\nThe grader will use it to test y" +
    "our app.\r\nType here your own AppID to test it:\r\n";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabAuthentication);
            this.tabControl1.Controls.Add(this.tabFriendsAnalyzer);
            this.tabControl1.Controls.Add(this.tabPhotoArchive);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(862, 370);
            this.tabControl1.TabIndex = 54;
            // 
            // tabAuthentication
            // 
            this.tabAuthentication.Controls.Add(this.buttonConnectAsDesig);
            this.tabAuthentication.Controls.Add(this.pictureBoxProfile);
            this.tabAuthentication.Controls.Add(this.textBoxAppID);
            this.tabAuthentication.Controls.Add(this.label1);
            this.tabAuthentication.Controls.Add(this.buttonLogout);
            this.tabAuthentication.Controls.Add(this.buttonLogin);
            this.tabAuthentication.Location = new System.Drawing.Point(4, 27);
            this.tabAuthentication.Name = "tabAuthentication";
            this.tabAuthentication.Padding = new System.Windows.Forms.Padding(3);
            this.tabAuthentication.Size = new System.Drawing.Size(854, 339);
            this.tabAuthentication.TabIndex = 0;
            this.tabAuthentication.Text = "Authentication";
            this.tabAuthentication.UseVisualStyleBackColor = true;
            // 
            // buttonConnectAsDesig
            // 
            this.buttonConnectAsDesig.Location = new System.Drawing.Point(18, 69);
            this.buttonConnectAsDesig.Margin = new System.Windows.Forms.Padding(4);
            this.buttonConnectAsDesig.Name = "buttonConnectAsDesig";
            this.buttonConnectAsDesig.Size = new System.Drawing.Size(268, 44);
            this.buttonConnectAsDesig.TabIndex = 56;
            this.buttonConnectAsDesig.Text = "Connect As Desig";
            this.buttonConnectAsDesig.UseVisualStyleBackColor = true;
            this.buttonConnectAsDesig.Click += new System.EventHandler(this.buttonConnectAsDesig_Click);
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(18, 171);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(79, 78);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 55;
            this.pictureBoxProfile.TabStop = false;
            // 
            // textBoxAppID
            // 
            this.textBoxAppID.Location = new System.Drawing.Point(319, 126);
            this.textBoxAppID.Name = "textBoxAppID";
            this.textBoxAppID.Size = new System.Drawing.Size(446, 24);
            this.textBoxAppID.TabIndex = 54;
            this.textBoxAppID.Text = "1450160541956417";
            // 
            // tabFriendsAnalyzer
            // 
            this.tabFriendsAnalyzer.Controls.Add(this.labelStatus);
            this.tabFriendsAnalyzer.Controls.Add(this.buttonReset);
            this.tabFriendsAnalyzer.Controls.Add(this.buttonFindGhostFriends);
            this.tabFriendsAnalyzer.Controls.Add(this.pictureBoxFriend);
            this.tabFriendsAnalyzer.Controls.Add(this.listBoxFriends);
            this.tabFriendsAnalyzer.Controls.Add(this.buttonFindActiveFriends);
            this.tabFriendsAnalyzer.Location = new System.Drawing.Point(4, 27);
            this.tabFriendsAnalyzer.Name = "tabFriendsAnalyzer";
            this.tabFriendsAnalyzer.Padding = new System.Windows.Forms.Padding(3);
            this.tabFriendsAnalyzer.Size = new System.Drawing.Size(854, 339);
            this.tabFriendsAnalyzer.TabIndex = 1;
            this.tabFriendsAnalyzer.Text = "Friends Analyzer";
            this.tabFriendsAnalyzer.UseVisualStyleBackColor = true;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(59, 277);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(165, 18);
            this.labelStatus.TabIndex = 5;
            this.labelStatus.Text = "Status: Waiting for scan";
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(39, 206);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(223, 41);
            this.buttonReset.TabIndex = 4;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonFindGhostFriends
            // 
            this.buttonFindGhostFriends.Location = new System.Drawing.Point(39, 135);
            this.buttonFindGhostFriends.Name = "buttonFindGhostFriends";
            this.buttonFindGhostFriends.Size = new System.Drawing.Size(223, 42);
            this.buttonFindGhostFriends.TabIndex = 3;
            this.buttonFindGhostFriends.Text = "Find Ghost Friends";
            this.buttonFindGhostFriends.UseVisualStyleBackColor = true;
            this.buttonFindGhostFriends.Click += new System.EventHandler(this.buttonFindGhostFriends_Click);
            // 
            // pictureBoxFriend
            // 
            this.pictureBoxFriend.Location = new System.Drawing.Point(615, 67);
            this.pictureBoxFriend.Name = "pictureBoxFriend";
            this.pictureBoxFriend.Size = new System.Drawing.Size(100, 86);
            this.pictureBoxFriend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFriend.TabIndex = 2;
            this.pictureBoxFriend.TabStop = false;
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 18;
            this.listBoxFriends.Location = new System.Drawing.Point(385, 67);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(223, 202);
            this.listBoxFriends.TabIndex = 1;
            this.listBoxFriends.SelectedIndexChanged += new System.EventHandler(this.listBoxFriends_SelectedIndexChanged);
            // 
            // buttonFindActiveFriends
            // 
            this.buttonFindActiveFriends.Location = new System.Drawing.Point(39, 67);
            this.buttonFindActiveFriends.Name = "buttonFindActiveFriends";
            this.buttonFindActiveFriends.Size = new System.Drawing.Size(223, 43);
            this.buttonFindActiveFriends.TabIndex = 0;
            this.buttonFindActiveFriends.Text = "Find Active Friends";
            this.buttonFindActiveFriends.UseVisualStyleBackColor = true;
            this.buttonFindActiveFriends.Click += new System.EventHandler(this.buttonFindActiveFriends_Click);
            // 
            // tabPicturesArchive
            // 
            this.tabPhotoArchive.Controls.Add(this.listBoxAlbums);
            this.tabPhotoArchive.Controls.Add(this.button1);
            this.tabPhotoArchive.Controls.Add(this.button2);
            this.tabPhotoArchive.Controls.Add(this.pictureBoxAlbumCover);
            this.tabPhotoArchive.Controls.Add(this.buttonLoadAlbums);
            this.tabPhotoArchive.Location = new System.Drawing.Point(4, 27);
            this.tabPhotoArchive.Name = "tabPicturesArchive";
            this.tabPhotoArchive.Padding = new System.Windows.Forms.Padding(3);
            this.tabPhotoArchive.Size = new System.Drawing.Size(854, 339);
            this.tabPhotoArchive.TabIndex = 2;
            this.tabPhotoArchive.Text = "Photo Archive";
            this.tabPhotoArchive.UseVisualStyleBackColor = true;
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.ItemHeight = 18;
            this.listBoxAlbums.Location = new System.Drawing.Point(422, 76);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(186, 184);
            this.listBoxAlbums.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 41);
            this.button1.TabIndex = 10;
            this.button1.Text = "Move to archive";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(38, 144);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(223, 42);
            this.button2.TabIndex = 9;
            this.button2.Text = "Download album";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // pictureBoxAlbumCover
            // 
            this.pictureBoxAlbumCover.Location = new System.Drawing.Point(614, 76);
            this.pictureBoxAlbumCover.Name = "pictureBoxAlbumCover";
            this.pictureBoxAlbumCover.Size = new System.Drawing.Size(100, 86);
            this.pictureBoxAlbumCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAlbumCover.TabIndex = 8;
            this.pictureBoxAlbumCover.TabStop = false;
            // 
            // buttonLoadAlbums
            // 
            this.buttonLoadAlbums.Location = new System.Drawing.Point(38, 76);
            this.buttonLoadAlbums.Name = "buttonLoadAlbums";
            this.buttonLoadAlbums.Size = new System.Drawing.Size(223, 43);
            this.buttonLoadAlbums.TabIndex = 6;
            this.buttonLoadAlbums.Text = "Upload albums";
            this.buttonLoadAlbums.UseVisualStyleBackColor = true;
            this.buttonLoadAlbums.Click += new System.EventHandler(this.buttonLoadAlbums_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 370);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabAuthentication.ResumeLayout(false);
            this.tabAuthentication.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.tabFriendsAnalyzer.ResumeLayout(false);
            this.tabFriendsAnalyzer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriend)).EndInit();
            this.tabPhotoArchive.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbumCover)).EndInit();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBoxAlbumCover;
        private System.Windows.Forms.Button buttonLoadAlbums;
        private System.Windows.Forms.ListBox listBoxAlbums;
    }
}

