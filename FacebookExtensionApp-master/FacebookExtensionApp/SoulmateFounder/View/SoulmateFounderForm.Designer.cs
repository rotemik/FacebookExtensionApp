namespace FacebookExtensionApp.SoulmateFounder.View
{
    public partial class SoulmateFounderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SoulmateFounderForm));
            this.checkedListCommonInterests = new System.Windows.Forms.CheckedListBox();
            this.buttonSelectAll = new System.Windows.Forms.Button();
            this.buttonGetStarted = new System.Windows.Forms.Button();
            this.pictureSoulmateFriend = new System.Windows.Forms.PictureBox();
            this.listBoxCommonFinal = new System.Windows.Forms.ListBox();
            this.labelLoading = new System.Windows.Forms.Label();
            this.labelFriendName = new System.Windows.Forms.Label();
            this.labelMetchCategories = new System.Windows.Forms.Label();
            this.labelSoulmateFounder = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSoulmateFriend)).BeginInit();
            this.SuspendLayout();
            // 
            // checkedListCommonInterests
            // 
            this.checkedListCommonInterests.FormattingEnabled = true;
            this.checkedListCommonInterests.Location = new System.Drawing.Point(106, 133);
            this.checkedListCommonInterests.Margin = new System.Windows.Forms.Padding(2);
            this.checkedListCommonInterests.Name = "checkedListCommonInterests";
            this.checkedListCommonInterests.Size = new System.Drawing.Size(221, 184);
            this.checkedListCommonInterests.TabIndex = 0;
            // 
            // buttonSelectAll
            // 
            this.buttonSelectAll.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSelectAll.FlatAppearance.BorderSize = 0;
            this.buttonSelectAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSelectAll.Location = new System.Drawing.Point(106, 91);
            this.buttonSelectAll.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSelectAll.Name = "buttonSelectAll";
            this.buttonSelectAll.Size = new System.Drawing.Size(221, 30);
            this.buttonSelectAll.TabIndex = 1;
            this.buttonSelectAll.Text = "Select All";
            this.buttonSelectAll.UseVisualStyleBackColor = false;
            this.buttonSelectAll.Click += new System.EventHandler(this.buttonSelectAll_Click);
            // 
            // buttonGetStarted
            // 
            this.buttonGetStarted.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonGetStarted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGetStarted.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonGetStarted.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonGetStarted.Location = new System.Drawing.Point(106, 324);
            this.buttonGetStarted.Margin = new System.Windows.Forms.Padding(5);
            this.buttonGetStarted.Name = "buttonGetStarted";
            this.buttonGetStarted.Size = new System.Drawing.Size(221, 56);
            this.buttonGetStarted.TabIndex = 2;
            this.buttonGetStarted.Text = "GO!";
            this.buttonGetStarted.UseVisualStyleBackColor = false;
            this.buttonGetStarted.Click += new System.EventHandler(this.buttonGetStarted_Click);
            // 
            // pictureSoulmateFriend
            // 
            this.pictureSoulmateFriend.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureSoulmateFriend.BackgroundImage")));
            this.pictureSoulmateFriend.Image = ((System.Drawing.Image)(resources.GetObject("pictureSoulmateFriend.Image")));
            this.pictureSoulmateFriend.ImageLocation = string.Empty;
            this.pictureSoulmateFriend.Location = new System.Drawing.Point(416, 91);
            this.pictureSoulmateFriend.Margin = new System.Windows.Forms.Padding(2);
            this.pictureSoulmateFriend.Name = "pictureSoulmateFriend";
            this.pictureSoulmateFriend.Size = new System.Drawing.Size(268, 242);
            this.pictureSoulmateFriend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureSoulmateFriend.TabIndex = 3;
            this.pictureSoulmateFriend.TabStop = false;
            // 
            // listBoxCommonFinal
            // 
            this.listBoxCommonFinal.Enabled = false;
            this.listBoxCommonFinal.FormattingEnabled = true;
            this.listBoxCommonFinal.Location = new System.Drawing.Point(769, 133);
            this.listBoxCommonFinal.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxCommonFinal.Name = "listBoxCommonFinal";
            this.listBoxCommonFinal.Size = new System.Drawing.Size(221, 173);
            this.listBoxCommonFinal.TabIndex = 5;
            // 
            // labelLoading
            // 
            this.labelLoading.AutoSize = true;
            this.labelLoading.BackColor = System.Drawing.Color.Transparent;
            this.labelLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoading.ForeColor = System.Drawing.Color.White;
            this.labelLoading.Location = new System.Drawing.Point(479, 195);
            this.labelLoading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLoading.Name = "labelLoading";
            this.labelLoading.Size = new System.Drawing.Size(144, 31);
            this.labelLoading.TabIndex = 8;
            this.labelLoading.Text = "Loading...";
            // 
            // labelFriendName
            // 
            this.labelFriendName.AutoSize = true;
            this.labelFriendName.BackColor = System.Drawing.Color.Transparent;
            this.labelFriendName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFriendName.ForeColor = System.Drawing.Color.White;
            this.labelFriendName.Location = new System.Drawing.Point(410, 349);
            this.labelFriendName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFriendName.Name = "labelFriendName";
            this.labelFriendName.Size = new System.Drawing.Size(181, 31);
            this.labelFriendName.TabIndex = 9;
            this.labelFriendName.Text = "Friend Name";
            // 
            // labelMetchCategories
            // 
            this.labelMetchCategories.AutoSize = true;
            this.labelMetchCategories.BackColor = System.Drawing.Color.Transparent;
            this.labelMetchCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelMetchCategories.ForeColor = System.Drawing.Color.White;
            this.labelMetchCategories.Location = new System.Drawing.Point(765, 101);
            this.labelMetchCategories.Name = "labelMetchCategories";
            this.labelMetchCategories.Size = new System.Drawing.Size(152, 20);
            this.labelMetchCategories.TabIndex = 10;
            this.labelMetchCategories.Text = "Match categories:";
            // 
            // labelSoulmateFounder
            // 
            this.labelSoulmateFounder.AutoSize = true;
            this.labelSoulmateFounder.BackColor = System.Drawing.Color.Transparent;
            this.labelSoulmateFounder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelSoulmateFounder.Font = new System.Drawing.Font("Rockwell", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSoulmateFounder.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelSoulmateFounder.Location = new System.Drawing.Point(379, 28);
            this.labelSoulmateFounder.Name = "labelSoulmateFounder";
            this.labelSoulmateFounder.Size = new System.Drawing.Size(331, 43);
            this.labelSoulmateFounder.TabIndex = 11;
            this.labelSoulmateFounder.Text = "Soulmate Founder";
            // 
            // FormSoulmateFounder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(227)))), ((int)(((byte)(238)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1101, 434);
            this.Controls.Add(this.labelSoulmateFounder);
            this.Controls.Add(this.labelMetchCategories);
            this.Controls.Add(this.labelFriendName);
            this.Controls.Add(this.labelLoading);
            this.Controls.Add(this.listBoxCommonFinal);
            this.Controls.Add(this.pictureSoulmateFriend);
            this.Controls.Add(this.buttonGetStarted);
            this.Controls.Add(this.buttonSelectAll);
            this.Controls.Add(this.checkedListCommonInterests);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSoulmateFounder";
            this.Opacity = 0.8D;
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "FormSoulmateFounder";
            ((System.ComponentModel.ISupportInitialize)(this.pictureSoulmateFriend)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListCommonInterests;
        private System.Windows.Forms.Button buttonSelectAll;
        private System.Windows.Forms.Button buttonGetStarted;
        private System.Windows.Forms.PictureBox pictureSoulmateFriend;
        private System.Windows.Forms.ListBox listBoxCommonFinal;
        private System.Windows.Forms.Label labelLoading;
        private System.Windows.Forms.Label labelFriendName;
        private System.Windows.Forms.Label labelMetchCategories;
        private System.Windows.Forms.Label labelSoulmateFounder;
    }
}