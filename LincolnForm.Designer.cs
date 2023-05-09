
namespace BedAndBreakfast
{
    partial class LincolnForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LincolnForm));
            this.lincolnRoomDescriptionLabel = new System.Windows.Forms.Label();
            this.lincolnRoomPriceLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lincolnRoomDescriptionLabel
            // 
            this.lincolnRoomDescriptionLabel.AutoSize = true;
            this.lincolnRoomDescriptionLabel.Location = new System.Drawing.Point(68, 80);
            this.lincolnRoomDescriptionLabel.Name = "lincolnRoomDescriptionLabel";
            this.lincolnRoomDescriptionLabel.Size = new System.Drawing.Size(144, 26);
            this.lincolnRoomDescriptionLabel.TabIndex = 0;
            this.lincolnRoomDescriptionLabel.Text = "Return to the 1850s in this\r\n lovely room with private bath";
            // 
            // lincolnRoomPriceLabel
            // 
            this.lincolnRoomPriceLabel.AutoSize = true;
            this.lincolnRoomPriceLabel.Location = new System.Drawing.Point(173, 129);
            this.lincolnRoomPriceLabel.Name = "lincolnRoomPriceLabel";
            this.lincolnRoomPriceLabel.Size = new System.Drawing.Size(75, 13);
            this.lincolnRoomPriceLabel.TabIndex = 1;
            this.lincolnRoomPriceLabel.Text = "$110 per night";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(50, 129);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // LincolnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(366, 370);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lincolnRoomPriceLabel);
            this.Controls.Add(this.lincolnRoomDescriptionLabel);
            this.Name = "LincolnForm";
            this.Text = "Lincoln Room";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lincolnRoomDescriptionLabel;
        private System.Windows.Forms.Label lincolnRoomPriceLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}