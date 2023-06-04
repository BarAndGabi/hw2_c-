namespace Q
{
    partial class main_form
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
            this.Plus = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.S = new System.Windows.Forms.Button();
            this.A = new System.Windows.Forms.Button();
            this.End_Game = new System.Windows.Forms.Button();
            this.DB = new System.Windows.Forms.Button();
            this.E = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.secondsCounterLabel = new System.Windows.Forms.Label();
            this.secondsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Plus
            // 
            this.Plus.Location = new System.Drawing.Point(41, 34);
            this.Plus.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(101, 65);
            this.Plus.TabIndex = 0;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = true;
            this.Plus.Click += new System.EventHandler(this.Plus_Click);
            // 
            // Minus
            // 
            this.Minus.Location = new System.Drawing.Point(162, 34);
            this.Minus.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(101, 65);
            this.Minus.TabIndex = 1;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = true;
            this.Minus.Click += new System.EventHandler(this.Minus_Click);
            // 
            // S
            // 
            this.S.Location = new System.Drawing.Point(282, 34);
            this.S.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.S.Name = "S";
            this.S.Size = new System.Drawing.Size(101, 65);
            this.S.TabIndex = 2;
            this.S.Text = "S";
            this.S.UseVisualStyleBackColor = true;
            this.S.Click += new System.EventHandler(this.S_Click);
            // 
            // A
            // 
            this.A.Location = new System.Drawing.Point(402, 34);
            this.A.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(101, 65);
            this.A.TabIndex = 3;
            this.A.Text = "A";
            this.A.UseVisualStyleBackColor = true;
            this.A.Click += new System.EventHandler(this.A_Click);
            // 
            // End_Game
            // 
            this.End_Game.Location = new System.Drawing.Point(522, 34);
            this.End_Game.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.End_Game.Name = "End_Game";
            this.End_Game.Size = new System.Drawing.Size(336, 65);
            this.End_Game.TabIndex = 4;
            this.End_Game.Text = "End Game";
            this.End_Game.UseVisualStyleBackColor = true;
            this.End_Game.Click += new System.EventHandler(this.End_Game_Click);
            // 
            // DB
            // 
            this.DB.Location = new System.Drawing.Point(877, 34);
            this.DB.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.DB.Name = "DB";
            this.DB.Size = new System.Drawing.Size(101, 65);
            this.DB.TabIndex = 5;
            this.DB.Text = "DB";
            this.DB.UseVisualStyleBackColor = true;
            this.DB.Click += new System.EventHandler(this.DB_Click);
            // 
            // E
            // 
            this.E.Location = new System.Drawing.Point(998, 34);
            this.E.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.E.Name = "E";
            this.E.Size = new System.Drawing.Size(101, 65);
            this.E.TabIndex = 6;
            this.E.Text = "E";
            this.E.UseVisualStyleBackColor = true;
            this.E.Click += new System.EventHandler(this.E_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1118, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 37);
            this.label1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1564, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 37);
            this.label2.TabIndex = 8;
            this.label2.Text = "number of balls : ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1666, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 37);
            this.label3.TabIndex = 9;
            this.label3.Text = " ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // secondsCounterLabel
            // 
            this.secondsCounterLabel.AutoSize = true;
            this.secondsCounterLabel.Location = new System.Drawing.Point(1530, 2018);
            this.secondsCounterLabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.secondsCounterLabel.Name = "secondsCounterLabel";
            this.secondsCounterLabel.Size = new System.Drawing.Size(264, 37);
            this.secondsCounterLabel.TabIndex = 10;
            this.secondsCounterLabel.Text = "Seconds Counter";
            // 
            // secondsLabel
            // 
            this.secondsLabel.AutoSize = true;
            this.secondsLabel.Location = new System.Drawing.Point(1631, 2103);
            this.secondsLabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.secondsLabel.Name = "secondsLabel";
            this.secondsLabel.Size = new System.Drawing.Size(26, 37);
            this.secondsLabel.TabIndex = 11;
            this.secondsLabel.Text = " ";
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1849, 1061);
            this.Controls.Add(this.secondsLabel);
            this.Controls.Add(this.secondsCounterLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.E);
            this.Controls.Add(this.DB);
            this.Controls.Add(this.End_Game);
            this.Controls.Add(this.A);
            this.Controls.Add(this.S);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.Plus);
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "main_form";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "main_form";
            this.Load += new System.EventHandler(this.main_form_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.main_form_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Button S;
        private System.Windows.Forms.Button A;
        private System.Windows.Forms.Button End_Game;
        private System.Windows.Forms.Button DB;
        private System.Windows.Forms.Button E;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label secondsCounterLabel;
        private System.Windows.Forms.Label secondsLabel;
    }
}