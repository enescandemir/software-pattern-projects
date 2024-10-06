using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _221229064_BilalEnes_Candemir_commerceApp
{
    public class WrongSRPExample // all functions on 1 class.
    {
        public int id;
        public String name;
        public int cost;
        public Category category;
        public int shippingFee;
        public int totalCost;
        public WrongSRPExample(int id, String name, int cost, int shippingFee,Category category)
        {
            this.id = id;
            this.name = name;
            this.cost = cost;
            this.shippingFee = shippingFee;
            this.category = category;
        }
        public void ItemId()
        {
            Console.WriteLine("This item's id is " + id + " dollars.");
        }
        public void ItemName()
        {
            Console.WriteLine("This item's stock name is " + name + " dollars.");
        }
        public void ItemCost(User user)
        {
            Console.WriteLine("This item costs " + cost + " dollars for " + user.name + " without shipping fee.");
        }
        public void ItemCategory()
        {
            Console.WriteLine("This item's category is " + category + ".");
        }
        public void ItemShippingFee(User user)
        {
            Console.WriteLine("This item's shipping fee is " + shippingFee + " for " + user.name + ".");
        }
        public static void ShippingCostCalculator(User user, int distance,ItemData item)
        {
            int shippingcost;
            if (user.isPremium)
                item.shippingFee = 0;
            else
            {
                if (distance > 400)
                {
                    shippingcost = user.type.getShippingCost();
                    shippingcost *= 4;
                    item.shippingFee = shippingcost;
                }
                else if (distance <= 400 && distance > 300)
                {
                    shippingcost = user.type.getShippingCost();
                    shippingcost *= 3;
                    item.shippingFee = shippingcost;
                }
                else if (distance <= 300 && distance > 200)
                {
                    shippingcost = user.type.getShippingCost();
                    shippingcost *= 2;
                    item.shippingFee = shippingcost;
                }
                else
                {
                    item.shippingFee = user.type.getShippingCost();
                }

            }

        }
        public static void TotalCostCalculator(ItemData itemdata, User user)
        {
            if (user.isPremium == false)
            {
                itemdata.totalCost = itemdata.cost + itemdata.shippingFee - user.type.getDiscount();
            }
            else
            {
                itemdata.totalCost = itemdata.cost - user.type.getDiscount();
            }

        }
    }
}
