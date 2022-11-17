using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IVehiculo
    {
        public void Drive();
        public bool Refuel(int AmountOfRefuel);
    }
}
