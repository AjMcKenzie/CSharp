namespace GuessingGameGUI
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
            this.txtNumberGuess = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnGuess = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNumberGuess
            // 
            this.txtNumberGuess.Location = new System.Drawing.Point(121, 108);
            this.txtNumberGuess.Name = "txtNumberGuess";
            this.txtNumberGuess.Size = new System.Drawing.Size(100, 20);
            this.txtNumberGuess.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Guess a number";
            // 
            // lblOutput
            // 
            this.lblOutput.Location = new System.Drawing.Point(118, 190);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(103, 60);
            this.lblOutput.TabIndex = 2;
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnGuess
            // 
            this.btnGuess.Location = new System.Drawing.Point(131, 134);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(75, 23);
            this.btnGuess.TabIndex = 3;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(260, 273);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 322);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumberGuess);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumberGuess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Button btnReset;
    }
}

