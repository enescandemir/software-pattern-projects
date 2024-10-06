using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _221229064_BilalEnes_Candemir_commerceApp
{
    public class Category
    {
        public int id;
        public String name;
        public String description;
        public Category(int id,String name, String description)
        {
            this.id = id;
            this.name = name;
            this.description = description;
        }

    }
    public interface CategoryCreate
    {
        public Category CreateCategory(int id, String name, String description);
    }
    public interface CategoryWrite
    {
        public void CategoryId(Category category);
        public void CategoryName(Category category);
        public void CategoryDescription(Category category);
    }
    public interface CategoryEditor
    {
        public void ChangeCategoryName(Category category, String name);
        public void ChangeCategoryId(Category category, int id);
        public void ChangeCategoryDescription(Category category, String description);
    }

    public class CategoryCreator : CategoryCreate
    {
        public Category CreateCategory(int id, String name, String description)
        {
            Category newCategory = new Category(id, name, description);
            return newCategory;
        }
    }

    public class CategoryWriter : CategoryWrite
    {
        public void CategoryId(Category category)
        {
            Console.WriteLine("This category's id is : " + category.id + ".");
        }
        public void CategoryName(Category category)
        {
            Console.WriteLine("This category's name is : " + category.name + ".");
        }
        public void CategoryDescription(Category category)
        {
            Console.WriteLine(category.name + " category's description is : " + category.description + ".");
        }
    }
    public class CategoryChanger : CategoryEditor
    {
        public void ChangeCategoryName(Category category, String name)
        {
            category.name = name;
            Console.WriteLine("Category Name changed to " +  category.name + ".");
        }
        public void ChangeCategoryId(Category category, int id)
        {
            category.id = id;
            Console.WriteLine("Category Id changed to " + category.id + ".");
        }
        public void ChangeCategoryDescription(Category category, String description)
        {
            category.description = description;
            Console.WriteLine(category.name + " category's description changed to " + category.description + ".");
        }
    }
}
