using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _221229064_BilalEnes_Candemir_commerceApp
{
    public class WrongOCPExample //
    {
        public String type;
        public WrongOCPExample(String type)
        {
            this.type = type;
        }
        public void TypeDiscountInfo()
        {
            switch (type)
            {
                case "Student":
                    Console.WriteLine(type + " has 60 dollar discount.");
                    break;
                case "Employee":
                    Console.WriteLine(type + " has 30 dollar discont.");
                    break;
                default:
                    Console.WriteLine("This type does not have discount.");
                    break;
            }
        }

        public void TypePremiumInfo()
        {
            switch (type)
            {
                case "Student":
                    Console.WriteLine(type + " can purchase premium membership with only 15 dollars.");
                    break;
                case "Employee":
                    Console.WriteLine(type + " can purchase premium membership with only 30 dollars.");
                    break;
                default:
                    Console.WriteLine("This type can buy membership with 60 dollars.");
                    break;
            }
        }

        public void TypeShippingFeeInfo()
        {
            switch (type)
            {
                case "Student":
                    Console.WriteLine(type + " has to pay 10 dollars for shipping.");
                    break;
                case "Employee":
                    Console.WriteLine(type + " has to pay 20 dollars for shipping.");
                    break;
                default:
                    Console.WriteLine("This type has to pay 30 dollars for shipping.");
                    break;
            }
        }


    }
}
