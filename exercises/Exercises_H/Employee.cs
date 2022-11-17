using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_H
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Fullname => $"{FirstName} {LastName}";

        private decimal _salary;

        public decimal Salary
        {
            get => _salary;
            set
            {
                if (_salary < 4500)
                {
                    _salary = 4500;
                }
                else
                {
                    _salary = value;
                }
            }
        }

        public Employee()
        {
        }

        public Employee(int id, string firstName, string lastName, decimal salary)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
        }


    }

    public class InMemoryDb
    {
        public static List<Employee> Employees = new List<Employee>()
        {
            new Employee { Id=1,FirstName="Mert", LastName="Gülle", Salary=3500 },
            new Employee { Id=1,FirstName="Burak", LastName="Aktaş", Salary=5500 },
            new Employee { Id=1,FirstName="Berke", LastName="Bilgin", Salary=31500 },
            new Employee { Id=1,FirstName="Ömer", LastName="Çalışır", Salary=35500 },
            new Employee { Id=1,FirstName="Hüseyin", LastName="Alav", Salary=135500 },
        };
    }

    public class EmployeeManager
    {
        public List<Employee> DeleteEmployeesWithIds(params int[] ids)
        {
            List<Employee> deletedEmployees = new();
            foreach (Employee item in InMemoryDb.Employees)
            {
                foreach (var id in ids)
                {
                    if(item.Id == id)
                    {
                        deletedEmployees.Add(item);
                        InMemoryDb.Employees.Remove(item);
                    }
                }
            }
            return deletedEmployees;
        }
    }

}
