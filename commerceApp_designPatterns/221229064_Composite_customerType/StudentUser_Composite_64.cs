using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _221229064_BilalEnes_Candemir_commerceApp3._221229064_Facade_customerType
{
    public class StudentUser : UserObject
    {
        public string Type = "Student";
        public int discount = 60;
        public int membershipCost = 15;
        public StudentUser(int balance, string name) : base(balance,name)
        {
        }
        public override void setBalance(int balance)
        {
            this.balance = balance;
        }
        public override void setPremiumStatus(bool isPremium)
        {
            this.isPremium = isPremium;
        }
        public override string getName()
        {
            return name;
        }
        public override int getBalance()
        {
            return balance;
        }
        public override int getDiscount()
        {
            return discount;
        }
        public override int getPremiumCost()
        {
            return membershipCost;
        }
        public override bool IsPremium()
        {
            return isPremium;
        }
        public override bool IsLoggedIn()
        {
            return isLoggedIn;
        }
        public override void TypeDiscount()
        {
            Console.WriteLine(Type + " type has " + discount + " dollars discount.");
        }
        public override void TypeMembershipCost()
        {
            Console.WriteLine(Type + " can purchase premium membership for only " + membershipCost + " dollars.");
        }
        public override void TypeType()
        {
            Console.WriteLine("User named " + name + "'s type is : " + Type + ".");
        }

        public override void LogIn()
        {
            if (isLoggedIn == false)
            {
                isLoggedIn = true;
                Console.WriteLine("User named " + name + " logged in.");
            }
            else
                Console.WriteLine("User named " + name + " has already logged in.");

        }
        public override void LogOff()
        {
            if (isLoggedIn == true)
            {
                isLoggedIn = false;
                Console.WriteLine("User named " + name + " logged off.");
            }
            else
                Console.WriteLine("User named " + name + " has already logged off.");
        }
        public override void ShowBalance()
        {
            Console.WriteLine("User named " + name + " has " + balance + " dollars.");
        }

    }
}
