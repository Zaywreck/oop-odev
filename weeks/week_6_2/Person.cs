using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_6_2
{
    public abstract class Person
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        protected Person()
        {

        }
        protected Person(int id, string fullName)
        {
            Id = id;
            FullName = fullName;
        }
        public void Pee()
        {
            Console.WriteLine("Peed!");
        }

        public abstract void Poop();
    }
}
