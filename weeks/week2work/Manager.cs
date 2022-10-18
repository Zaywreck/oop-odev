using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    public class Manager
    {
        public List<Employee> employees = new List<Employee>();



        public void Add(Employee employee)
        {
            employees.Add(employee);
        }
        public void Remove(int id)
        {
            Employee deleteUser = null;
            foreach(Employee emp in employees)
            {
                if(emp.Id == id)
                    deleteUser = emp;
            }
            if(deleteUser == null)
            {
                throw new ArgumentNullException(nameof(Employee));
            }
            employees.Remove(deleteUser);
        }
        public void Show()
        {
            foreach(Employee emp in employees)
            {
                Console.WriteLine(emp);
            }
        }
    }
}
