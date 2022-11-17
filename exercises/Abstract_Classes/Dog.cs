using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes
{
    public class Dog : Animal
    {
        public override string Name { get; set; }

        public override void Eat()
        {
            Console.WriteLine("dog is eating");
        }
    }
}
