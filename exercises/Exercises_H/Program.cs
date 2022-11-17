namespace Exercises_H
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var list = new List<Employee>()
            {
                new Employee(1,"mert","gülle",5000),
                new Employee(),
                new Employee(),
                new Employee(),
                new Employee(),
            };

            Console.WriteLine(list.Count);
            
        }
    }

}

