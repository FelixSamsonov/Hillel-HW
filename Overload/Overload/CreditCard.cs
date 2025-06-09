using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload;

class CreditCard
{
    public string OwnerName { get; set; }
    public string OwnerSurname { get; set; }
    public short CVC {  get; set; }
    public decimal CreditLimit { get; set; } = 100000;
    private decimal ownMoney;
    public decimal InvestmentProfit { get; set; } = 15000;
    private decimal cardBalance;
    public decimal Taxes { get { return OwnMoney * 0.2m; } }
    public static CreditCard operator ++(CreditCard creditCard)
    {
        return new CreditCard(creditCard.OwnerName, creditCard.OwnerSurname,
                        creditCard.OwnMoney + creditCard.InvestmentProfit, creditCard.CVC);
    }
    public static CreditCard operator --(CreditCard creditCard)
    {
        return new CreditCard(creditCard.OwnerName, creditCard.OwnerSurname,
                        creditCard.OwnMoney - creditCard.Taxes, creditCard.CVC);
    }
    public static bool operator ==(CreditCard creditCard1, CreditCard creditCard2)
    {
        return creditCard1.CVC == creditCard2.CVC;
    }
    public static bool operator !=(CreditCard creditCard1, CreditCard creditCard2)
    {
        return creditCard1.CVC == creditCard2.CVC;
    }
    public static bool operator >(CreditCard creditCard1, CreditCard creditCard2)
    {
        return creditCard1.CardBalance > creditCard2.CardBalance;
    }
    public static bool operator <(CreditCard creditCard1, CreditCard creditCard2)
    {
        return creditCard1.CardBalance > creditCard2.CardBalance;
    }
    public CreditCard(string ownerName, string ownerSurname, decimal ownMoney, short cVC)
    {
        OwnerName = ownerName;
        OwnerName = ownerSurname;
        OwnMoney = ownMoney;
        CVC = cVC;
    }

    public decimal OwnMoney
    {
        get { return ownMoney; }
        set
        {
            if (value < 0)
                throw new Exception("You cannot have own money less than 0");
            else
            {
                ownMoney = value;
                cardBalance = OwnMoney + CreditLimit;
            }

        }
    }
    public decimal CardBalance => cardBalance;

}
