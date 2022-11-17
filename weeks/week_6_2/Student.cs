using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_6_2
{
    public class Student : Person
    {
        public Student(int id, string fullName) : base(id, fullName)
        {
        }

        public override void Poop()
        {
            Console.WriteLine("Yırtıl Dedim ** poposu!!"); ;
        }
    }
}
