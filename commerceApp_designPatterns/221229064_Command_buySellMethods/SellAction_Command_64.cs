using _221229064_BilalEnes_Candemir_commerceApp3._221229064_Facade_customerType;
using _221229064_BilalEnes_Candemir_commerceApp3._221229064_Facade_itemActivities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _221229064_BilalEnes_Candemir_commerceApp3._221229064_Command_buySellMethods
{
    public class SellAction : AbstractAction
    {
        private Item item;
        private IType user;

        public SellAction(Item item, IType user)
        {
            this.item = item;
            this.user = user;
        }

        public override void Execute()
        {
            if (user.IsLoggedIn() == true)
            {
                int totalPrice = item.TotalCost.getCost();
                user.setBalance(user.getBalance() + totalPrice);
                Console.WriteLine(user.getName() + " named user sold " + item.Name + " for " + totalPrice + " dollars. " + user.getBalance() + " dollars balance in account.");
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
                int totalPrice = item.TotalCost.getCost();
                user.setBalance(user.getBalance() - totalPrice);
                Console.WriteLine(user.getName() + " named user undid sell command. User's current balance is : " + user.getBalance());
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
                Console.WriteLine(user.getName() + " named user redid sell command.");
                Execute();
            }
            else
            {
                Console.WriteLine(user.getName() + " named user didn't logged in yet.");
            }

        }
    }
}
