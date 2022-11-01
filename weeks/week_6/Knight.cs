using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_6
{
    public class Knight : Character
    {
       
        private string _name;
        private int _health;
        private int _stamina;
        private int _damage;
        public override string Name { get => _name; set => _name = value; }
        public override int Health { get => _health; set => _health = value; }
        public override int Stamina { get => _stamina; set => _stamina = value; }
        public override int Damage { get => _damage; set => _damage = value; }
        
        public Knight(string name)
        {
            Name = name;
            Health = 100;
            Stamina = 100;
            Damage = 10;
        }


        public override void Wait()
        {
            if (Stamina < 100)
                Stamina += 15;
        }
    }
}
