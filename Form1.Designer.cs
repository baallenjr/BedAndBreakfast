﻿
namespace BedAndBreakfast
{
    partial class BaileysForm
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
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.rateLabel = new System.Windows.Forms.Label();
            this.belleAireCheckBox = new System.Windows.Forms.CheckBox();
            this.lincolnCheckBox = new System.Windows.Forms.CheckBox();
            this.mealButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.32727F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(48, 59);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(298, 51);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome to Bailey\'s";
            this.welcomeLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // rateLabel
            // 
            this.rateLabel.AutoSize = true;
            this.rateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.70909F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rateLabel.Location = new System.Drawing.Point(83, 110);
            this.rateLabel.Name = "rateLabel";
            this.rateLabel.Size = new System.Drawing.Size(181, 29);
            this.rateLabel.TabIndex = 1;
            this.rateLabel.Text = "Check our rates";
            // 
            // belleAireCheckBox
            // 
            this.belleAireCheckBox.AutoSize = true;
            this.belleAireCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.belleAireCheckBox.Location = new System.Drawing.Point(88, 153);
            this.belleAireCheckBox.Name = "belleAireCheckBox";
            this.belleAireCheckBox.Size = new System.Drawing.Size(194, 29);
            this.belleAireCheckBox.TabIndex = 2;
            this.belleAireCheckBox.Text = "Belle Aire Suite";
            this.belleAireCheckBox.UseVisualStyleBackColor = true;
            this.belleAireCheckBox.CheckedChanged += new System.EventHandler(this.BelleAireCheckBox_CheckedChanged);
            // 
            // lincolnCheckBox
            // 
            this.lincolnCheckBox.AutoSize = true;
            this.lincolnCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lincolnCheckBox.Location = new System.Drawing.Point(88, 189);
            this.lincolnCheckBox.Name = "lincolnCheckBox";
            this.lincolnCheckBox.Size = new System.Drawing.Size(174, 29);
            this.lincolnCheckBox.TabIndex = 3;
            this.lincolnCheckBox.Text = "Lincoln Room";
            this.lincolnCheckBox.UseVisualStyleBackColor = true;
            this.lincolnCheckBox.CheckedChanged += new System.EventHandler(this.LincolnCheckBox_CheckedChanged);
            // 
            // mealButton
            // 
            this.mealButton.Location = new System.Drawing.Point(182, 265);
            this.mealButton.Name = "mealButton";
            this.mealButton.Size = new System.Drawing.Size(164, 23);
            this.mealButton.TabIndex = 4;
            this.mealButton.Text = "Click for meal options.";
            this.mealButton.UseVisualStyleBackColor = true;
            this.mealButton.Click += new System.EventHandler(this.MealButton_Click);
            // 
            // BaileysForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(514, 311);
            this.Controls.Add(this.mealButton);
            this.Controls.Add(this.lincolnCheckBox);
            this.Controls.Add(this.belleAireCheckBox);
            this.Controls.Add(this.rateLabel);
            this.Controls.Add(this.welcomeLabel);
            this.Name = "BaileysForm";
            this.Text = "Bailey\'s Bed and Breakfast";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label rateLabel;
        private System.Windows.Forms.CheckBox belleAireCheckBox;
        private System.Windows.Forms.CheckBox lincolnCheckBox;
        private System.Windows.Forms.Button mealButton;
    }
}

