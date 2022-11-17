using vize_1_oop;

public class Program
{
    public static void Main()
    {
        Employee employee = new Employee(1,"mert","gülle");

        Console.WriteLine(employee);
        EmployeeManagaer employeeManagaer = new EmployeeManagaer();
    }
}