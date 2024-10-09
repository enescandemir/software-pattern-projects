using _221229064_BilalEnes_Candemir_commerceApp3._221229064_Facade_customerType;
using _221229064_BilalEnes_Candemir_commerceApp3._221229064_Facade_itemActivities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _221229064_BilalEnes_Candemir_commerceApp3._221229064_Command_buySellMethods
{
    public class BuyPremiumAction : AbstractAction
    {
        private IType user;

        public BuyPremiumAction(IType user)
        {
            this.user = user;
        }

        public override void Execute()
        {
            if (user.IsLoggedIn() == true)
            {
                if(user.IsPremium() == true)
                {
                    Console.WriteLine(user.getName() + " named user already has premium.");
                }
                else
                {
                    if (user.getBalance() >= user.getPremiumCost())
                    {
                        user.setBalance(user.getBalance() - user.getPremiumCost());
                        user.setPremiumStatus(true);
                        Console.WriteLine(user.getName() + " named user bought premium for " + user.getPremiumCost() + " dollars. " + user.getBalance() + " dollars balance left in account.");
                    }
                    else
                    {
                        Console.WriteLine(user.getName() + " named user does not have enough money.");
                    }
                }
            }
            else
            {
                Console.WriteLine(user.getName() + " named user didn't logged in yet.");
            }

        }

        public override void Undo()
        {
            if (user.IsLoggedIn() == true)
            {
                if(user.IsPremium() == true)
                {
                    user.setBalance(user.getBalance() + user.getPremiumCost());
                    user.setPremiumStatus(false);
                    Console.WriteLine(user.getName() + " named user undid buying premium command. This account is no longer premium account. Current balance is : " + user.getBalance());
                }
                else
                {
                    Console.WriteLine(user.getName() + " named user doesn't have premium account. Undo failed.");
                }
            }
            else
            {
                Console.WriteLine(user.getName() + " named user didn't logged in yet.");
            }
        }

        public override void Redo()
        {
            if (user.IsLoggedIn() == true)
            {
                Console.WriteLine(user.getName() + " named user redid buying premium command.");
                Execute();
            }
            else
            {
                Console.WriteLine(user.getName() + " named user didn't logged in yet.");
            }

        }
    }
}
