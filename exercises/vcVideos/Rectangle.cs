using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vcVideos
{
    public sealed class Rectangle : Shape
    {
        public Rectangle()
        {

        }
        public  Rectangle(int x,int y) : base(x,y)
        {
            X= x;
            Y= y;   

        }
        public override void Draw()
        {
            Console.WriteLine($"Drawing a Rectangle"); ;
        }

        public void Calculate()
        {
            Console.WriteLine("calculated by rectangle..");
        }
    }
}
