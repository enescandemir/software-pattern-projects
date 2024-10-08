namespace _221229064_BilalEnes_Candemir_commerceApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var customerFactory = new CustomerFactory(); // factory method
            IType Jacob = customerFactory.CreateCustomer(CustomerType.Student,100,"Jacob");
            IType Melissa = customerFactory.CreateCustomer(CustomerType.Employee, 100, "Melissa");
            IType David = customerFactory.CreateCustomer(CustomerType.Standart, 100, "David");
            Jacob.LogIn();
            Jacob.LogIn();
            Jacob.ShowBalance();
            
            var builder = new ConcreteBuilder(); // builder method
            var director = new Director(builder);
            director.BuildFullCategory(1, "C_Blender", "Blends stuff.");
            Category blender = director.GetResult();
            director.BuildNameOnly("C_IronMachine");
            Category iron = director.GetResult();
            Console.WriteLine(iron.name);    // Iron Machine
            Console.WriteLine(blender.name); // Blender

            IItemFactory standartItemFactory = new StandartItemFactory(); // abstract factory method
            IItemFactory premiumItemFactory = new PremiumItemFactory(); 
            Item itemBlender = new Item(standartItemFactory, blender,200, "Blender",1);
            Item itemIron = new Item(premiumItemFactory, iron, 200, "Iron", 1);
            Console.WriteLine("Blender's ID is : " +itemBlender.ID.GetId());
            Console.WriteLine("Iron's ID is : " + itemIron.ID.GetId());
            Console.WriteLine("Blender's type is : " + itemBlender.Type.GetType());
            Console.WriteLine("Iron's type is : " + itemIron.Type.GetType());
            Console.WriteLine("Blender's total cost is : " + itemBlender.TotalCost.CalculateTotalCost());
            Console.WriteLine("Blender's cost without shipping fee is : " + itemBlender.TotalCost.getCost());
            Console.WriteLine("Iron's total cost is : " + itemIron.TotalCost.CalculateTotalCost());

            ITrade trader1 = new Trade(itemBlender, Jacob); // dependency injection method
            Jacob.LogOff();
            trader1.BuyItem();
            Jacob.LogIn();
            trader1.BuyItem();
            trader1.SellItem();
            trader1.BuyItem();
            trader1.BuyMembership();
            trader1.BuyMembership();
            Jacob.LogOff();
            Jacob.LogOff();
        }
    }
}