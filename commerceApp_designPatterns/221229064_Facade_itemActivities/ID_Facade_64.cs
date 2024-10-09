using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _221229064_BilalEnes_Candemir_commerceApp3._221229064_Facade_itemActivities
{
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
        public void Start()
        {
            Console.WriteLine("Item's ID set as : " + id);
        }
    }
}
