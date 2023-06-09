﻿using hw_2;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using static Q.AboutBox1;

namespace Q
{
    public partial class main_form : Form
    {
        private int ball_count; // Number of balls
        private List<Ball> ball_list = new List<Ball>(); // List of balls
        private string current_user_name; // Current user name
        private AboutBox1 about; // About box form
        private Graphics g;
        private System.Windows.Forms.Timer animationTimer;
        //define timer to count time of user    
        private System.Windows.Forms.Timer userTimer;
        private int secondsPlayed;//count seconds played by user
        private DB_form db; // DB form
       
        public main_form()
        {
            this.ball_count = 0;
            this.current_user_name = "";
            
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            //set function on form closing
            this.FormClosing += new FormClosingEventHandler(main_form_FormClosing);
            this.styleForm();

        }
        private void main_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            //save to DB when closing the form
            this.saveToDb();
        }
            private void DB_Click(object sender, EventArgs e)
        {
            // Open DB form
            this.db = new DB_form();
            db.ShowDialog();
        }
        private void styleForm()
        {
            // Set the form's background color to a dark color
            this.BackColor = Color.FromArgb(33, 33, 33); // Dark gray color

            // Define the primary and secondary colors
            Color primaryColor = Color.White;
            Color secondaryColor = Color.FromArgb(45, 45, 45); // Darker gray color

            // Set the font and styles for labels and buttons
            Font labelFont = new Font("Segoe UI", 12, FontStyle.Bold);
            Font buttonFont = new Font("Segoe UI", 10, FontStyle.Bold);
            FontStyle labelStyle = FontStyle.Bold;
            FontStyle buttonStyle = FontStyle.Bold;

            // Update the foreground colors and fonts of labels
            this.label1.ForeColor = primaryColor;
            this.label1.Font = labelFont;
            this.label1.Font = new Font(this.label1.Font, labelStyle);
            this.label3.ForeColor = primaryColor;
            this.label3.Font = labelFont;
            this.label3.Font = new Font(this.label3.Font, labelStyle);

            // Update the foreground colors and fonts of buttons
            foreach (Button button in this.Controls.OfType<Button>())
            {
                button.ForeColor = primaryColor;
                button.BackColor = secondaryColor;
                button.Font = buttonFont;
                button.Font = new Font(button.Font, buttonStyle);
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 0;
                button.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, secondaryColor);
                button.FlatAppearance.MouseDownBackColor = Color.FromArgb(80, secondaryColor);
            }

