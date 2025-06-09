namespace MoneyApp;

internal class Program
{
    static void Main(string[] args)
    {
        Money money = new Money(100, 250);
        money.ShowAmount();
        Product product = new Product("Phone", money,  15);
        product.PriceWithPromotion();
    }
}
