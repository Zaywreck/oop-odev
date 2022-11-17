using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SabahLama
{
    public class Customer
    {
        private static List<Customer>? _customers;
        public static List<Customer>? Customers
        {
            get => _customers;
            set => _customers = value;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private string _nickname;
        public string NickName
        {
            get => _nickname;
            set
            {
                if (_customers == null)
                {
                    _nickname = value;
                }
                else
                {
                    foreach (Customer? c in _customers)
                    {
                        if (c._nickname == value)
                        {
                            Console.WriteLine("This Nickname has been taken...");
                        }
                        else
                        {
                            _nickname = value;
                        }
                    }
                }
            }
        }
        public string EmailAdress { get; set; }
        private string _password;
        public string Password { get => _password; set => _password = value; }
        public Customer() { }
        public Customer(int? id, string? firstName, string? lastName, string? nickName, string? emailAdress, string? password)
        {
            Id = (int)id;
            FirstName = firstName;
            LastName = lastName;
            NickName = nickName;
            EmailAdress = emailAdress;
            Password = password;
            _customers = new List<Customer>();
        }
        public static void AddCustomer(Customer? customer)
        {
            if (customer != null && customer._nickname != null)
            {
                foreach (Customer c in _customers)
                {
                    if (c.EmailAdress == customer.EmailAdress)
                    {
                        Console.WriteLine("Customer cannot be Added Email Adress has been taken...");
                    }
                    else
                    {
                        _customers.Add(customer);
                        Console.WriteLine(_customers);
                    }
                }
            }
        }
        public override string? ToString()
        {
            return $"{FirstName,-25} {LastName,20} {EmailAdress,10} ";
        }
        public static void GetCustomers()
        {
            foreach (Customer c in _customers)
            {
                Console.WriteLine(c);
            }
        }
    }
}
