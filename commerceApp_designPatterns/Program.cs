using _221229064_BilalEnes_Candemir_commerceApp3._221229064_Command_buySellMethods;
using _221229064_BilalEnes_Candemir_commerceApp3._221229064_Facade_customerType;
using _221229064_BilalEnes_Candemir_commerceApp3._221229064_Facade_itemActivities;
using _221229064_BilalEnes_Candemir_commerceApp3._221229064_Strategy_Categories;
using System.Windows.Input;

namespace _221229064_BilalEnes_Candemir_commerceApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            UserManager userManager = new UserManager(3000, "Manager"); // Composite
            IType Jacob = new StudentUser(3000, "Jacob");
            IType Melissa = new EmployeeUser(3000, "Melissa");
            IType John = new StandartUser(3000, "John");
            List<IType> userList = new List<IType>() { Jacob, Melissa, John };
            userManager.AddUser(Jacob);
            userManager.AddUser(Melissa);
            userManager.AddUser(John);
            //userManager.AddUsers(userList);
            userManager.LogIn();
            Console.WriteLine();
            userManager.TypeDiscount();
            Console.WriteLine();
            userManager.TypeType();
            Console.WriteLine();
            userManager.RemoveUser(John);
            userManager.TypeType();
            Console.WriteLine();

            Category Blender = new Category(); // Strategy
            Blender.CreateCategory(7);
            Category Iron = new Category();
            Iron.CreateCategory(15);
            Console.WriteLine();

            Item item = new Item(Blender, 300, "Blender Machine", 1,EItemType.Standart); // Facade
            item.Start();
            Console.WriteLine();
            Item item2 = new Item(Iron, 300, "Iron Machine", 1, EItemType.Premium); 
            item2.Start();
            Console.WriteLine();


            IAction buyCommand = new BuyAction(item2,Jacob); // Command
            buyCommand.Execute();
            Jacob.LogOff();
            buyCommand.Redo();
            Jacob.LogIn();
            buyCommand.Redo();
            buyCommand.Undo();
            Console.WriteLine();
            
            IAction sellCommand = new SellAction(item2,Jacob);
            sellCommand.Execute();
            sellCommand.Redo();        
            sellCommand.Undo();
            Console.WriteLine();

            IAction buyPremiumCommand = new BuyPremiumAction(Jacob);
            buyPremiumCommand.Execute();
            buyPremiumCommand.Redo();
            buyPremiumCommand.Undo();
            buyPremiumCommand.Redo();

            Console.WriteLine();
            userManager.LogOff();
            userManager.LogOff();

        }
    }
}