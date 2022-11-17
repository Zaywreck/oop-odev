using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vize_1_oop
{
    public class EmployeeManagaer
    {
        InMemoryDb data = new InMemoryDb();

        public EmployeeManagaer()
        {
            InMemoryDb data = new InMemoryDb();

        }

        

        public int Lowestsalary(List<Employee> x,int n)
        {
            var list = new List<int>();

            foreach (Employee e in x)
            {
                list.Add(e.Salary);
            }
            list.Sort();

            return list[n];
        }

        public Employee Remove (int n,List<Employee>dataofemp)
        {
            foreach(Employee e in dataofemp)
            {
                if(e.Id == n)
                {
                    var removedEmployee = e;
                    dataofemp.Remove(e);
                    return removedEmployee;
                }

                else
                {
                    throw new Exception("Id not found");
                }
            }

        }

        
    }
}
