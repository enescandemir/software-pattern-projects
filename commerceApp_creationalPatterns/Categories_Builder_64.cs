using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _221229064_BilalEnes_Candemir_commerceApp2
{
    public class Category
    {
        public int id;
        public string name;
        public string description;
    }

    public interface IBuilder
    {
        void BuildPartID(int id);
        void BuildPartName(string name);
        void BuildPartDescription(string description);
        Category GetResult();
    }
    public class Director
    {
        private IBuilder cBuilder;
        private Category result;
        public Director(IBuilder builder)
        {
            this.cBuilder = builder;
        }
        public void BuildNameOnly(string name)
        {
            this.cBuilder.BuildPartName(name);
            this.result = this.cBuilder.GetResult();
        }
        public void BuildFullCategory(int id, string name, string description)
        {
            this.cBuilder.BuildPartID(id);
            this.cBuilder.BuildPartName(name);
            this.cBuilder.BuildPartDescription(description);
            this.result = this.cBuilder.GetResult();
        }
        public void BuildFullCategory2(string description, int id, string name)
        {
            this.cBuilder.BuildPartDescription(description);
            this.cBuilder.BuildPartID(id);
            this.cBuilder.BuildPartName(name);
            this.result = this.cBuilder.GetResult();
        }
        public Category GetResult()
        {
            return result;
        }
    }
    public class ConcreteBuilder : IBuilder
    {
        private Category category = new Category();
        public ConcreteBuilder()
        {
            this.Reset();
        }
        public void Reset()
        {
            this.category = new Category();
        }
        public void BuildPartID(int id)
        {
            this.category.id = id;
        }
        public void BuildPartName(string name)
        {
            this.category.name = name;
        }
        public void BuildPartDescription(string description)
        {
            this.category.description = description;
        }
        public Category GetResult()
        {
            Category result = this.category;
            this.Reset();
            return result;
        }
    }
}
