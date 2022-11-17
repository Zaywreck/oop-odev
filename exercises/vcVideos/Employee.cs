using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vcVideos
{
    public class Employee
    {
        private string _firstname;
        private string _lastname;
        private List<Employee> _list;

        public string FirstName
        {
            get
            {
                return _firstname;
            }
            set
            {
                _firstname = value;
            }
        }
        // expression bodied property accesors
        public string LastName { get => _lastname; set => _lastname = value; }
        //Auto-implemented property
        public int Age { get; set; }
        public List<Employee> Employees => _list;
        public Employee()
        {
            //Console.WriteLine("default ctor..");
            _list = new List<Employee>();
        }

        public Employee(string firstName, string lastName, int Age)
        {
            FirstName = firstName;
            LastName = lastName;
            this.Age = Age;
            _list = new List<Employee>();
            //Console.WriteLine("overloaded ctor...");
        }

        public override string? ToString()
        {
            return $"First Name: {FirstName,-20}" +
                $"Last Name: {LastName,-15}" +
                $"Age: {Age,5}";
        }

        public void Add(Employee employee)
        {
            _list.Add(employee);
        }

        public void AddRange(params Employee[] employees)
        {
            _list.AddRange(employees);
        }

        public List<Employee> GetEmployees() => _list;
    }
}
