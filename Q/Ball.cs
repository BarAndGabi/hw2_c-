using System;
using System.Collections.Generic;
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
        private int skipX { get; set; }
        private int skipY { get; set; }
        private Form main;
        public Bitmap ball_image { get; set; }
        private bool stopSwitch = false;

        // Constructor
  
        public Ball(Form main)
        {
            this.main = main;
            this.randomizeBall();
            this.generaterandomXY();
            this.generateBallImage();
                }

    
        // Methods
        public void Move()
        {
            //if stop switch is on stop moving
            if (this.stopSwitch == true)
            {
                return;
            }
            //if ball is out of bounds randomize ball
            if (this.X + this.R + this.skipX > main.Width || this.Y + this.R + this.skipY > main.Height || this.X < 0 || this.Y < 0)
            {
                this.randomizeBall();
            }
            // Check if the ball tocuhes the right border
            if (this.X + this.R + this.skipX > main.Width)
            {
                this.skipX = -this.skipX;
            }
            // Check if the ball touches the left border
            if (this.X - this.R + this.skipX < 0)
            {
                this.skipX = -this.skipX;
            }
            // Check if the ball touches the bottom border
            if (this.Y + this.R + this.skipY > main.Height)
            {
                this.skipY = -this.skipY;
            }
            // Check if the ball touches the top border
            if (this.Y - this.R + this.skipY < 0)
            {
                this.skipY = -this.skipY;
            }
            // Move the ball
            this.X += this.skipX;
            this.Y += this.skipY;
            
           

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
                this.skipY = GenerateComplexRand(1, 5);
                this.R = GenerateComplexRand(10, 40);
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