            // Modify the appearance of controls
            foreach (Control control in this.Controls)
            {
                if (control is Label || control is Button)
                {
                    control.BackColor = secondaryColor;
                }
            }
        }

        private void E_Click(object sender, EventArgs e)
        {
            // Open Exit message box and close the form if "Yes" is clicked
            if (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
            {
                // this.saveToDb();
                this.Close();
            }
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            // Create a new user and add a ball
            this.newUserHandle();
            this.addBall();


        }



        private void addBall()
        {
            if (this.current_user_name != "")
            {
                this.changeBallsCount(1); // Increase ball count
                Ball ball = new Ball(this); // Create a new ball
                this.ball_list.Add(ball); // Add ball to the list
                ball.addToDisplay(); // Visualize the ball
            }
        }

        private void removeBall()
        {
            if (this.ball_count > 0)
            {
                if (this.ball_count == 1)
                {
                    this.saveToDb(); // Save to DB if ball count is 1
                }
                ball_list[this.ball_count - 1].removeFromDisplay(); // Remove the last ball from display
                this.ball_list.RemoveAt(this.ball_count - 1); // Remove the last ball from the list
                changeBallsCount(-1); // Decrease ball count

            }
            else if (this.ball_count == 0)
            {
                MessageBox.Show("No balls to remove");
            }
            else
            {
                throw new Exception("ball count is negative");
            }
        }

        private void changeBallsCount(int choice)
        {
            // Function to change ball count and update the label
            printBallList(); // Print the ball list
            switch (choice)
            {
                case 1:
                    this.ball_count++; // Increment ball count
                    this.label3.Text = this.ball_count.ToString(); // Update the label with the new ball count
                    break;
                case -1:
                    this.ball_count--; // Decrement ball count
                    this.label3.Text = this.ball_count.ToString(); // Update the label with the new ball count
                    break;
                default:
                    throw new Exception("invalid choice");
            }
        }

        private void newUserHandle()
        {
            // Create a new user if ball count is 0
            if (this.ball_count == 0)
            {
                newUser_form new_user = new newUser_form(); // Create a new user form
                new_user.ShowDialog(); // Show the new user form
                if (new_user.DialogResult == DialogResult.OK) // If dialog result is OK
                {
                    this.current_user_name = new_user.getName(); // Get the name from the form as the new user name
                    this.label1.Text = "Hello    " + this.current_user_name; // Update the label with the new user name
                    this.secondsPlayed = 0;//initialize seconds played by user

                }
            }
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            this.removeBall();
            this.Refresh();

        }

        private void printBallList()
        {
            // Function to print the ball list to a text file
            System.IO.StreamWriter file = new System.IO.StreamWriter("ball_list.txt");
            foreach (Ball ball in this.ball_list)
            {
                file.WriteLine(ball.ToString());
            }
            file.Close();
        }

        private void End_Game_Click(object sender, EventArgs e)
        {
            this.restartGame();
        }

        private void restartGame()
        {
            //this.saveToDb();
            // Delete all balls and reset ball count
            while (this.ball_count > 0)
            {
                this.removeBall();
            }
            // Reset user name
            this.current_user_name = "";
            this.label1.Text = "";
            // this.saveToDb();
        }

        private void saveToDb()
        {
            this.db = new DB_form();
            this.db.addToDB(this.current_user_name, this.secondsPlayed);
        }

        private void A_Click(object sender, EventArgs e)
        {
            this.about = new AboutBox1();
            // Open About box form
            // Generate a random number between 1 and 3
            Random rnd = new Random();
            int num = rnd.Next(1, 4);
            S_delegate s1 = this.about.S1;
            S_delegate s2 = this.about.S2;
            S_delegate s3 = this.about.S3;
            switch (num)
            {
                case 1:
                    this.about.changeDescription(s1);
                    break;
                case 2:
                    this.about.changeDescription(s2);
                    break;
                case 3:
                    this.about.changeDescription(s3);
                    break;
                default:
                    throw new Exception("invalid number");
            }
            this.about.ShowDialog();
        }

        private void S_Click(object sender, EventArgs e)
        {
            if (!(this.ball_count <= 0 || this.current_user_name == ""))
            {
                this.stopLastBall();
            }
        }

        private void stopLastBall()
        {
            // Stop the last ball in the list
            Ball lastBall = this.ball_list[this.ball_count - 1];
            lastBall.stop();
        }

        private void main_form_KeyDown(object sender, KeyEventArgs e)
        {
            // Function triggered on Enter key press
            if (e.KeyCode == Keys.Enter)
            {
                this.Plus_Click(sender, e); // Trigger Plus_Click event
            }
        }

        private void main_form_Paint(object sender, PaintEventArgs e)
        {
            this.g = e.Graphics;

            //foreach ball in list  draw 
            foreach (Ball b in this.ball_list)
            {
                b.Move();
                g.DrawImage(b.ball_image, b.X, b.Y);
            }

            // this.Refresh();
        }

        private void main_form_Load(object sender, EventArgs e)
        {
            this.animationTimer = new System.Windows.Forms.Timer();
            this.animationTimer.Interval = 50;//150 ms = 0.15 sec
            this.animationTimer.Tick += new System.EventHandler(animationTimer_Tick);
            this.animationTimer.Start();
            this.userTimer = new System.Windows.Forms.Timer();
            this.userTimer.Interval = 1000;//1000 ms = 1 sec
            this.userTimer.Tick += new System.EventHandler(userTimer_Tick);
            this.userTimer.Start();
        }
        private void animationTimer_Tick(object sender, EventArgs e)
        {
            //do whatever you want 
            this.Refresh();
        }
        private void userTimer_Tick(object sender, EventArgs e)
        {
            this.secondsPlayed++;
            if (this.ball_count > 0)
                this.secondsLabel.Text = this.secondsPlayed.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
