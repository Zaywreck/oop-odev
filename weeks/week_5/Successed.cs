using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace week5
{
    public  class Successed : Result
    {
        public Successed() : base(true,"Successed")
        {

        }
        //overload
        public Successed(string message) : base(true,message)
        {
        }
    }
}

