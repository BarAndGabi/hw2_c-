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
        public int Size { get; set; }
        public Color Color { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        private Form main;

        // Constructor
        public Ball(int size, string color, int x, int y)
        {
            Size = size;
            ColorConverter colorConverter = new ColorConverter();
            Color = (Color)colorConverter.ConvertFromString(color);
            X = x;
            Y = y;
        }

        public Ball(Form main)
        {
            this.main = main;
            this.randomizeBall();
        }

        // Methods
        public void Move(int deltaX, int deltaY)
        {
            X += deltaX;
            Y += deltaY;
        }
        public void randomizeBall()
        {
            Random rnd = new Random();
            this.Size = rnd.Next(10, 40);
            this.randomColor();
            this.X = rnd.Next(0, main.Width);
            this.Y = rnd.Next(0, main.Height);
        }
        public void randomColor()
        {
            Random rnd = new Random();
            int r = rnd.Next(0, 255);
            int g = rnd.Next(0, 255);
            int b = rnd.Next(0, 255);
            this.Color = Color.Aqua;
        }
        public void addToDisplay()
        {
            
            // Create a graphics object from the form's background image
            Graphics graphics = Graphics.FromImage(this.main.BackgroundImage);

 
            // Draw the ball as a colored circle
            Brush brush = new SolidBrush(this.Color);
            graphics.FillEllipse(brush,100,100, Size, Size);

            // Refresh the form to display the updated background image
            this.main.Refresh();
            Console.WriteLine($"Ball: Size={Size}, Color={Color.ToString()}, Position=({X}, {Y})");
        }

        internal void removeFromDisplay()
        {
           // throw new NotImplementedException();
        }

        //tosring override
        public override string ToString()
        {
            return $"\n------Ball------ \nSize={Size} \nColor={Color} \nPosition=({X}, {Y})";
        }

        internal void stop()
        {
            throw new NotImplementedException();
        }
    }
}
