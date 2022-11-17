using SabahLama;
using System.Collections;
using System.Runtime.CompilerServices;

public class Program
{
    public static void Main(string[] args)
    {
        Customer c1 = new Customer(1,"Sena Nur","Eren","Zaywreck","sena.eren0058@gmail.com","SENAE203.");
        Customer c2 = new Customer(2, "Mert", "Gülle", "MertReyiz58", "mgulle35@gmail.com", "1987182658m");

        Customer.AddCustomer(c1);
        Customer.AddCustomer(c2);
        Customer.GetCustomers();
        Console.WriteLine("Process is Done");

    }
}