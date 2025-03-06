namespace MoneyApp;

internal class Program
{
    static void Main(string[] args)
    {
        Money money = new Money(100, 150);
        money.ShowAmount();
        Product product = new Product("Phone", money,  100);
        product.PriceWithPromotion();
    }
}
