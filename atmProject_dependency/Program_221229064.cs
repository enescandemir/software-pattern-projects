namespace _221229064_BilalEnes_Candemir_atmProject
{
    class Program_221229064
    {
        static void RunDataOnlyATM()
        {
            dataOnly_221229064 dataOnly = new dataOnly_221229064();
            dataOnly.atmOnline = false;
            dataOnly.isLoggedIn = false;
            dataOnly.banknote50 -= 4; 
            dataOnly.userBalance -= 200;  
            dataOnly.banknote200 -= 5; 
            dataOnly.userBalance -= 800;
            dataOnly.userDebt += 200; 
            dataOnly.banknote200 += 5; 
            dataOnly.banknote100 += 5;
            dataOnly.banknote20 += 5;
            dataOnly.userBalance += 1600;
            dataOnly.userDebt -= 500; 
            dataOnly.userBalance -= 500;
            dataOnly.isLoggedIn = false;
            dataOnly.atmOnline = false;
            Console.WriteLine(dataOnly.userBalance);
            Console.WriteLine(dataOnly.banknote5);
            Console.WriteLine(dataOnly.userDebt);
        }

        static void RunGetterSetterATM()
        {
            getterSetter_221229064 getterSetter = new getterSetter_221229064();
            getterSetter.atmOnline = true;
            getterSetter.isLoggedIn = true;
            getterSetter.banknote100 -= 5; // cekme islemi 1500
            getterSetter.banknote200 -= 5;
            getterSetter.userBalance -= 1500; 
            getterSetter.userDebt += 500; // borc artiyor 800 
            getterSetter.banknote200 += 5; 
            getterSetter.banknote100 += 5;
            getterSetter.banknote50 += 6; 
            getterSetter.banknote20 += 10;
            getterSetter.userBalance += 2000; // balance artıyor
            getterSetter.userBalance -= 800; // borc odendi
            getterSetter.userDebt -= 800; 
            getterSetter.isLoggedIn = false;
            getterSetter.atmOnline = false;
            Console.WriteLine(getterSetter.userBalance);
            Console.WriteLine(getterSetter.banknote5);
            Console.WriteLine(getterSetter.userDebt);
        }

        static void RunPrimiviteATM()
        {
            Primitive_221229064 primitive = new Primitive_221229064();
            primitive.OpenATM();
            primitive.OpenATM();
            primitive.LogIn();
            primitive.LogIn();
            primitive.Withdraw(585);
            primitive.Deposit(585); // debt ile başlıyor
            primitive.LogOff();
            primitive.LogOff();
            primitive.CloseATM();
            primitive.CloseATM();
        }

        static void RunEncapsulatedATM()
        {
            Encapsulated_221229064 encapsulated = new Encapsulated_221229064();
            encapsulated.OpenATM();
            encapsulated.OpenATM();
            encapsulated.LogIn();
            encapsulated.LogIn();
            encapsulated.Withdraw(585);
            encapsulated.Deposit(585); // debt ile başlıyor
            encapsulated.LogOff();
            encapsulated.LogOff();
            encapsulated.CloseATM();
            encapsulated.CloseATM();
        }


        static void Main(string[] args)
        {
            //RunDataOnlyATM();
            //RunGetterSetterATM();
            //RunPrimiviteATM();
            RunEncapsulatedATM();
        }
    }
}