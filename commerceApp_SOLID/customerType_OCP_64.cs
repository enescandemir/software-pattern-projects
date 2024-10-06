using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _221229064_BilalEnes_Candemir_commerceApp
{
    public interface IType
    {
        public void TypeDiscount();
        public void TypeMembershipCost();
        public void TypeShippingCost();
        public int getDiscount();
        public int getPremiumCost();
        public int getShippingCost();
        public String getType();
    }

    public class Student : IType
    {
        public String Type = "Student";
        public int discount = 60;
        public int membershipCost = 15;
        public int shippingCost = 10;
        public String getType()
        {
            return Type;
        }
        public void TypeDiscount()
        {
            Console.WriteLine(Type + " has " + discount + " dollars discount.");
        }
        public int getDiscount()
        {
            return discount;
        }
        public void TypeMembershipCost()
        {
            Console.WriteLine(Type + " can purchase premium membership for only " + membershipCost + " dollars.");
        }
        public int getPremiumCost()
        {
            return membershipCost;
        }
        public void TypeShippingCost()
        {
            Console.WriteLine(Type + " has to pay " + shippingCost + " dollars for shipping.");
        }
        public int getShippingCost()
        {
            return shippingCost;
        }

    }

    public class Employee : IType
    {
        public String Type = "Employee";
        public int discount = 30;
        public int membershipCost = 30;
        public int shippingCost = 20;
        public String getType()
        {
            return Type;
        }
        public void TypeDiscount()
        {
            Console.WriteLine(Type + " has " + discount + " dollars discount.");
        }
        public int getDiscount()
        {
            return discount;
        }
        public void TypeMembershipCost()
        {
            Console.WriteLine(Type + " can purchase premium membership for only " + membershipCost + " dollars.");
        }
        public int getPremiumCost()
        {
            return membershipCost;
        }
        public void TypeShippingCost()
        {
            Console.WriteLine(Type + " has to pay " + shippingCost + " dollars for shipping.");
        }
        public int getShippingCost()
        {
            return shippingCost;
        }
    }

    public class Standart : IType
    {
        public String Type = "Standart";
        public int discount = 0;
        public int membershipCost = 60;
        public int shippingCost = 30;
        public String getType()
        {
            return Type;
        }
        public void TypeDiscount()
        {
            Console.WriteLine(Type + " type accounts does not have discount.");
        }
        public int getDiscount()
        {
            return discount;
        }
        public void TypeMembershipCost()
        {
            Console.WriteLine(Type + " type accounts can purchase premium membership for only " + membershipCost + " dollars.");
        }
        public int getPremiumCost()
        {
            return membershipCost;
        }
        public void TypeShippingCost()
        {
            Console.WriteLine(Type + " type accounts has to pay " + shippingCost + " dollars for shipping.");
        }
        public int getShippingCost()
        {
            return shippingCost;
        }
    }

    public class User
    {
        public IType type;
        public String name;
        public int balance;
        public bool isLoggedIn;
        public bool isPremium;
        public int points;
        public User(IType type,int balance, bool isPremium,String name)
        {
            this.name = name;
            this.type = type;
            this.balance = balance;
            isLoggedIn = false;
            this.isPremium = isPremium;
        }
        public void TypeDiscount()
        {
            type.TypeDiscount();
        }
        public void TypeMembershipCost()
        {
            type.TypeMembershipCost();
        }
        public void TypeShippingCost()
        {
            type.TypeShippingCost();
        }
        public void LogIn()
        {
            if (isLoggedIn == false)
            {
                isLoggedIn = true;
                Console.WriteLine("Logged In.");
            }
            else
                Console.WriteLine("You already logged in.");

        }
        public void LogOff()
        {
            if (isLoggedIn == true)
            {
                isLoggedIn = false;
                Console.WriteLine("Logged Off");
            }
            else
                Console.WriteLine("You already logged off.");
        }
        public void ShowBalance()
        {
            Console.WriteLine("Jacob's balance is : " + balance + ".");
        }
        public void ShowPoints()
        {
            Console.WriteLine("Jacob's point is : " + points + ".");
        }
    }
 

}
