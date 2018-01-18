namespace DailySpecial
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dayBox = new System.Windows.Forms.TextBox();
            this.btnSpecial = new System.Windows.Forms.Button();
            this.lblOutPut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a day number to see our special";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "For example, Sunday = 1";
            // 
            // dayBox
            // 
            this.dayBox.Location = new System.Drawing.Point(139, 110);
            this.dayBox.Name = "dayBox";
            this.dayBox.Size = new System.Drawing.Size(69, 20);
            this.dayBox.TabIndex = 2;
            // 
            // btnSpecial
            // 
            this.btnSpecial.Location = new System.Drawing.Point(133, 160);
            this.btnSpecial.Name = "btnSpecial";
            this.btnSpecial.Size = new System.Drawing.Size(75, 23);
            this.btnSpecial.TabIndex = 3;
            this.btnSpecial.Text = "Get special";
            this.btnSpecial.UseVisualStyleBackColor = true;
            this.btnSpecial.Click += new System.EventHandler(this.btnSpecial_Click);
            // 
            // lblOutPut
            // 
            this.lblOutPut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblOutPut.Location = new System.Drawing.Point(115, 212);
            this.lblOutPut.Name = "lblOutPut";
            this.lblOutPut.Size = new System.Drawing.Size(136, 38);
            this.lblOutPut.TabIndex = 4;
            this.lblOutPut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 315);
            this.Controls.Add(this.lblOutPut);
            this.Controls.Add(this.btnSpecial);
            this.Controls.Add(this.dayBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dayBox;
        private System.Windows.Forms.Button btnSpecial;
        private System.Windows.Forms.Label lblOutPut;
    }
}

