using FacebookExtensionApp.HomePage.Model;

namespace FacebookExtensionApp.HomePage.View
{
    public partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBoxCoverPhoto = new System.Windows.Forms.PictureBox();
            this.labelUserName = new System.Windows.Forms.Label();
            this.buttonLogIn = new System.Windows.Forms.Button();
            this.checkBoxRememberUser = new System.Windows.Forms.CheckBox();
            this.buttonHome = new FeatureButton();
            this.buttonSoulmateFounder = new FeatureButton();
            this.buttonTravelDiary = new FeatureButton();
            this.panelWelcome = new System.Windows.Forms.Panel();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.pictureBoxProfilePicture = new System.Windows.Forms.PictureBox();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.labelLoading = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoverPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxCoverPhoto
            // 
            this.pictureBoxCoverPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxCoverPhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.pictureBoxCoverPhoto.Location = new System.Drawing.Point(-3, -23);
            this.pictureBoxCoverPhoto.Name = "pictureBoxCoverPhoto";
            this.pictureBoxCoverPhoto.Size = new System.Drawing.Size(1114, 216);
            this.pictureBoxCoverPhoto.TabIndex = 3;
            this.pictureBoxCoverPhoto.TabStop = false;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelUserName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelUserName.Location = new System.Drawing.Point(198, 151);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(191, 29);
            this.labelUserName.TabIndex = 5;
            this.labelUserName.Text = "Facebook User";
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLogIn.Location = new System.Drawing.Point(12, 8);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.Size = new System.Drawing.Size(54, 23);
            this.buttonLogIn.TabIndex = 6;
            this.buttonLogIn.Text = "Log In";
            this.buttonLogIn.UseVisualStyleBackColor = true;
            this.buttonLogIn.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // checkBoxRememberUser
            // 
            this.checkBoxRememberUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.checkBoxRememberUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBoxRememberUser.Location = new System.Drawing.Point(72, 10);
            this.checkBoxRememberUser.Name = "checkBoxRememberUser";
            this.checkBoxRememberUser.Size = new System.Drawing.Size(104, 24);
            this.checkBoxRememberUser.TabIndex = 7;
            this.checkBoxRememberUser.Text = "Remmember Me";
            this.checkBoxRememberUser.UseVisualStyleBackColor = false;
            this.checkBoxRememberUser.CheckedChanged += new System.EventHandler(this.checkBoxRememberUser_CheckedChanged);
            // 
            // buttonHome
            // 
            this.buttonHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonHome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonHome.Location = new System.Drawing.Point(780, 146);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(109, 42);
            this.buttonHome.TabIndex = 9;
            this.buttonHome.Text = "Home";
            this.buttonHome.UseVisualStyleBackColor = false;
            // 
            // buttonSoulmateFounder
            // 
            this.buttonSoulmateFounder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.buttonSoulmateFounder.FlatAppearance.BorderSize = 0;
            this.buttonSoulmateFounder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSoulmateFounder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonSoulmateFounder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSoulmateFounder.Location = new System.Drawing.Point(992, 146);
            this.buttonSoulmateFounder.Name = "buttonSoulmateFounder";
            this.buttonSoulmateFounder.Size = new System.Drawing.Size(109, 42);
            this.buttonSoulmateFounder.TabIndex = 10;
            this.buttonSoulmateFounder.Text = "Soulmate Founder";
            this.buttonSoulmateFounder.UseVisualStyleBackColor = false;
            // 
            // buttonTravelDiary
            // 
            this.buttonTravelDiary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.buttonTravelDiary.FlatAppearance.BorderSize = 0;
            this.buttonTravelDiary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTravelDiary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonTravelDiary.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonTravelDiary.Location = new System.Drawing.Point(884, 146);
            this.buttonTravelDiary.Name = "buttonTravelDiary";
            this.buttonTravelDiary.Size = new System.Drawing.Size(109, 42);
            this.buttonTravelDiary.TabIndex = 11;
            this.buttonTravelDiary.Text = "Travel Diary";
            this.buttonTravelDiary.UseVisualStyleBackColor = false;
            // 
            // panelWelcome
            // 
            this.panelWelcome.Location = new System.Drawing.Point(3, 194);
            this.panelWelcome.Name = "panelWelcome";
            this.panelWelcome.Size = new System.Drawing.Size(1101, 431);
            this.panelWelcome.TabIndex = 12;
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelWelcome.Location = new System.Drawing.Point(15, 42);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(571, 31);
            this.labelWelcome.TabIndex = 0;
            this.labelWelcome.Text = "Welcome to our Facebook app, please log in...";
            // 
            // pictureBoxProfilePicture
            // 
            this.pictureBoxProfilePicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.pictureBoxProfilePicture.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxProfilePicture.Image")));
            this.pictureBoxProfilePicture.Location = new System.Drawing.Point(22, 56);
            this.pictureBoxProfilePicture.Name = "pictureBoxProfilePicture";
            this.pictureBoxProfilePicture.Size = new System.Drawing.Size(170, 152);
            this.pictureBoxProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfilePicture.TabIndex = 13;
            this.pictureBoxProfilePicture.TabStop = false;
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLogOut.Location = new System.Drawing.Point(12, 8);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(54, 23);
            this.buttonLogOut.TabIndex = 14;
            this.buttonLogOut.Text = "Log Out";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // labelLoading
            // 
            this.labelLoading.AutoSize = true;
            this.labelLoading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.labelLoading.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelLoading.Font = new System.Drawing.Font("Gisha", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoading.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelLoading.Location = new System.Drawing.Point(466, 76);
            this.labelLoading.Name = "labelLoading";
            this.labelLoading.Size = new System.Drawing.Size(206, 47);
            this.labelLoading.TabIndex = 15;
            this.labelLoading.Text = "Loading...";
            this.labelLoading.Visible = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(227)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1105, 625);
            this.Controls.Add(this.labelLoading);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.pictureBoxProfilePicture);
            this.Controls.Add(this.panelWelcome);
            this.Controls.Add(this.buttonTravelDiary);
            this.Controls.Add(this.buttonSoulmateFounder);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.checkBoxRememberUser);
            this.Controls.Add(this.buttonLogIn);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.pictureBoxCoverPhoto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "   ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoverPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxCoverPhoto;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Button buttonLogIn;
        private System.Windows.Forms.CheckBox checkBoxRememberUser;
        private FeatureButton buttonHome;
        private FeatureButton buttonSoulmateFounder;
        private FeatureButton buttonTravelDiary;
        private System.Windows.Forms.Panel panelWelcome;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.PictureBox pictureBoxProfilePicture;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label labelLoading;
    }
}
