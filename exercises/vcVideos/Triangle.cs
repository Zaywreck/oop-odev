using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vcVideos
{
    public class Triangle : Shape
    {
        public Triangle()
        {

        }
        public Triangle(int x,int y)
        {
            X= x;
            Y= y;   

        }
        public override void Draw()
        {
            Console.WriteLine($"Drawing a Triangle"); ;
        }
    }
}
