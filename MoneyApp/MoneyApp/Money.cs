using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyApp;

class Money
{
    private int amountWhole;
    private byte amountCents;

    public Money(int amountWhole, byte amountCents)
    {
        AmountWhole = amountWhole;
        AmountCents = amountCents;
    }

    public int AmountWhole
    {
        get { return amountWhole; }
        set
        {
            if (value >= 0)
                amountWhole = value;
            else
                throw new Exception("Amount cannot be less than 0 ");
        }
    }
    public byte AmountCents
    {
        get { return amountCents; }
        set
        {
          
            if (value >=0 )
            {
                amountWhole += value / 100;
                amountCents = (byte)(value % 100);
            }

            else
                throw new Exception("Cents cannot be less than 0");
        }
    }
     public void ShowAmount()
    {
        Console.WriteLine($"Price: {AmountWhole} dollars {AmountCents} cents");
    }
}
