using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes
{
    public abstract class Animal
    {
        public abstract string Name { get; set; }
        public void SetName(string name)
        {
            this.Name = name;
        }
        public void GetName()
        {
            Console.WriteLine($"my name is {Name}");
        }
        public abstract void Eat();

    }
}
