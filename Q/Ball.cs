using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q
{
    internal class Ball
    {
        // Properties
        public int Size { get; set; }
        public string Color { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        // Constructor
        public Ball(int size, string color, int x, int y)
        {
            Size = size;
            Color = color;
            X = x;
            Y = y;
        }

        // Methods
        public void Move(int deltaX, int deltaY)
        {
            X += deltaX;
            Y += deltaY;
        }

        public void Display()
        {
            Console.WriteLine($"Ball: Size={Size}, Color={Color}, Position=({X}, {Y})");
        }
        public void Draw()
        {
            Console.WriteLine($"Drawing ball at ({X}, {Y})");



        }
    }
}
