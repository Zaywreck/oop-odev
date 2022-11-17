using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vize_1_oop
{
    public class Employee
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }

        private string _fullname;
        public string FullName
        {
            get
            {
                return _fullname;
            }
            set
            {
                _fullname = firstName + lastName;
            }
        }
        public int Salary { get; set; } 

        public override string? ToString()
        {
            return FullName;
        }

        public Employee(int id, string firstName, string lastName)
        {
            Id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            _fullname = firstName + " " + lastName;
        }
    }
}
