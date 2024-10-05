using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _221229064_BilalEnes_Candemir_atmProject
{
    class Encapsulated_221229064
    {
        private bool atmOnline = false;
        private bool isLoggedIn = false;
        public Balance_221229064 userBalance = new Balance_221229064(1000,300);
        private readonly string BANK_NAME = "Candemir Bankacılık";
        private readonly int ACCOUNT_NUMBER = 7562475;
        public void OpenATM()
        {
            if (!atmOnline)
                atmOnline = true;
            else
                Console.WriteLine("ATM is already open.");
        }

        public void CloseATM()
        {
            if (atmOnline)
                atmOnline = false;
            else
                Console.WriteLine("ATM is already closed.");
        }

        public void LogIn()
        {
            if (!isLoggedIn)
                isLoggedIn = true;
            else
                Console.WriteLine("You already logged in.");
        }

        public void LogOff()
        {
            if (isLoggedIn)
                isLoggedIn = false;
            else
                Console.WriteLine("You already logged off.");
        }

        public void Deposit(int amount)
        {
            if(atmOnline == true && isLoggedIn == true)
            {
                userBalance.Deposit(amount);
            }
            else
            {
                Console.WriteLine("ATM is not opened or you didn't log in yet. Please try again.");
            }
            
        }

        public void Withdraw(int amount)
        {
            if (atmOnline == true && isLoggedIn == true)
            {
                userBalance.Withdraw(amount);
            }
            else
            {
                Console.WriteLine("ATM is not opened or you didn't log in yet. Please try again.");
            }
        }
    }
}
