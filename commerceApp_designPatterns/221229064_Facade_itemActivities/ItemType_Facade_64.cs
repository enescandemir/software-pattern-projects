using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _221229064_BilalEnes_Candemir_commerceApp3._221229064_Facade_itemActivities
{
    public enum EItemType
    {
        Standart = 1,
        Premium = 2
    }
    public class ItemType
    {
        private EItemType itemType;
        public ItemType(EItemType itemType)
        {
            this.itemType = itemType;
        }

        public EItemType GetItemType()
        {
            return itemType;
        }

        public void Start()
        {
            Console.WriteLine("Item's type set as " + itemType);
        }
    }
}
