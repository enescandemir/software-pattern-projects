using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _221229064_BilalEnes_Candemir_commerceApp2
{
    public interface IItemFactory
    {
        ItemType CreateItemType();
        ID CreateID(int newID);
        TotalCost CreateTotalCost(int cost);
    }

    public class StandartItemFactory : IItemFactory
    {
        public ItemType CreateItemType()
        {
            return new ItemType("Standart item.");
        }

        public ID CreateID(int newID)
        {
            return new ID(newID);
        }

        public TotalCost CreateTotalCost(int cost)
        {
            return new TotalCost(cost);
        }
    }

    public class PremiumItemFactory : IItemFactory // total cost without shipping fee
    {
        public ItemType CreateItemType()
        {
            return new ItemType("Premium Item");
        }

        public ID CreateID(int newID)
        {
            return new ID(newID+50);
        }

        public TotalCost CreateTotalCost(int cost)
        {
            return new TotalCost(cost-20);
        }
    }

    public class Item
    {
        public ItemType Type { get; }
        public Category Category { get; }
        public TotalCost TotalCost { get; }
        public ID ID { get; }
        public string Name { get; }

        public Item(IItemFactory itemFactory, Category category,int cost, string name,int id)
        {
            Name = name;
            Category = category;
            Type = itemFactory.CreateItemType();
            TotalCost = itemFactory.CreateTotalCost(cost);
            ID = itemFactory.CreateID(id);
        }
    }

    public class ItemType
    {
        private string itemType;

        public ItemType(string itemType)
        {
            this.itemType = itemType;
        }

        public string GetType()
        {
            return itemType;
        }
    }

    public class ID
    {
        private int id;

        public ID(int id)
        {
            this.id = id;
        }

        public int GetId()
        {
            return id;
        }
    }

    public class TotalCost
    {
        private int cost;
        private int shippingCost = 20;

        public TotalCost(int cost)
        {
            this.cost = cost;
        }

        public int CalculateTotalCost()
        {
            return cost + shippingCost;
        }
        public int getCost()
        {
            return cost;
        }
    }

}
