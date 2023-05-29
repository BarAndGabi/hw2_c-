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

namespace Q
{
    public partial class main_form : Form
    {
        private int ball_count;
        private List<Ball> ball_list = new List<Ball>();//list of balls
        string current_user_name;//current user name
        public main_form()
        {
            this.ball_count = 0;
            string current_user_name = "";
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
           this.changeBallsCount(1);
            //create new ball
            Ball ball = new Ball(this);
            //add ball to list
            this.ball_list.Add(ball);
            //visualize ball
            ball.addToDisplay();

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
            }else
                throw new Exception("ball count is negative");

        }

        private void changeBallsCount(int choise)
        {
            switch(choise)
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
    }
}
