using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _221229064_BilalEnes_Candemir_commerceApp
{
    public class ItemData
    {
        public int id;
        public String name;
        public int cost;
        public Category category ;  
        public int totalCost;
        public int shippingFee;
        public ItemData(int id, String name, int cost,Category category)
        {
            this.id = id;
            this.name = name;
            this.cost = cost;
            this.category = category;
        }
    }

    public class DataWriter
    {
        ItemData item;
        public DataWriter(ItemData item)
        {
            this.item = item;
        }
        public void ItemId()
        {
            Console.WriteLine("This item's id is " + item.id + " dollars.");
        }
        public void ItemName()
        {
            Console.WriteLine("This item's stock name is " + item.name + " dollars.");
        }
        public void ItemCost(User user)
        {
            Console.WriteLine(item.name + "'s costs " + (item.cost - user.type.getDiscount()) + " dollars for without shipping fee for " + user.name + ".");
        }
        public void ItemCategory()
        {
            Console.WriteLine("This item's category is " + item.category.name + ".");
        }
        public void ItemShippingFee(User user)
        {
            Console.WriteLine(item.name + "'s shipping fee is " + item.shippingFee + " dollars for " + user.name + ".");
        }
    }

    public class ShippingCost
    {
        public static void ShippingCostCalculator(User user, int distance, ItemData item)
        {
            int shippingcost;
            if (user.isPremium == true)
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
    }
    public class TotalCost
    {
        public static void TotalCostCalculator(ItemData itemdata,User user)
        {
            if(user.isPremium == false)
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
    

