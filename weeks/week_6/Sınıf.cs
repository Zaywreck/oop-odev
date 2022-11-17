using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace week_6
{
    internal class Sınıf
    {
        public int MyProperty { get; set; }

        public Sınıf()
        {

        }
        public Sınıf(int id) { }
        public Sınıf(int id, string name) 
        {
            Console.WriteLine("this is third ctor.");
        }

        public void Method1(int x)
        {
            this.MyProperty = x;    
        }

    }
}