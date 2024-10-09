using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _221229064_BilalEnes_Candemir_commerceApp3._221229064_Strategy_Categories
{
    public class Iron : ICategory
    {
        public void Create(Category category)
        {
            category.name = "Iron";
            category.description = "This is an iron category.";
            Console.WriteLine("Iron category created.");
        }
        public void Start()
        {
            Console.WriteLine("This item's category set as Iron.");
        }
    }
}
