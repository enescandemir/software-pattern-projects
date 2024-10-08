using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _221229064_BilalEnes_Candemir_commerceApp2
{
    public interface ITrade
    {
        public void BuyItem();
        public void SellItem();
        public void BuyMembership();
    }
    public class Trade : ITrade
    {
        Item _item;
        IType _user;

        public Trade(Item item, IType user)
        {
            _item = item;
            _user = user;
        }

        public void BuyItem()
        {
            if (_user.IsLoggedIn() == true)
            {
                int totalPrice = _item.TotalCost.CalculateTotalCost() - _user.getDiscount();
                if (_user.getBalance() >= totalPrice)
                {
                    _user.setBalance(_user.getBalance() - totalPrice);
                    Console.WriteLine(_user.getName() + " named user bought " + _item.Name + " for " + totalPrice + " dollars. " + _user.getBalance() + " dollars balance left in account.");
                }
                else
                {
                    Console.WriteLine(_user.getName() + " named user does not have enough money.");
                }
            }
            else
            {
                Console.WriteLine(_user.getName() + " named user didn't logged in yet.");
            }
        }

        public void SellItem()
        {
            if (_user.IsLoggedIn() == true)
            {
                int totalPrice = _item.TotalCost.getCost();
                _user.setBalance(_user.getBalance() + totalPrice);
                Console.WriteLine(_user.getName() + " named user sold " + _item.Name + " for " + totalPrice + " dollars. " + _user.getBalance() + " dollars balance in account.");
            }
            else
            {
                Console.WriteLine(_user.getName() + " named user didn't logged in yet.");
            }
        }
        public void BuyMembership()
        {
            if (_user.IsLoggedIn() == true)
            {
                if (_user.IsPremium() == true)
                {
                    Console.WriteLine(_user.getName() + " named user already has premium.");
                }
                else
                {
                    if(_user.getBalance() >= _user.getPremiumCost())
                    {
                        _user.setBalance(_user.getBalance() - _user.getPremiumCost());
                        _user.setPremiumStatus(true);
                        Console.WriteLine(_user.getName() + " named user bought premium for " + _user.getPremiumCost() + " dollars. " + _user.getBalance() + " dollars balance left in account.");
                    }
                    else
                    {
                        Console.WriteLine(_user.getName() + " named user does not have enough money.");
                    }
                   
                }
            }
            else
            {
                Console.WriteLine(_user.getName() + " named user didn't logged in yet.");
            }
        }
    }
}
