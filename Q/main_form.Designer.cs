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
            this.button3 = new System.Windows.Forms.Button();
            this.A = new System.Windows.Forms.Button();
            this.End_Game = new System.Windows.Forms.Button();
            this.DB = new System.Windows.Forms.Button();
            this.E = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Plus
            // 
            this.Plus.Location = new System.Drawing.Point(13, 12);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(32, 23);
            this.Plus.TabIndex = 0;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = true;
            this.Plus.Click += new System.EventHandler(this.Plus_Click);
            // 
            // Minus
            // 
            this.Minus.Location = new System.Drawing.Point(51, 12);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(32, 23);
            this.Minus.TabIndex = 1;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = true;
            this.Minus.Click += new System.EventHandler(this.Minus_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(89, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(32, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // A
            // 
            this.A.Location = new System.Drawing.Point(127, 12);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(32, 23);
            this.A.TabIndex = 3;
            this.A.Text = "A";
            this.A.UseVisualStyleBackColor = true;
            this.A.Click += new System.EventHandler(this.A_Click);
            // 
            // End_Game
            // 
            this.End_Game.Location = new System.Drawing.Point(165, 12);
            this.End_Game.Name = "End_Game";
            this.End_Game.Size = new System.Drawing.Size(106, 23);
            this.End_Game.TabIndex = 4;
            this.End_Game.Text = "End Game";
            this.End_Game.UseVisualStyleBackColor = true;
            this.End_Game.Click += new System.EventHandler(this.End_Game_Click);
            // 
            // DB
            // 
            this.DB.Location = new System.Drawing.Point(277, 12);
            this.DB.Name = "DB";
            this.DB.Size = new System.Drawing.Size(32, 23);
            this.DB.TabIndex = 5;
            this.DB.Text = "DB";
            this.DB.UseVisualStyleBackColor = true;
            this.DB.Click += new System.EventHandler(this.DB_Click);
            // 
            // E
            // 
            this.E.Location = new System.Drawing.Point(315, 12);
            this.E.Name = "E";
            this.E.Size = new System.Drawing.Size(32, 23);
            this.E.TabIndex = 6;
            this.E.Text = "E";
            this.E.UseVisualStyleBackColor = true;
            this.E.Click += new System.EventHandler(this.E_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(353, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(502, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "number of balls : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(534, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = " ";
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 551);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.E);
            this.Controls.Add(this.DB);
            this.Controls.Add(this.End_Game);
            this.Controls.Add(this.A);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.Plus);
            this.Name = "main_form";
            this.Text = "main_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button A;
        private System.Windows.Forms.Button End_Game;
        private System.Windows.Forms.Button DB;
        private System.Windows.Forms.Button E;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}