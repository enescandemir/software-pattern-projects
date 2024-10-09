using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _221229064_BilalEnes_Candemir_commerceApp3._221229064_Facade_itemActivities
{
    public class TotalCost
    {
        private int cost;
        private int shippingCost = 20;
        private int totalcost;

        public TotalCost(int cost)
        {
            this.cost = cost;
        }

        public void Start (Item item)
        {
            if(item.Type.GetItemType() == EItemType.Standart)
            {
                totalcost = cost + shippingCost;
                Console.WriteLine("Item's total cost set as : " + totalcost);
            }
            else
            {
                totalcost = cost;
                Console.WriteLine("Item's total cost set as : " + totalcost);
            }
            
        }
        public int getTotalCost()
        {
            return totalcost;
        }
        public int getCost()
        {
            return cost;
        }
    }
}
