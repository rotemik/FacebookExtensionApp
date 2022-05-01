namespace FacebookExtensionApp.TravelDiary.View
{
    public partial class TravelDiaryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TravelDiaryForm));
            this.listBoxTravels = new System.Windows.Forms.ListBox();
            this.labelTravels = new System.Windows.Forms.Label();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.labelTravel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxTravels
            // 
            this.listBoxTravels.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxTravels.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxTravels.FormattingEnabled = true;
            this.listBoxTravels.ItemHeight = 18;
            this.listBoxTravels.Location = new System.Drawing.Point(1, 28);
            this.listBoxTravels.Name = "listBoxTravels";
            this.listBoxTravels.Size = new System.Drawing.Size(437, 216);
            this.listBoxTravels.TabIndex = 1;
            // 
            // labelTravels
            // 
            this.labelTravels.AutoSize = true;
            this.labelTravels.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.labelTravels.Font = new System.Drawing.Font("Rockwell", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTravels.Location = new System.Drawing.Point(21, 50);
            this.labelTravels.Name = "labelTravels";
            this.labelTravels.Size = new System.Drawing.Size(239, 43);
            this.labelTravels.TabIndex = 2;
            this.labelTravels.Text = "Your Travels";
            // 
            // buttonSelect
            // 
            this.buttonSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(205)))), ((int)(((byte)(244)))));
            this.buttonSelect.FlatAppearance.BorderSize = 0;
            this.buttonSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelect.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonSelect.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSelect.Location = new System.Drawing.Point(395, 346);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(75, 23);
            this.buttonSelect.TabIndex = 3;
            this.buttonSelect.Text = "Select";
            this.buttonSelect.UseVisualStyleBackColor = false;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // labelTravel
            // 
            this.labelTravel.AutoSize = true;
            this.labelTravel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.labelTravel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.labelTravel.Location = new System.Drawing.Point(2, 5);
            this.labelTravel.Name = "labelTravel";
            this.labelTravel.Size = new System.Drawing.Size(73, 19);
            this.labelTravel.TabIndex = 5;
            this.labelTravel.Text = "Countries:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.panel1.Controls.Add(this.listBoxTravels);
            this.panel1.Controls.Add(this.labelTravel);
            this.panel1.Location = new System.Drawing.Point(29, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 238);
            this.panel1.TabIndex = 6;
            // 
            // FormTravelDiary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1101, 434);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.labelTravels);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTravelDiary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormUserUsage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxTravels;
        private System.Windows.Forms.Label labelTravels;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Label labelTravel;
        private System.Windows.Forms.Panel panel1;
    }
}