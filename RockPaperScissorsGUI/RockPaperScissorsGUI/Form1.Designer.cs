﻿namespace RockPaperScissorsGUI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picRock = new System.Windows.Forms.PictureBox();
            this.picPaper = new System.Windows.Forms.PictureBox();
            this.picScissors = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblWinLoseDraw = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picRock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScissors)).BeginInit();
            this.SuspendLayout();
            // 
            // picRock
            // 
            this.picRock.Image = ((System.Drawing.Image)(resources.GetObject("picRock.Image")));
            this.picRock.Location = new System.Drawing.Point(12, 38);
            this.picRock.Name = "picRock";
            this.picRock.Size = new System.Drawing.Size(143, 96);
            this.picRock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRock.TabIndex = 0;
            this.picRock.TabStop = false;
            this.picRock.Click += new System.EventHandler(this.picRock_Click);
            // 
            // picPaper
            // 
            this.picPaper.Image = ((System.Drawing.Image)(resources.GetObject("picPaper.Image")));
            this.picPaper.Location = new System.Drawing.Point(184, 38);
            this.picPaper.Name = "picPaper";
            this.picPaper.Size = new System.Drawing.Size(143, 96);
            this.picPaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPaper.TabIndex = 1;
            this.picPaper.TabStop = false;
            this.picPaper.Click += new System.EventHandler(this.picPaper_Click);
            // 
            // picScissors
            // 
            this.picScissors.Image = ((System.Drawing.Image)(resources.GetObject("picScissors.Image")));
            this.picScissors.Location = new System.Drawing.Point(372, 38);
            this.picScissors.Name = "picScissors";
            this.picScissors.Size = new System.Drawing.Size(143, 96);
            this.picScissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picScissors.TabIndex = 2;
            this.picScissors.TabStop = false;
            this.picScissors.Click += new System.EventHandler(this.picScissors_Click);
            // 
            // lblScore
            // 
            this.lblScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblScore.Location = new System.Drawing.Point(202, 161);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(104, 36);
            this.lblScore.TabIndex = 3;
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWinLoseDraw
            // 
            this.lblWinLoseDraw.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWinLoseDraw.Location = new System.Drawing.Point(177, 224);
            this.lblWinLoseDraw.Name = "lblWinLoseDraw";
            this.lblWinLoseDraw.Size = new System.Drawing.Size(150, 46);
            this.lblWinLoseDraw.TabIndex = 4;
            this.lblWinLoseDraw.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 358);
            this.Controls.Add(this.lblWinLoseDraw);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.picScissors);
            this.Controls.Add(this.picPaper);
            this.Controls.Add(this.picRock);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picRock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScissors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picRock;
        private System.Windows.Forms.PictureBox picPaper;
        private System.Windows.Forms.PictureBox picScissors;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblWinLoseDraw;
    }
}

