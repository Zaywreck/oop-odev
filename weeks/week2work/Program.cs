using System.ComponentModel;
using First;

class Program
{
    public static void Main(string[] args)
    {
        Manager manager = new Manager();

        Employee employee = new Employee(1, "Meti", "Gül");
        Employee employee1 = new Employee(2, "Sena Nur", "Eren");
        Console.WriteLine(employee.FirstName);
        Console.WriteLine(employee1.FirstName);

        manager.Add(employee);
        manager.Add(employee1);
        
        manager.Show();
        manager.Remove(1);
        manager.Show();
    }
}
