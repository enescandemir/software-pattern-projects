using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _221229064_BilalEnes_Candemir_atmProject
{
    class Primitive_221229064
    {
        public bool atmOnline = false;
        public bool isLoggedIn = false;
        public int userBalance = 1000;
        public int userDebt = 300;
        public int banknote5 = 10;
        public int banknote10 = 10;
        public int banknote20 = 10;
        public int banknote50 = 10;
        public int banknote100 = 10;
        public int banknote200 = 10;

        public readonly string BANK_NAME = "Candemir Bankacılık";
        public readonly int BANKNOTE_CAPACITY = 20;
        public readonly int ACCOUNT_NUMBER = 7562475;
        public readonly int DEBT_LIMIT = 1000;
        public readonly int WITHDRAW_LIMIT = 3000;
        public readonly int DEPOSIT_LIMIT = 3000;

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
        public int BanknoteWithdraw(int banknote,int banknoteValue)
        {
            banknote -= 1;
            if (banknote < 0)
            {
                banknote += 1;
                Console.WriteLine("You cannot withdraw " + banknoteValue + " dollar banknote that much. You can only withdraw " + banknote + " banknotes in ATM.");
                return banknote;
            }
            else
            {
                Console.WriteLine("There are " + (banknote) + " " + banknoteValue + " dollar banknotes left in the ATM.");
                return banknote;
            }
        }
        public bool CanWithdraw(int amount)
        {
            if (amount > WITHDRAW_LIMIT)
            {
                Console.WriteLine("You exceed withdraw limit. Withdraw failed.");
                return false;
            }
            else
            {
                if (amount % 5 == 0 & amount > 0)
                {
                    if (this.userBalance > amount)
                    {
                        this.userBalance -= amount;
                        Console.WriteLine("Withdrawed " + amount + " dollars. You have " + this.userBalance + " balance left in your account.");
                        return true;
                    }
                    else if (this.userBalance < amount && this.userBalance + (DEBT_LIMIT - this.userDebt) >= amount)
                    {
                        this.userDebt += amount - userBalance;
                        this.userBalance = 0;
                        Console.WriteLine("Withdrawed " + amount + " dollars.\nYour Balance : 0 dollars.\nYour debt : " + userDebt + " dollars.");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("You dont have enough money.");
                        return false;
                    }
                }
                else
                {
                    Console.WriteLine("Withdraw failed. Wrong amount of money tried to withdraw");
                    return false;
                }
                    
            }  
        }
        public void Withdraw(int amount)
        {
            if(atmOnline == true && isLoggedIn == true)
            {
                if (this.CanWithdraw(amount))
                {
                    while (amount != 0)
                    {
                        if (amount >= 200)
                        {
                            banknote200 = BanknoteWithdraw(banknote200, 200);
                            amount -= 200;
                        }
                        else if (100 <= amount & amount < 200)
                        {
                            banknote100 = BanknoteWithdraw(banknote100, 100);
                            amount -= 100;
                        }
                        else if (50 <= amount & amount < 100)
                        {
                            banknote50 = BanknoteWithdraw(banknote50, 50);
                            amount -= 50;
                        }
                        else if (20 <= amount & amount < 50)
                        {
                            banknote20 = BanknoteWithdraw(banknote20, 20);
                            amount -= 20;
                        }
                        else if (10 <= amount & amount < 20)
                        {
                            banknote10 = BanknoteWithdraw(banknote10, 10);
                            amount -= 10;
                        }
                        else if (5 <= amount & amount < 10)
                        {
                            banknote5 = BanknoteWithdraw(banknote5, 5);
                            amount -= 5;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("ATM is not opened or you didn't log in yet. Please try again.");
            }
            
        }
        public int BanknoteDeposit(int banknote,int banknoteValue)
        {
            banknote += 1;
            if (banknote > BANKNOTE_CAPACITY)
            {
                banknote -= 1;
                Console.WriteLine("You cannot deposit " + banknoteValue + " dollar banknote right now. Banknote does not left in ATM.");
                return banknote;
            }
            else
            {
                Console.WriteLine("Deposited " + banknoteValue + " dollar banknotes to ATM. New banknote count : " + banknote + ". Updating balance.");
                BalanceDeposit(banknoteValue);
                return banknote;
            }

        }

        public void BalanceDeposit(int balance)
        {
            if (this.userDebt != 0)
            {
                if(this.userDebt >= balance)
                {
                    this.userDebt -= balance;
                    Console.WriteLine("--Deposit Completed. Debt updated.\nNew debt : " + this.userDebt + " dollars.");
                }
                else
                {
                    this.userBalance += balance - this.userDebt;
                    this.userDebt = 0;
                    Console.WriteLine("--Deposit Completed. Debt and Balance updated.\nNew debt : " + this.userDebt + " dollars.\nNew balance is : " + this.userBalance + " dollars.");
                }
            }
            else
            {
                this.userBalance += balance;
                Console.WriteLine("--Deposit Completed.\nNew Balance : " + this.userBalance + " dollars.");
            }
        }
        
        public void Deposit(int amount)
        {
            if(atmOnline == true && isLoggedIn == true)
            {
                if (amount % 5 == 0)
                {
                    if (amount <= DEPOSIT_LIMIT || amount <= 0)
                    {
                        while (amount != 0)
                        {
                            if (amount >= 200 && banknote200 != 20)
                            {
                                banknote200 = BanknoteDeposit(banknote200, 200);
                                amount -= 200;
                            }
                            else if (banknote200 == 20 && banknote100 != 20 || 100 <= amount & amount < 200)
                            {
                                banknote100 = BanknoteDeposit(banknote100, 100);
                                amount -= 100;
                            }
                            else if (banknote200 == 20 && banknote100 == 20 && banknote50 != 20 || 50 <= amount & amount < 100)
                            {
                                banknote50 = BanknoteDeposit(banknote50, 50);
                                amount -= 50;
                            }
                            else if (banknote200 == 20 && banknote100 == 20 && banknote50 == 20 && banknote20 != 20 || 20 <= amount & amount < 50)
                            {
                                banknote20 = BanknoteDeposit(banknote20, 20);
                                amount -= 20;
                            }
                            else if (banknote200 == 20 && banknote100 == 20 && banknote50 == 20 && banknote20 == 20 && banknote10 != 20 || 10 <= amount & amount < 20)
                            {
                                banknote10 = BanknoteDeposit(banknote10, 10);
                                amount -= 10;
                            }
                            else if (banknote200 == 20 && banknote100 == 20 && banknote50 == 20 && banknote20 == 20 && banknote10 == 20 & banknote5 != 20 || 5 <= amount & amount < 10)
                            {
                                banknote5 = BanknoteDeposit(banknote5, 5);
                                amount -= 5;
                            }
                            else
                            {
                                Console.WriteLine("ATM banknote stock full. Cannot deposite anymore.");
                                amount = 0;
                            }
                        }
                    }
                    else
                    {
                        if (amount <= 0)
                            Console.WriteLine("You entered wrong value to deposit. Deposit failed.");
                        else
                            Console.WriteLine("You crossed deposit limit. Deposit failed.");
                    }
                }
                else { Console.WriteLine("You cannot enter numbers that are not divisible by 5."); }
            }
            else { Console.WriteLine("ATM is not opened or you didn't log in yet. Please try again.");  }
        }

        public int GetBalance()
        {
            return userBalance;
        }

        public int GetDebt()
        {
            return userDebt;
        }
    }
}


    


