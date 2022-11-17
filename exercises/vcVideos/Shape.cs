using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vcVideos
{
    public class Shape
    {
        public Shape() 
        {

        }
        public Shape(int x, int y)
        {
            X = x;
            Y = y;
        }
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        
        public virtual void Draw()
        {
            Console.WriteLine("Shape is Drawing..");
        }
    }
}
