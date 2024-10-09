using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _221229064_BilalEnes_Candemir_commerceApp3._221229064_Strategy_Categories
{
    public class Category
    {
        public int id;
        public string name;
        public string description;
        private ICategory blender = new Blender();
        private ICategory iron = new Iron();
        private ICategory coffeeMachine = new CoffeeMachine();

        public void CreateCategory(int id)
        {
            this.id = id;
            if (id < 10)
            {
                blender.Create(this);
            }
            else if (id >= 10 && id < 20)
            {
                iron.Create(this);
            }
            else
            {
                coffeeMachine.Create(this);
            }
        }
        public void Start()
        {
            if (id < 10)
            {
                blender.Start();
            }
            else if (id >= 10 && id < 20)
            {
                iron.Start();
            }
            else
            {
                coffeeMachine.Start();
            }
        }
    }
}
