using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _221229064_BilalEnes_Candemir_commerceApp2
{
    public interface IType
    {
        public void setBalance(int balance);
        public void setPremiumStatus(bool isPremium);
        public string getName();
        public int getBalance();
        public int getDiscount();
        public int getPremiumCost();
        public bool IsPremium();
        public bool IsLoggedIn();
        public void TypeDiscount();
        public void TypeMembershipCost();
        public void LogIn();
        public void LogOff();
        public void ShowBalance();

    }

    public class StudentUser : IType
    {
        public string name;
        public int balance;
        public bool isLoggedIn;
        public bool isPremium;
        public int points;
        public string Type = "Student";
        public int discount = 60;
        public int membershipCost = 15;
        public StudentUser(int balance,string name)
        {
            this.name = name;
            this.balance = balance;
            this.isLoggedIn = false;
            this.isPremium = false;
        }
        public void setBalance(int balance)
        {
            this.balance = balance;
        }
        public void setPremiumStatus(bool isPremium)
        {
            this.isPremium = isPremium;
        }
        public string getName()
        {
            return name;
        }
        public int getBalance()
        {
            return balance;
        }
        public int getDiscount()
        {
            return discount;
        }
        public int getPremiumCost()
        {
            return membershipCost;
        }
        public bool IsPremium()
        {
            return isPremium;
        }
        public bool IsLoggedIn()
        {
            return isLoggedIn;
        }
        public void TypeDiscount()
        {
            Console.WriteLine(Type + " has " + discount + " dollars discount.");
        }
        public void TypeMembershipCost()
        {
            Console.WriteLine(Type + " can purchase premium membership for only " + membershipCost + " dollars.");
        }

        public void LogIn()
        {
            if (isLoggedIn == false)
            {
                isLoggedIn = true;
                Console.WriteLine("Logged In.");
            }
            else
                Console.WriteLine("User named " + name + " has already logged in.");

        }
        public void LogOff()
        {
            if (isLoggedIn == true)
            {
                isLoggedIn = false;
                Console.WriteLine("Logged Off");
            }
            else
                Console.WriteLine("User named " + name + " has already logged off.");
        }
        public void ShowBalance()
        {
            Console.WriteLine("User named " + name + " has " + balance + " dollars.");
        }

    }

    public class EmployeeUser : IType
    {
        public string name;
        public int balance;
        public bool isLoggedIn;
        public bool isPremium;
        public int points;
        public string Type = "Employee";
        public int discount = 30;
        public int membershipCost = 30;
        public EmployeeUser(int balance,string name)
        {
            this.name = name;
            this.balance = balance ;
            this.isLoggedIn = false;
            this.isPremium = false;
        }
        public void setBalance(int balance)
        {
            this.balance = balance;
        }
        public void setPremiumStatus(bool isPremium)
        {
            this.isPremium = isPremium;
        }
        public string getName()
        {
            return name;
        }
        public int getDiscount()
        {
            return discount;
        }
        public int getBalance()
        {
            return balance;
        }
        public int getPremiumCost()
        {
            return membershipCost;
        }
        public bool IsPremium()
        {
            return isPremium;
        }
        public bool IsLoggedIn()
        {
            return isLoggedIn;
        }
        public void TypeDiscount()
        {
            Console.WriteLine(Type + " has " + discount + " dollars discount.");
        }
        public void TypeMembershipCost()
        {
            Console.WriteLine(Type + " can purchase premium membership for only " + membershipCost + " dollars.");
        }
        public void LogIn()
        {
            if (isLoggedIn == false)
            {
                isLoggedIn = true;
                Console.WriteLine("Logged In.");
            }
            else
                Console.WriteLine("User named " + name + " has already logged in.");

        }
        public void LogOff()
        {
            if (isLoggedIn == true)
            {
                isLoggedIn = false;
                Console.WriteLine("Logged Off");
            }
            else
                Console.WriteLine("User named " + name + " has already logged off.");
        }
        public void ShowBalance()
        {
            Console.WriteLine("User named " + name + " has " + balance + " dollars.");
        }
    }

    public class StandartUser : IType
    {
        public string name;
        public int balance;
        public bool isLoggedIn;
        public bool isPremium;
        public int points;
        public string Type = "Standart";
        public int discount = 0;
        public int membershipCost = 60;
        public StandartUser(int balance, string name)
        {
            this.balance = balance;
            this.isLoggedIn = false;
            this.isPremium = false;
            this.name = name;
        }
        public void setBalance(int balance)
        {
            this.balance = balance;
        }
        public void setPremiumStatus(bool isPremium)
        {
            this.isPremium = isPremium;
        }
        public string getName()
        {
            return name;
        }
        public int getDiscount()
        {
            return discount;
        }
        public int getPremiumCost()
        {
            return membershipCost;
        }
        public int getBalance()
        {
            return balance;
        }
        public bool IsPremium()
        {
            return isPremium;
        }
        public bool IsLoggedIn()
        {
            return isLoggedIn;
        }
        public void TypeDiscount()
        {
            Console.WriteLine(Type + " type accounts does not have discount.");
        }
        public void TypeMembershipCost()
        {
            Console.WriteLine(Type + " type accounts can purchase premium membership for only " + membershipCost + " dollars.");
        }

        public void LogIn()
        {
            if (isLoggedIn == false)
            {
                isLoggedIn = true;
                Console.WriteLine("Logged In.");
            }
            else
                Console.WriteLine("User named " + name + " has already logged in.");

        }
        public void LogOff()
        {
            if (isLoggedIn == true)
            {
                isLoggedIn = false;
                Console.WriteLine("Logged Off");
            }
            else
                Console.WriteLine("User named " + name + " has already logged off.");
        }
        public void ShowBalance()
        {
            Console.WriteLine("User named " + name + " has " + balance + " dollars.");
        }

    }
    public enum CustomerType
    {
        Student = 1,
        Employee = 2,
        Standart = 3
    }

    public interface ICustomerFactory
    {
        IType CreateCustomer(CustomerType type,int balance, string name);
    }

    public class CustomerFactory : ICustomerFactory
    {
        public IType CreateCustomer(CustomerType type,int balance,string name)
        {
            IType customer = null;
            switch(type)
            {
                case CustomerType.Student:
                    customer = new StudentUser(balance,name);
                    break;
                case CustomerType.Employee:
                    customer = new EmployeeUser(balance, name);
                    break;
                case CustomerType.Standart:
                    customer = new StandartUser(balance, name);
                    break;
            }
            return customer;
        }
    }
}
