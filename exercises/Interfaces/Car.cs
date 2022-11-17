using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Car : IVehiculo
    {
        public int GasAmount { get; set; }

        public Car(int gasAmount)
        {
            GasAmount = gasAmount;
        }

        public void Drive()
        {
            if (GasAmount > 0)
            {
                Console.WriteLine("Driving");
            }
            else
            {
                Console.WriteLine("enter the amount of refuel: ");
                int x = Convert.ToInt32(Console.ReadLine());
                if (Refuel(x))
                {
                    Drive();
                }
            }
        }

        public bool Refuel(int AmountOfRefuel)
        {
            GasAmount += AmountOfRefuel;
            return true;
        }
    }
}
