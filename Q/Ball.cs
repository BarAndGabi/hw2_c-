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
        }

        // Methods
        public void Move(int deltaX, int deltaY)
        {
            X += deltaX;
            Y += deltaY;
        }

        public void addToDisplay()
        {
            Console.WriteLine($"Ball: Size={Size}, Color={Color}, Position=({X}, {Y})");
        }

        internal void removeFromDisplay()
        {
           // throw new NotImplementedException();
        }
    }
}
