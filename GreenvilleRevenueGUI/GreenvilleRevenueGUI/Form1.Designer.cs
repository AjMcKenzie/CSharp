namespace GreenvilleRevenueGUI
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
            this.txtlastYear = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtThisYear = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblOuput = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtlastYear
            // 
            this.txtlastYear.Location = new System.Drawing.Point(188, 28);
            this.txtlastYear.Name = "txtlastYear";
            this.txtlastYear.Size = new System.Drawing.Size(100, 20);
            this.txtlastYear.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of participants of last year:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number of participants of this year:";
            // 
            // txtThisYear
            // 
            this.txtThisYear.Location = new System.Drawing.Point(188, 69);
            this.txtThisYear.Name = "txtThisYear";
            this.txtThisYear.Size = new System.Drawing.Size(100, 20);
            this.txtThisYear.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data Present:";
            // 
            // lblOuput
            // 
            this.lblOuput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOuput.Location = new System.Drawing.Point(186, 100);
            this.lblOuput.Name = "lblOuput";
            this.lblOuput.Size = new System.Drawing.Size(191, 109);
            this.lblOuput.TabIndex = 5;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(129, 223);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(85, 34);
            this.btnGenerate.TabIndex = 6;
            this.btnGenerate.Text = "Generate Data";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 264);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.lblOuput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtThisYear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtlastYear);
            this.Name = "Form1";
            this.Text = "GreenvilleRevenue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtlastYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtThisYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblOuput;
        private System.Windows.Forms.Button btnGenerate;
    }
}

