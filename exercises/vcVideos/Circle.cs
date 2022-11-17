using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vcVideos
{
    public class Circle : Shape
    {
        public Circle()
        {

        }
        public Circle(int x,int y)
        {
            X= x;
            Y= y;   

        }
        public override void Draw()
        {
            Console.WriteLine($"Drawing Circle"); ;
        }
    }
}
