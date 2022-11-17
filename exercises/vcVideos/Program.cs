namespace vcVideos
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var saver = new SaverAccount();
            saver.PayIn(3000);
            saver.Withdraw(2000);
            saver.Withdraw(2000);
            Console.WriteLine(saver.Balance);
            Console.WriteLine(saver);








            //var shapes = new List<Shape>()
            //{
            //    new Rectangle(),
            //    new Circle(),
            //    new Triangle(),
            //};

            //foreach (var shape in shapes)
            //{
            //    shape.Draw();
            //}
            //var s1 = new Rectangle(5,5);
            //Console.WriteLine("{0},{1}",s1.X,s1.Y);

            /*var _s1 = new Rectangle();
            var _s2 = new Circle();
            
            _s1.X= 10;
            _s1.Y= 100;
            _s1.Draw();
            Console.WriteLine("{0},{1}",_s1.X ,_s1.Y);

            
            _s2.X= 5;
            _s2.Y= 55;
            _s2.Draw();
            Console.WriteLine("{0},{1}", _s2.X, _s2.Y);

            new Triangle().Draw();*/




            //var list = new List<Employee>()
            //{
            //    new Employee("Mert", "Eren", 19),
            //    new Employee("Sena", "Gülle", 19),
            //    new Employee("Berat", "Gülle", 10)
            //};

            //var employee = new Employee();
            //employee.Add(new Employee("Sena", "Gülle", 19));
            //employee.Add(new Employee("Berat", "Gülle", 10));
            //employee.Add(new Employee("Mert", "Eren", 19));

            //employee.AddRange(
            //    new Employee("Deniz", "soyad", 20),
            //    new Employee("Fadas", "Sadaf", 40),
            //    new Employee("Sedat", "CokAsker", 46)
            //    );
            //var list = employee.GetEmployees();

            //foreach(Employee emp in list)
            //{
            //    Console.WriteLine(emp);
            //}
        }
    }
}