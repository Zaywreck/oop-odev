using week_6_2;

public class Program
{
    public static void Main()
    {
        List<Product> products = new List<Product>()
        {
            new Product(1,"Product A",15,5),
            new Product(5,"Product B",20,5),
            new Product(3,"Product C",10,5),
            new Product(6,"Product D",35,5),
            new Product(4,"Product E",40,5),
            new Product(2,"Product F",15,5),
        };
        Product product = new Product(products);
        product.GetProduct();
    }
}