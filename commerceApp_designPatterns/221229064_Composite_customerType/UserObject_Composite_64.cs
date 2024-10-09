using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _221229064_BilalEnes_Candemir_commerceApp3._221229064_Facade_customerType
{
    public abstract class UserObject : IType
    {
        public string name;
        public int balance;
        public bool isLoggedIn;
        public bool isPremium;
        public UserObject(int balance, string name)
        {
            this.name = name;
            this.balance = balance;
            this.isLoggedIn = false;
            this.isPremium = false;
        }

        public abstract void setBalance(int balance);
        public abstract void setPremiumStatus(bool isPremium);
        public abstract string getName();
        public abstract int getBalance();
        public abstract int getDiscount();
        public abstract int getPremiumCost();
        public abstract bool IsPremium();
        public abstract bool IsLoggedIn();
        public abstract void TypeDiscount();
        public abstract void TypeMembershipCost();
        public abstract void TypeType();
        public abstract void LogIn();
        public abstract void LogOff();
        public abstract void ShowBalance();
    }
}
