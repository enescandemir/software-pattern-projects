using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _221229064_BilalEnes_Candemir_commerceApp
{
    public class WrongTrader // high level class 
    {
        public void Buy(User user, ItemData item)
        {
            WrongTraderLow wrongTraderLow = new WrongTraderLow();
            wrongTraderLow.PurchaseItem(user, item);
        }
        public void Sell(User user, ItemData item)
        {
            WrongTraderLow wrongTraderLow = new WrongTraderLow();
            wrongTraderLow.SellItem(user, item);
        }
        public void BuyPremium(User user, int membershipCost)
        {
            WrongTraderLow wrongTraderLow = new WrongTraderLow();
            wrongTraderLow.BuyPremium(user);
        }
    }

    public class WrongTraderLow // low level class
    {
        public void PurchaseItem(User user, ItemData item)
        {
            if (user.isLoggedIn == false)
            {
                Console.WriteLine("User named " + user.name + " didn't logged in yet. Purchase failed.");
            }
            else
            {
                if (user.balance >= item.totalCost)
                {
                    user.balance -= item.totalCost;
                    Console.WriteLine(user.name + " bought " + item.name + " for " + item.totalCost + " dollars. Current balance is : " + user.balance);
                }
                else
                {
                    Console.WriteLine(user.name + " has insufficient balance to purchase " + item.name + ".");
                }
            }
        }
        public void SellItem(User user, ItemData item)
        {
            if (user.isLoggedIn == false)
            {
                Console.WriteLine("User named " + user.name + " didn't logged in yet. Purchase failed.");
            }
            else
            {
                user.balance += item.cost;
                Console.WriteLine(user.name + " sold " + item.name + " for " + item.cost + " dollars. Current balance is : " + user.balance);
            }
        }
        public void BuyPremium(User user)
        {
            if (user.isLoggedIn == false)
            {
                Console.WriteLine("User named " + user.name + " didn't logged in yet. Purchase failed.");
            }
            else
            {
                if (user.isPremium == true)
                {
                    Console.WriteLine("User named " + user.name + " is already premium member.");
                }
                else
                {
                    if(user.balance >= user.type.getPremiumCost())
                    {
                        user.balance -= user.type.getPremiumCost();
                        user.isPremium = true;
                        Console.WriteLine(user.name + " bought a premium membership for " + user.type.getPremiumCost() + " dollars. Current balance is : " + user.balance);
                    }
                    else
                    {
                        Console.WriteLine(user.name + " has insufficient balance to purchase premium account.");
                    }
                }
            }
        }
    }
}
