using _221229064_BilalEnes_Candemir_commerceApp3._221229064_Facade_customerType;
using _221229064_BilalEnes_Candemir_commerceApp3._221229064_Facade_itemActivities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _221229064_BilalEnes_Candemir_commerceApp3._221229064_Command_buySellMethods
{
    public class BuyAction : AbstractAction
    {
        private Item item;
        private IType user;

        public BuyAction(Item item, IType user)
        {
            this.item = item;
            this.user = user;
        }

        public override void Execute()
        {
            if (user.IsLoggedIn() == true)
            {
                int totalPrice = item.TotalCost.getTotalCost() - user.getDiscount();

                if (user.getBalance() >= totalPrice)
                {
                    user.setBalance(user.getBalance() - totalPrice);
                    Console.WriteLine(user.getName() + " named user bought " + item.Name + " for " + totalPrice + " dollars. " + user.getBalance() + " dollars balance left in account.");
                }
                else
                {
                    Console.WriteLine(user.getName() + " named user does not have enough money to buy " + item.Name + ".");
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
                int totalPrice = item.TotalCost.getTotalCost() - user.getDiscount();
                user.setBalance(user.getBalance() + totalPrice);
                Console.WriteLine(user.getName() + " named user undid buy command. User's current balance is : " + user.getBalance());
            }
            else
            {
                Console.WriteLine(user.getName() + " named user didn't logged in yet.");
            }
        }

        public override void Redo()
        {
            if(user.IsLoggedIn() == true)
            {
                Console.WriteLine(user.getName() + " named user redid buy command.");
                Execute();
            }
            else
            {
                Console.WriteLine(user.getName() + " named user didn't logged in yet.");
            }
            
        }
    }
}
