using _221229064_BilalEnes_Candemir_commerceApp3._221229064_Strategy_Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _221229064_BilalEnes_Candemir_commerceApp3._221229064_Facade_itemActivities
{
    public class Item
    {
        public ItemType Type { get; }
        public Category Category { get; }
        public TotalCost TotalCost { get; }
        public ID ID { get; }
        public string Name { get; }

        public Item(Category category, int cost, string name, int id,EItemType itemtype)
        {
            Type = new ItemType(itemtype);
            Category = category;
            TotalCost = new TotalCost(cost);
            if(itemtype == EItemType.Standart)
            {
                ID = new ID(id);
            }
            else
            {
                ID = new ID(50 + id);
            }
            Name = name;
        }
        public void Start()
        {
            Type.Start();
            ID.Start();
            TotalCost.Start(this);
            Category.Start();
            Console.WriteLine("Item setup is completed.");
        }
    }
}
