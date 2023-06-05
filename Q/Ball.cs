using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw_2
{
    internal class Ball
    {
        // Properties
        public int R { get; set; }
        public Color color { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        private double randomBallOffset { get; set; }
        private int skipX { get; set; }
        private int skipY { get; set; }
        private Form main;
        public Bitmap ball_image { get; set; }
        private bool stopSwitch = false;
        //diraction vector of ball EXAMPLE : (-1,1) means ball moves -1*skipx and 1*skipy
        public Point diractionVector { get; set; }

        // Constructor

        public Ball(Form main)
        {
            this.main = main;
            this.randomizeBall();
            this.generaterandomXY();
            this.generateBallImage();
            this.randomBallOffset = 1.15;
            this.diractionVector = new Point(1, 1);
                }

    
        // Methods
        public void Move()
        {
            //if stop switch is on stop moving
            if (this.stopSwitch == true)
            {
                return;
            }
          
            // Check if the ball tocuhes the right border
            if (this.X + 2*this.R  > main.Width-10)
            {
                this.randomizeBall();
                this.borderHandle('R');
               

            }
            // Check if the ball tocuhes the left border
            if (this.X < 0)
            {
                this.randomizeBall();
                this.borderHandle('L');

            }
            // Check if the ball tocuhes the bottom border
            if (this.Y +2*this.R > main.Height-10)
            {
                this.randomizeBall();
               this.borderHandle('D');
            }
            // Check if the ball tocuhes the top border
            if (this.Y < 0)
            {
                this.randomizeBall();
                this.borderHandle('U');
            }

            this.X += this.skipX;
            this.Y += this.skipY;
            
           

        }

        private void borderHandle(char v)
        {
            switch (v)
            {
                case 'L':
                   // if ball was moving up and left border was hit ball will move up and right
                   if(this.diractionVector.X == -1 && this.diractionVector.Y == -1)
                    {
                        this.diractionVector= new Point(1, -1);
                    }
                   // if ball was moving down and left border was hit ball will move down and right
                   else if (this.diractionVector.X == -1 && this.diractionVector.Y == 1)
                    {
                            this.diractionVector = new Point(1, 1);
                      }
                    break;
                case 'R':
                    // if ball was moving up and Right border was hit ball will move up and LEFT
                    if (this.diractionVector.X == 1 && this.diractionVector.Y == -1)
                    {
                        this.diractionVector = new Point(-1, -1);
                    }
                    // if ball was moving down and Right border was hit ball will move down and LEFT
                    else if (this.diractionVector.X == 1 && this.diractionVector.Y == 1)
                    {
                        this.diractionVector = new Point(-1, 1);
                    }
                    break;
                case 'U':
                    // if ball was moving left and top border was hit ball will move left and down
                    if (this.diractionVector.X == -1 && this.diractionVector.Y == -1)
                    {
                        this.diractionVector = new Point(-1, 1);
                    }
                    // if ball was moving right and top border was hit ball will move right and down
                    else if (this.diractionVector.X == 1 && this.diractionVector.Y == -1)
                    {
                        this.diractionVector = new Point(1, 1);
                    }
                    break;
                case 'D':
                    // if ball was moving left and bottom border was hit ball will move left and up
                    if (this.diractionVector.X == -1 && this.diractionVector.Y == 1)
                    {
                        this.diractionVector = new Point(-1, -1);
                    }
                    // if ball was moving right and bottom border was hit ball will move right and up
                    else if (this.diractionVector.X == 1 && this.diractionVector.Y == 1)
                    {
                        this.diractionVector = new Point(1, -1);
                    }
                    break;
                default:
                    break;
            }
            //change direction
            this.skipX = this.skipX * this.diractionVector.X;
            this.skipY = this.skipY * this.diractionVector.Y;
        }

        private void changeDirection()
        {
            //4 states of direction vector
          

        }

        //generate random with new random seed
        int GenerateComplexRand(int minValue, int maxValue)
        {
            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                byte[] randomNumber = new byte[4]; // 4 bytes = 32 bits (int32)
                rng.GetBytes(randomNumber);
                int result = BitConverter.ToInt32(randomNumber, 0);

                // Ensure the result is within the desired range
                return Math.Abs(result % (maxValue - minValue + 1)) + minValue;
            }
        }
        public void generateBallImage()
        {
            // Create a new bitmap image
            Bitmap bmp = new Bitmap(2 * R, 2 * R);
            // Create a graphics object from the image
            Graphics g = Graphics.FromImage(bmp);
            // Draw the ball
            g.FillEllipse(new SolidBrush(color), 0, 0, 2 * R, 2 * R);
            // Set the ball image
            this.ball_image = bmp;
        }
        public void randomizeBall()
        {
            if (this.stopSwitch==false)
            {
                this.skipX = GenerateComplexRand(1, 5);
                this.skipY = this.skipX;
                this.R = GenerateComplexRand(5, 20);
                this.randomColor();
               // this.generaterandomXY();
                this.generateBallImage();
            }
        }
        public void generaterandomXY()
        {
            //randomize this.X and this.Y within the main form size
            this.X = GenerateComplexRand(0, main.Width);
            this.Y = GenerateComplexRand(0, main.Height);
            //check if the ball is out of bounds new random XY
            if (this.X + this.R+this.R > main.Width || this.Y + this.R +this.R > main.Height||this.X<0|| this.Y < 0)
            {
                this.generaterandomXY();
            }
         
             
        }
        public void randomColor()
        {
            //randomize this.color    
            int red = this.GenerateComplexRand(0, 255);
            int green = this.GenerateComplexRand(0, 255);
            int blue = this.GenerateComplexRand(0, 255);

            this.color= System.Drawing.Color.FromArgb(red, green, blue);

        }
        public void addToDisplay()
        {
            Console.WriteLine($"Ball: Size={R}, Color={color.ToString()}, Position=({X}, {Y})");
        }

        internal void removeFromDisplay()
        {
           // throw new NotImplementedException();
        }

        //tosring override
        public override string ToString()
        {
            return $"\n------Ball------ \nSize={R} \nColor={color.ToString()} \nPosition=({X}, {Y})";
        }

        internal void stop()
        {
            if(this.stopSwitch == false)
            this.stopSwitch = true;
            else
            {
                this.start();
            }
        }
        internal void start()
        {
            this.stopSwitch = false;
        }

        internal PointF getPoint()
        {
            //returns the position as a point
            return new PointF(X, Y);
        }
    }
}
