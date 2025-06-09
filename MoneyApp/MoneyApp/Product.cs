using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace MoneyApp;

class Product
{
    public string? Name { get; set; }
    public Money Price { get; set; }
    private decimal promotion;
    
     
    public Product(string? name, Money price, decimal promotion)
    {
        Name = name;
        Price = price;
        this.Promotion = promotion;
        
    }
    public decimal Promotion
    {
        get { return promotion; }
        set
        {
            if (value > 0 && value < 100)
                promotion = value / 100;
            else
                throw new Exception("Promotion cannot be less than 0 or more than 99");
        }
    }
    public void PriceWithPromotion()
    {
        decimal price = Price.AmountWhole + Price.AmountCents / 100m;
        decimal priceWithPromotion = price * (1 - promotion);
        Console.WriteLine($"Price with promotion: {priceWithPromotion:F2} dollars");
    }
}
