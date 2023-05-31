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
        private Form main;
        public Bitmap ball_image { get; set; }

        // Constructor
  
        public Ball(Form main)
        {
            this.main = main;
            this.randomizeBall();
            this.generateBallImage();
                }

    
        // Methods
        public void Move(int deltaX, int deltaY)
        {
            X += deltaX;
            Y += deltaY;
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
            this.R = GenerateComplexRand(10, 40);
            this.randomColor();
            this.X = GenerateComplexRand(0, main.Width);
            this.generaterandomXY(); 
            this.generateBallImage();
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
            throw new NotImplementedException();
        }

        internal PointF getPoint()
        {
            //returns the position as a point
            return new PointF(X, Y);
        }
    }
}
