using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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
            Random rnd = new Random();
            this.R = rnd.Next(10, 40);
            this.randomColor(rnd);
            this.X = rnd.Next(0, main.Width);
            this.Y = rnd.Next(0, main.Height);
        }
        public void randomColor(Random rnd)
        {
            //randomize this.color    
            int red = rnd.Next(256);
            int green = rnd.Next(256);
            int blue = rnd.Next(256);

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
