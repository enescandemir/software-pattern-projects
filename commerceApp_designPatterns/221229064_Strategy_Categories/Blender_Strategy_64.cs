using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _221229064_BilalEnes_Candemir_commerceApp3._221229064_Strategy_Categories
{
    public class Blender : ICategory
    {
        public void Create(Category category)
        {
            category.name = "Blender";
            category.description = "This is a blender category.";
            Console.WriteLine("Blender category created.");
           
        }
        public void Start()
        {
            Console.WriteLine("This item's category set as Blender.");
        }
    }
}
