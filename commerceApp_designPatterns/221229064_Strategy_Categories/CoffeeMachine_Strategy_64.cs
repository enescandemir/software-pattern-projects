using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _221229064_BilalEnes_Candemir_commerceApp3._221229064_Strategy_Categories
{
    public class CoffeeMachine : ICategory
    {
        public void Create(Category category)
        {
            category.name = "Coffee Machine";
            category.description = "This is a coffee machine category.";
            Console.WriteLine("Coffee machine category created.");
        }
        public void Start()
        {
            Console.WriteLine("This item's category set as Coffee Machine.");
        }
    }
}
