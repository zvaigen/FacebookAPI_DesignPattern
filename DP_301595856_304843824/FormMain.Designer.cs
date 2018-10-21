namespace DP_301595856_304843824
{
    public partial class FormMain
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
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.PictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.TextProfile = new System.Windows.Forms.TextBox();
            this.listBoxAboutMe = new System.Windows.Forms.ListBox();
            this.buttonShowFriends = new System.Windows.Forms.Button();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.listBoxLikePages = new System.Windows.Forms.ListBox();
            this.buttonShowEvents = new System.Windows.Forms.Button();
            this.buttonLikePages = new System.Windows.Forms.Button();
            this.buttonHoroscopeFeature = new System.Windows.Forms.Button();
            this.buttonCommonPhotosFeature = new System.Windows.Forms.Button();
            this.buttonPostStatus = new System.Windows.Forms.Button();
            this.pictureBoxFriends = new System.Windows.Forms.PictureBox();
            this.pictureBoxPage = new System.Windows.Forms.PictureBox();
            this.pictureBoxEvent = new System.Windows.Forms.PictureBox();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.pictureBoxCommonPhoto = new System.Windows.Forms.PictureBox();
            this.listBoxCommonPhoto = new System.Windows.Forms.ListBox();
            this.comboBoxAppId = new System.Windows.Forms.ComboBox();
            this.AppId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriends)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCommonPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.BackColor = System.Drawing.SystemColors.Highlight;
            this.ButtonLogin.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ButtonLogin.Location = new System.Drawing.Point(12, 9);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(149, 43);
            this.ButtonLogin.TabIndex = 2;
            this.ButtonLogin.Text = "Facebook Login";
            this.ButtonLogin.UseVisualStyleBackColor = false;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.Crimson;
            this.buttonLogout.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonLogout.Location = new System.Drawing.Point(1091, 587);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(190, 40);
            this.buttonLogout.TabIndex = 4;
            this.buttonLogout.Text = "Facebook Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // PictureBoxProfile
            // 
            this.PictureBoxProfile.BackColor = System.Drawing.SystemColors.Info;
            this.PictureBoxProfile.Location = new System.Drawing.Point(12, 201);
            this.PictureBoxProfile.Name = "PictureBoxProfile";
            this.PictureBoxProfile.Size = new System.Drawing.Size(149, 144);
            this.PictureBoxProfile.TabIndex = 5;
            this.PictureBoxProfile.TabStop = false;
            // 
            // TextProfile
            // 
            this.TextProfile.BackColor = System.Drawing.SystemColors.Menu;
            this.TextProfile.Enabled = false;
            this.TextProfile.ForeColor = System.Drawing.SystemColors.InfoText;
            this.TextProfile.Location = new System.Drawing.Point(12, 155);
            this.TextProfile.Name = "TextProfile";
            this.TextProfile.Size = new System.Drawing.Size(149, 26);
            this.TextProfile.TabIndex = 6;
            // 
            // listBoxAboutMe
            // 
            this.listBoxAboutMe.FormattingEnabled = true;
            this.listBoxAboutMe.ItemHeight = 20;
            this.listBoxAboutMe.Location = new System.Drawing.Point(12, 356);
            this.listBoxAboutMe.Name = "listBoxAboutMe";
            this.listBoxAboutMe.Size = new System.Drawing.Size(241, 104);
            this.listBoxAboutMe.TabIndex = 7;
            // 
            // buttonShowFriends
            // 
            this.buttonShowFriends.Location = new System.Drawing.Point(206, 49);
            this.buttonShowFriends.Name = "buttonShowFriends";
            this.buttonShowFriends.Size = new System.Drawing.Size(142, 39);
            this.buttonShowFriends.TabIndex = 8;
            this.buttonShowFriends.Text = "Show Friends";
            this.buttonShowFriends.UseVisualStyleBackColor = true;
            this.buttonShowFriends.Click += new System.EventHandler(this.buttonShowFriends_Click);
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 20;
            this.listBoxFriends.Location = new System.Drawing.Point(206, 109);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(306, 144);
            this.listBoxFriends.TabIndex = 9;
            this.listBoxFriends.SelectedIndexChanged += new System.EventHandler(this.listBoxFriends_SelectedIndexChanged);
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.ItemHeight = 20;
            this.listBoxEvents.Location = new System.Drawing.Point(564, 109);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(323, 144);
            this.listBoxEvents.TabIndex = 10;
            this.listBoxEvents.SelectedIndexChanged += new System.EventHandler(this.listBoxEvents_SelectedIndexChanged);
            // 
            // listBoxLikePages
            // 
            this.listBoxLikePages.FormattingEnabled = true;
            this.listBoxLikePages.ItemHeight = 20;
            this.listBoxLikePages.Location = new System.Drawing.Point(944, 109);
            this.listBoxLikePages.Name = "listBoxLikePages";
            this.listBoxLikePages.Size = new System.Drawing.Size(325, 144);
            this.listBoxLikePages.TabIndex = 11;
            this.listBoxLikePages.SelectedIndexChanged += new System.EventHandler(this.listBoxLikePages_SelectedIndexChanged);
            // 
            // buttonShowEvents
            // 
            this.buttonShowEvents.Location = new System.Drawing.Point(564, 49);
            this.buttonShowEvents.Name = "buttonShowEvents";
            this.buttonShowEvents.Size = new System.Drawing.Size(142, 39);
            this.buttonShowEvents.TabIndex = 12;
            this.buttonShowEvents.Text = "Show Events";
            this.buttonShowEvents.UseVisualStyleBackColor = true;
            this.buttonShowEvents.Click += new System.EventHandler(this.buttonShowEvents_Click);
            // 
            // buttonLikePages
            // 
            this.buttonLikePages.Location = new System.Drawing.Point(944, 56);
            this.buttonLikePages.Name = "buttonLikePages";
            this.buttonLikePages.Size = new System.Drawing.Size(142, 39);
            this.buttonLikePages.TabIndex = 13;
            this.buttonLikePages.Text = "Show Pages";
            this.buttonLikePages.UseVisualStyleBackColor = true;
            this.buttonLikePages.Click += new System.EventHandler(this.buttonLikePages_Click);
            // 
            // buttonHoroscopeFeature
            // 
            this.buttonHoroscopeFeature.Location = new System.Drawing.Point(340, 305);
            this.buttonHoroscopeFeature.Name = "buttonHoroscopeFeature";
            this.buttonHoroscopeFeature.Size = new System.Drawing.Size(149, 66);
            this.buttonHoroscopeFeature.TabIndex = 14;
            this.buttonHoroscopeFeature.Text = "Horoscope";
            this.buttonHoroscopeFeature.UseVisualStyleBackColor = true;
            this.buttonHoroscopeFeature.Click += new System.EventHandler(this.buttonHoroscopeFeature_Click);
            // 
            // buttonCommonPhotosFeature
            // 
            this.buttonCommonPhotosFeature.Location = new System.Drawing.Point(564, 305);
            this.buttonCommonPhotosFeature.Name = "buttonCommonPhotosFeature";
            this.buttonCommonPhotosFeature.Size = new System.Drawing.Size(323, 40);
            this.buttonCommonPhotosFeature.TabIndex = 15;
            this.buttonCommonPhotosFeature.Text = "Common Photo with:";
            this.buttonCommonPhotosFeature.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCommonPhotosFeature.UseVisualStyleBackColor = true;
            this.buttonCommonPhotosFeature.Click += new System.EventHandler(this.buttonCommonPhotosFeature_Click);
            // 
            // buttonPostStatus
            // 
            this.buttonPostStatus.Location = new System.Drawing.Point(12, 488);
            this.buttonPostStatus.Name = "buttonPostStatus";
            this.buttonPostStatus.Size = new System.Drawing.Size(119, 32);
            this.buttonPostStatus.TabIndex = 16;
            this.buttonPostStatus.Text = "Post Status";
            this.buttonPostStatus.UseVisualStyleBackColor = true;
            this.buttonPostStatus.Click += new System.EventHandler(this.buttonPostStatus_Click);
            // 
            // pictureBoxFriends
            // 
            this.pictureBoxFriends.Location = new System.Drawing.Point(406, 35);
            this.pictureBoxFriends.Name = "pictureBoxFriends";
            this.pictureBoxFriends.Size = new System.Drawing.Size(106, 63);
            this.pictureBoxFriends.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFriends.TabIndex = 17;
            this.pictureBoxFriends.TabStop = false;
            // 
            // pictureBoxPage
            // 
            this.pictureBoxPage.Location = new System.Drawing.Point(1169, 32);
            this.pictureBoxPage.Name = "pictureBoxPage";
            this.pictureBoxPage.Size = new System.Drawing.Size(100, 63);
            this.pictureBoxPage.TabIndex = 18;
            this.pictureBoxPage.TabStop = false;
            // 
            // pictureBoxEvent
            // 
            this.pictureBoxEvent.Location = new System.Drawing.Point(787, 35);
            this.pictureBoxEvent.Name = "pictureBoxEvent";
            this.pictureBoxEvent.Size = new System.Drawing.Size(100, 63);
            this.pictureBoxEvent.TabIndex = 19;
            this.pictureBoxEvent.TabStop = false;
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(12, 537);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(477, 26);
            this.textBoxStatus.TabIndex = 20;
            // 
            // pictureBoxCommonPhoto
            // 
            this.pictureBoxCommonPhoto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBoxCommonPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxCommonPhoto.Location = new System.Drawing.Point(564, 371);
            this.pictureBoxCommonPhoto.Name = "pictureBoxCommonPhoto";
            this.pictureBoxCommonPhoto.Size = new System.Drawing.Size(323, 204);
            this.pictureBoxCommonPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCommonPhoto.TabIndex = 21;
            this.pictureBoxCommonPhoto.TabStop = false;
            // 
            // listBoxCommonPhoto
            // 
            this.listBoxCommonPhoto.FormattingEnabled = true;
            this.listBoxCommonPhoto.ItemHeight = 20;
            this.listBoxCommonPhoto.Location = new System.Drawing.Point(917, 371);
            this.listBoxCommonPhoto.Name = "listBoxCommonPhoto";
            this.listBoxCommonPhoto.Size = new System.Drawing.Size(131, 204);
            this.listBoxCommonPhoto.TabIndex = 22;
            this.listBoxCommonPhoto.SelectedIndexChanged += new System.EventHandler(this.listBoxCommonPhoto_SelectedIndexChanged);
            // 
            // comboBoxAppId
            // 
            this.comboBoxAppId.FormattingEnabled = true;
            this.comboBoxAppId.Items.AddRange(new object[] {
            "1450160541956417  ",
            "140687806576513"});
            this.comboBoxAppId.Location = new System.Drawing.Point(13, 109);
            this.comboBoxAppId.Name = "comboBoxAppId";
            this.comboBoxAppId.Size = new System.Drawing.Size(187, 28);
            this.comboBoxAppId.TabIndex = 23;
            this.comboBoxAppId.SelectedIndexChanged += new System.EventHandler(this.comboBoxAppId_SelectedIndexChanged);
            // 
            // AppId
            // 
            this.AppId.Location = new System.Drawing.Point(12, 78);
            this.AppId.Name = "AppId";
            this.AppId.Size = new System.Drawing.Size(162, 28);
            this.AppId.TabIndex = 24;
            this.AppId.Text = "AppId Combo Box";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 629);
            this.Controls.Add(this.AppId);
            this.Controls.Add(this.comboBoxAppId);
            this.Controls.Add(this.listBoxCommonPhoto);
            this.Controls.Add(this.pictureBoxCommonPhoto);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.pictureBoxEvent);
            this.Controls.Add(this.pictureBoxPage);
            this.Controls.Add(this.pictureBoxFriends);
            this.Controls.Add(this.buttonPostStatus);
            this.Controls.Add(this.buttonCommonPhotosFeature);
            this.Controls.Add(this.buttonHoroscopeFeature);
            this.Controls.Add(this.buttonLikePages);
            this.Controls.Add(this.buttonShowEvents);
            this.Controls.Add(this.listBoxLikePages);
            this.Controls.Add(this.listBoxEvents);
            this.Controls.Add(this.listBoxFriends);
            this.Controls.Add(this.buttonShowFriends);
            this.Controls.Add(this.listBoxAboutMe);
            this.Controls.Add(this.TextProfile);
            this.Controls.Add(this.PictureBoxProfile);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.ButtonLogin);
            this.Name = "FormMain";
            this.Text = "Facebook Application Nadav & Liad";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriends)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCommonPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonLogin;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.PictureBox PictureBoxProfile;
        private System.Windows.Forms.TextBox TextProfile;
        private System.Windows.Forms.ListBox listBoxAboutMe;
        private System.Windows.Forms.Button buttonShowFriends;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.ListBox listBoxLikePages;
        private System.Windows.Forms.Button buttonShowEvents;
        private System.Windows.Forms.Button buttonLikePages;
        private System.Windows.Forms.Button buttonHoroscopeFeature;
        private System.Windows.Forms.Button buttonCommonPhotosFeature;
        private System.Windows.Forms.Button buttonPostStatus;
        private System.Windows.Forms.PictureBox pictureBoxFriends;
        private System.Windows.Forms.PictureBox pictureBoxPage;
        private System.Windows.Forms.PictureBox pictureBoxEvent;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.PictureBox pictureBoxCommonPhoto;
        private System.Windows.Forms.ListBox listBoxCommonPhoto;
        private System.Windows.Forms.ComboBox comboBoxAppId;
        private System.Windows.Forms.Label AppId;
    }
}