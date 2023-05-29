using System;
using System.Collections.Generic;
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
        public string Color { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        private Form main;

        // Constructor
        public Ball(int size, string color, int x, int y)
        {
            Size = size;
            Color = color;
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
            this.Size = rnd.Next(10, 100);
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
            this.Color = $"#{r:X2}{g:X2}{b:X2}";
        }
        public void addToDisplay()
        {
            Console.WriteLine($"Ball: Size={Size}, Color={Color}, Position=({X}, {Y})");
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
    }
}
