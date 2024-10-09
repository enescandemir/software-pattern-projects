using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _221229064_BilalEnes_Candemir_commerceApp3._221229064_Facade_customerType
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
        public void TypeType();
        public void LogIn();
        public void LogOff();
        public void ShowBalance();

    }
}
