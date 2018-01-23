namespace Game
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
            this.radRock = new System.Windows.Forms.RadioButton();
            this.radPaper = new System.Windows.Forms.RadioButton();
            this.radScissors = new System.Windows.Forms.RadioButton();
            this.radScissors2 = new System.Windows.Forms.RadioButton();
            this.radPaper2 = new System.Windows.Forms.RadioButton();
            this.radRock2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblScore2 = new System.Windows.Forms.Label();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnUndo2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radRock
            // 
            this.radRock.AutoSize = true;
            this.radRock.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radRock.Location = new System.Drawing.Point(32, 230);
            this.radRock.Name = "radRock";
            this.radRock.Size = new System.Drawing.Size(77, 34);
            this.radRock.TabIndex = 0;
            this.radRock.Text = "Rock";
            this.radRock.UseVisualStyleBackColor = true;
            this.radRock.CheckedChanged += new System.EventHandler(this.radRock_CheckedChanged);
            // 
            // radPaper
            // 
            this.radPaper.AutoSize = true;
            this.radPaper.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPaper.Location = new System.Drawing.Point(144, 230);
            this.radPaper.Name = "radPaper";
            this.radPaper.Size = new System.Drawing.Size(87, 34);
            this.radPaper.TabIndex = 1;
            this.radPaper.Text = "Paper";
            this.radPaper.UseVisualStyleBackColor = true;
            this.radPaper.CheckedChanged += new System.EventHandler(this.radPaper_CheckedChanged);
            // 
            // radScissors
            // 
            this.radScissors.AutoSize = true;
            this.radScissors.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radScissors.Location = new System.Drawing.Point(249, 230);
            this.radScissors.Name = "radScissors";
            this.radScissors.Size = new System.Drawing.Size(114, 34);
            this.radScissors.TabIndex = 2;
            this.radScissors.Text = "Scissors";
            this.radScissors.UseVisualStyleBackColor = true;
            this.radScissors.CheckedChanged += new System.EventHandler(this.radScissors_CheckedChanged);
            // 
            // radScissors2
            // 
            this.radScissors2.AutoSize = true;
            this.radScissors2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radScissors2.Location = new System.Drawing.Point(249, 47);
            this.radScissors2.Name = "radScissors2";
            this.radScissors2.Size = new System.Drawing.Size(114, 34);
            this.radScissors2.TabIndex = 5;
            this.radScissors2.Text = "Scissors";
            this.radScissors2.UseVisualStyleBackColor = true;
            this.radScissors2.CheckedChanged += new System.EventHandler(this.radScissors2_CheckedChanged);
            // 
            // radPaper2
            // 
            this.radPaper2.AutoSize = true;
            this.radPaper2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPaper2.Location = new System.Drawing.Point(144, 47);
            this.radPaper2.Name = "radPaper2";
            this.radPaper2.Size = new System.Drawing.Size(87, 34);
            this.radPaper2.TabIndex = 4;
            this.radPaper2.Text = "Paper";
            this.radPaper2.UseVisualStyleBackColor = true;
            this.radPaper2.CheckedChanged += new System.EventHandler(this.radPaper2_CheckedChanged);
            // 
            // radRock2
            // 
            this.radRock2.AutoSize = true;
            this.radRock2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radRock2.Location = new System.Drawing.Point(32, 47);
            this.radRock2.Name = "radRock2";
            this.radRock2.Size = new System.Drawing.Size(77, 34);
            this.radRock2.TabIndex = 3;
            this.radRock2.Text = "Rock";
            this.radRock2.UseVisualStyleBackColor = true;
            this.radRock2.CheckedChanged += new System.EventHandler(this.radRock2_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "Play with another player.\r\nWhen player 1 is choosing \r\nPlayer 2 looks away and vi" +
    "sa versa.";
            // 
            // lblScore
            // 
            this.lblScore.Location = new System.Drawing.Point(337, 267);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(65, 44);
            this.lblScore.TabIndex = 7;
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScore2
            // 
            this.lblScore2.Location = new System.Drawing.Point(12, 9);
            this.lblScore2.Name = "lblScore2";
            this.lblScore2.Size = new System.Drawing.Size(65, 44);
            this.lblScore2.TabIndex = 8;
            this.lblScore2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUndo
            // 
            this.btnUndo.Location = new System.Drawing.Point(15, 270);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(62, 23);
            this.btnUndo.TabIndex = 9;
            this.btnUndo.Text = "Undo";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Visible = false;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnUndo2
            // 
            this.btnUndo2.Location = new System.Drawing.Point(330, 9);
            this.btnUndo2.Name = "btnUndo2";
            this.btnUndo2.Size = new System.Drawing.Size(62, 23);
            this.btnUndo2.TabIndex = 10;
            this.btnUndo2.Text = "Undo";
            this.btnUndo2.UseVisualStyleBackColor = true;
            this.btnUndo2.Visible = false;
            this.btnUndo2.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 320);
            this.Controls.Add(this.btnUndo2);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.lblScore2);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radScissors2);
            this.Controls.Add(this.radPaper2);
            this.Controls.Add(this.radRock2);
            this.Controls.Add(this.radScissors);
            this.Controls.Add(this.radPaper);
            this.Controls.Add(this.radRock);
            this.Name = "Form1";
            this.Text = "Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radRock;
        private System.Windows.Forms.RadioButton radPaper;
        private System.Windows.Forms.RadioButton radScissors;
        private System.Windows.Forms.RadioButton radScissors2;
        private System.Windows.Forms.RadioButton radPaper2;
        private System.Windows.Forms.RadioButton radRock2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblScore2;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnUndo2;
    }
}

