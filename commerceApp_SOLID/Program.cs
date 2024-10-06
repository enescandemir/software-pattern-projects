namespace _221229064_BilalEnes_Candemir_commerceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IType type = new Student();
            User Jacob = new User(type,3000,false,"Jacob");
            Jacob.LogIn();
            Jacob.LogIn();
            Jacob.TypeDiscount();
            Jacob.TypeMembershipCost();
            Jacob.TypeShippingCost();
            CategoryCreator categoryCreator = new CategoryCreator(); // makes new categories
            CategoryWriter categoryWriter = new CategoryWriter(); // sets categories to items
            CategoryChanger categoryChanger = new CategoryChanger();// changes category infos.
            Category CategoryBlender = categoryCreator.CreateCategory(001, "Blender", "Blends stuff.");
            Category CategoryIron = categoryCreator.CreateCategory(003, "Iron", "Helps to wash clothes."); // wrong description
            categoryWriter.CategoryDescription(CategoryIron);
            categoryChanger.ChangeCategoryDescription(CategoryIron, "Presses clothes to remove wrinkles and unwanted creases.");
            categoryWriter.CategoryDescription(CategoryIron);
            ItemData blender = new ItemData(123,"B-309",309,CategoryBlender);
            ShippingCost.ShippingCostCalculator(Jacob, 201,blender);        
            TotalCost.TotalCostCalculator(blender, Jacob);
            DataWriter blenderData =  new DataWriter(blender);
            blenderData.ItemCost(Jacob);
            blenderData.ItemShippingFee(Jacob);
            blenderData.ItemCategory();
            PointCalculatorStudent pointCalculatorStudent = new PointCalculatorStudent();
            pointCalculatorStudent.CalcutePoint(15, 30, Jacob);
            pointCalculatorStudent.StudentBonusPoints(Jacob);
            Jacob.ShowPoints();
            Trader trader = new Trader();
            Jacob.ShowBalance();
            trader.Buy(Jacob, blender);
            trader.BuyPremium(Jacob);
            ShippingCost.ShippingCostCalculator(Jacob, 201, blender);
            TotalCost.TotalCostCalculator(blender, Jacob);          
            trader.Buy(Jacob, blender);
            trader.Sell(Jacob, blender);
            Jacob.LogOff();
        }
    }
}