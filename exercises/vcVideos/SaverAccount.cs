using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vcVideos
{
    public class SaverAccount : IBankAccount
    {
        private decimal _balance;
        public decimal Balance { get => _balance; set => _balance = value; }


        public bool Withdraw(decimal amount)
        {
            if(_balance>=amount)
            {
                _balance -= amount;
                return true;
            }
            Console.WriteLine("withdraw attempt failed");
            return false;
        }

        public override string ToString()
        {
            return $"Bank Account for Saver : {Balance} ";
        }
    }
}
