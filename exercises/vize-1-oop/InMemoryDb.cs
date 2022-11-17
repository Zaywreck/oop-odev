using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vize_1_oop
{
    public   class InMemoryDb
    {
        private  List<Employee> _list;

        public   List<Employee> Employees => _list;


        public  InMemoryDb()
        {
            var list = new List<Employee>()
            {
                new Employee(1,"Ahmet","can"),
                new Employee(2,"Ahet","an"),

            };    
        }
    }
}
