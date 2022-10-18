using week_3;
public class Program
{
    public static void Main(string[] args)
    {
        Product Eti = new Product(12, 1, "Biscuit");
        Product Ulker = new Product(8, 2, "Chocolate");
        Product Haribo = new Product(15, 3, "Jellybeans");

        CartItem cartItem_1 = new CartItem(1, Eti, 2);

        CartItem cartItem_2 = new CartItem(2, Ulker, 5);

        CartItem cartItem_3 = new CartItem(3, Haribo, 1);


        ShoppingCart Cart = new ShoppingCart();

        Cart.Add(cartItem_1);
        Cart.Add(cartItem_2);
        Cart.Add(cartItem_3);
        Console.WriteLine(Cart.GetBalance());
        Cart.Remove(2);
        Cart.GetList();


    }
}