using hw_2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Q.AboutBox1;

namespace Q
{
    public partial class main_form : Form
    {
        private int ball_count;
        private List<Ball> ball_list = new List<Ball>();//list of balls
        private string current_user_name;//current user name
        private AboutBox1 about;
        

        public main_form()
        {
            this.ball_count = 0;
             this.current_user_name = "";
            InitializeComponent();
        }


        private void DB_Click(object sender, EventArgs e)//open DB form
        {
            DB_form db = new DB_form();
            db.ShowDialog();
        }

        private void E_Click(object sender, EventArgs e)//open Exit message box
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
            {
                this.saveToDb();
                this.Close();
            }
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            this.newUserHandle();
            this.addBall();

        }

        private void addBall()
        {
            if (this.current_user_name != "")
            {
                this.changeBallsCount(1);
                //create new ball
                Ball ball = new Ball(this);
                //add ball to list
                this.ball_list.Add(ball);
                //visualize ball
                ball.addToDisplay();
            }

        }
        private void removeBall()
        {
            if (this.ball_count > 0)
            {
                //remove ball from display
                ball_list[this.ball_count - 1].removeFromDisplay();
                //remove ball from list
                this.ball_list.RemoveAt(this.ball_count - 1);
                changeBallsCount(-1);

            }
            else if (this.ball_count == 0)
            {
                MessageBox.Show("No balls to remove");
            }
            else
                throw new Exception("ball count is negative");

        }
        //func to change ball count and update label
        private void changeBallsCount(int choise)
        {//choise is 1 for add ball and -1 for remove ball
            printBallList();
            switch (choise)
            {
                case 1:
                    this.ball_count++;
                    this.label3.Text = this.ball_count.ToString();
                    break;
                case -1:
                    this.ball_count--;
                    this.label3.Text = this.ball_count.ToString();
                    break;
                default:
                    throw new Exception("invalid choise");
            }

        }

        private void newUserHandle()
        {
            //if ball count is 0
            if (this.ball_count == 0)
            {
                //create new user form and get the value from textBox1 in the form as new user name
                newUser_form new_user = new newUser_form();
                new_user.ShowDialog();
                //if dialog result is ok
                if (new_user.DialogResult == DialogResult.OK)
                {
                    this.current_user_name = new_user.getName();
                    this.label1.Text = "Hello    " + this.current_user_name;
                }

            }
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            this.removeBall();

        }

        //func to print ball list to text file
        private void printBallList()
        {
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
            //delete all balls and reset ball count
            while (this.ball_count > 0)
            {
                this.removeBall();
            }
            //reset user name
            this.current_user_name = "";
            this.label1.Text = "";
            this.saveToDb();
        }

        private void saveToDb()
        {
            //throw new NotImplementedException();
        }

        private void A_Click(object sender, EventArgs e)
        {
            this.about = new AboutBox1();
            //open about box form
            //random number between 1 and 3
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
            //last ball in list 
            Ball lastBall = this.ball_list[this.ball_count - 1];
            lastBall.stop();
        }
        //function on enter key press
        private void main_form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Plus_Click(sender, e);
            }
        }
    }
}
