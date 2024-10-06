using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _221229064_BilalEnes_Candemir_commerceApp
{

    public interface WrongCategoryEditor
    {
        public Category WrongCreateCategory(int Id, String Name, String Description);
        public void WrongCategoryId(Category category);
        public void WrongCategoryName(Category category);
        public void WrongCategoryDescription(Category category);
        public void WrongChangeCategoryName(Category category, String name);
        public void WrongChangeCategoryId(Category category, int id);
        public void WrongChangeCategoryDescription(Category category, String description);
    }

    public class  WrongCategory : WrongCategoryEditor
    {
        public Category WrongCreateCategory(int id, String name, String description)
        {
            Category newCategory = new Category(id, name, description);
            return newCategory;
        }
        public void WrongCategoryId(Category category)
        {
            Console.WriteLine("This category's id is : " + category.id + ".");
        }
        public void WrongCategoryName(Category category)
        {
            Console.WriteLine("This category's name is : " + category.name + ".");
        }
        public void WrongCategoryDescription(Category category)
        {
            Console.WriteLine("This category's description is : " + category.description + ".");
        }
        public void WrongChangeCategoryName(Category category, String name)
        {
            category.name = name;
            Console.WriteLine("Category Name changed to " + category.name + ".");
        }
        public void WrongChangeCategoryId(Category category, int id)
        {
            category.id = id;
            Console.WriteLine("Category Id changed to " + category.id + ".");
        }
        public void WrongChangeCategoryDescription(Category category, String description)
        {
            category.description = description;
            Console.WriteLine("Category Description changed to " + category.description + ".");
        }
    }
}
