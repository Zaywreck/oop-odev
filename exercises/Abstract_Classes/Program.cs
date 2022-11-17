namespace Abstract_Classes
{
    public static class Program
    {
        public static void Main()
        {
            Dog dog = new Dog();
            string x = Console.ReadLine();
            dog.SetName(x);
            dog.GetName();
            dog.Eat();

        }
    }
}