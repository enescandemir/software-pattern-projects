using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _221229064_BilalEnes_Candemir_atmProject
{
    class Balance_221229064
    {
        private int balance;
        private int debt;

        private Banknote_221229064 banknote5 = new Banknote_221229064(BanknoteType.BANKNOTE5, 10);
        private Banknote_221229064 banknote10 = new Banknote_221229064(BanknoteType.BANKNOTE10, 10);
        private Banknote_221229064 banknote20 = new Banknote_221229064(BanknoteType.BANKNOTE20, 10);
        private Banknote_221229064 banknote50 = new Banknote_221229064(BanknoteType.BANKNOTE50, 10);
        private Banknote_221229064 banknote100 = new Banknote_221229064(BanknoteType.BANKNOTE100, 10);
        private Banknote_221229064 banknote200 = new Banknote_221229064(BanknoteType.BANKNOTE200, 10);

        private readonly int BANKNOTE_CAPACITY = 20;
        private readonly int DEBT_LIMIT = 1000;
        private readonly int DEPOSIT_LIMIT = 3000;
        private readonly int WITHDRAW_LIMIT = 3000;
        public Balance_221229064(int balance,int debt)
        {
            this.balance = balance;
            this.debt = debt;
        }
        
        private int BanknoteWithdraw(Banknote_221229064 banknote)
        {
            banknote.SetNumber(banknote.GetNumber() - 1);
            if (banknote.GetNumber() < 0)
            {
                banknote.SetNumber(banknote.GetNumber() + 1);
                Console.WriteLine("You cannot withdraw " + (int)banknote.GetBanknoteType() + " dollar banknote that much. You can only withdraw " + banknote.GetNumber() + " banknotes in ATM.");
                return banknote.GetNumber();
            }
            else
            {
                Console.WriteLine("There are " + banknote.GetNumber() + " " + (int)banknote.GetBanknoteType() + " dollar banknotes left in the ATM.");
                return banknote.GetNumber();
            }
        }

        private bool CanWithdraw(int amount)
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
                    if (this.balance > amount)
                    {
                        this.balance -= amount;
                        Console.WriteLine("Withdrawed " + amount + " dollars. You have " + this.balance + " balance left in your account.");
                        return true;
                    }
                    else if (this.balance < amount && this.balance + (DEBT_LIMIT - this.debt) >= amount)
                    {
                        this.debt += amount - balance;
                        this.balance = 0;
                        Console.WriteLine("Withdrawed " + amount + " dollars.\nYour Balance : 0 dollars.\nYour debt : " + this.debt + " dollars.");
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
        private int BanknoteDeposit(Banknote_221229064 banknote, int banknoteValue)
        {
            banknote.SetNumber(banknote.GetNumber() + 1);
            if (banknote.GetNumber() > BANKNOTE_CAPACITY)
            {;
                Console.WriteLine("Out of " + banknoteValue + " dollar banknotes. Cannot deposit that banknote right now.");
                return banknote.GetNumber();
            }
            else
            {
                
                Console.WriteLine("Deposited " + banknoteValue + " dollar banknotes to ATM. New banknote count : " + banknote.GetNumber() + ". Updating balance.");
                BalanceDeposit(banknoteValue);
                return banknote.GetNumber();
            }
        }
        private void BalanceDeposit(int balance)
        {
            if (this.debt != 0)
            {
                if (this.debt >= balance)
                {
                    this.debt -= balance;
                    Console.WriteLine("--Deposit Completed. Debt updated.\nNew debt : " + this.debt + " dollars.");
                }
                else
                {
                    this.balance += balance - this.debt;
                    this.debt = 0;
                    Console.WriteLine("--Deposit Completed. Debt and Balance updated.\nNew debt : " + this.debt + " dollars.\nNew balance is : " + balance + " dollars.");
                }
            }
            else
            {
                this.balance += balance;
                Console.WriteLine("--Deposit Completed.\nNew Balance : " + this.balance + " dollars.");
            }
        }
        public void Withdraw(int amount)
        {
            if (this.CanWithdraw(amount))
            {
                while (amount != 0)
                {
                    if (amount >= (int)banknote200.GetBanknoteType())
                    {
                        banknote200.SetNumber(BanknoteWithdraw(banknote200));
                        amount -= (int)banknote200.GetBanknoteType();
                    }
                    else if ((int)banknote100.GetBanknoteType() <= amount & amount < (int)banknote200.GetBanknoteType())
                    {
                        banknote100.SetNumber(BanknoteWithdraw(banknote100));
                        amount -= (int)banknote100.GetBanknoteType(); 
                    }
                    else if ((int)banknote50.GetBanknoteType() <= amount & amount < (int)banknote100.GetBanknoteType())
                    {
                        banknote50.SetNumber(BanknoteWithdraw(banknote50));
                        amount -= (int)banknote50.GetBanknoteType();
                    }
                    else if ((int)banknote20.GetBanknoteType() <= amount & amount < (int)banknote50.GetBanknoteType())
                    {
                        banknote20.SetNumber(BanknoteWithdraw(banknote20));
                        amount -= (int)banknote20.GetBanknoteType();
                    }
                    else if ((int)banknote10.GetBanknoteType() <= amount & amount < (int)banknote20.GetBanknoteType())
                    {
                        banknote10.SetNumber(BanknoteWithdraw(banknote10));
                        amount -= (int)banknote10.GetBanknoteType();
                    }
                    else if ((int)banknote5.GetBanknoteType() <= amount & amount < (int)banknote10.GetBanknoteType())
                    {
                        banknote5.SetNumber(BanknoteWithdraw(banknote5));
                        amount -= (int)banknote5.GetBanknoteType();
                    }
                }
            }
        }
        public void Deposit(int amount)
        {
            if(amount % 5 == 0)
            {
                if (amount <= DEPOSIT_LIMIT || amount <= 0)
                {
                    while (amount != 0)
                    {
                        if (amount >= (int)banknote200.GetBanknoteType() & BANKNOTE_CAPACITY * (int)banknote200.GetBanknoteType() >= amount & banknote200.GetNumber() != 20)
                        {
                            banknote200.SetNumber(BanknoteDeposit(banknote200, (int)banknote200.GetBanknoteType()));
                            amount -= (int)banknote200.GetBanknoteType();
                        }
                        else if (banknote200.GetNumber() == 20 && banknote100.GetNumber() != 20 || (int)banknote100.GetBanknoteType() <= amount & amount < (int)banknote200.GetBanknoteType())
                        {
                            banknote100.SetNumber(BanknoteDeposit(banknote100, (int)banknote100.GetBanknoteType()));
                            amount -= (int)banknote100.GetBanknoteType();
                        }
                        else if (banknote200.GetNumber() == 20 && banknote100.GetNumber() == 20 && banknote50.GetNumber() != 20 || (int)banknote50.GetBanknoteType() <= amount & amount < (int)banknote100.GetBanknoteType())
                        {
                            banknote50.SetNumber(BanknoteDeposit(banknote50, (int)banknote50.GetBanknoteType()));
                            amount -= (int)banknote50.GetBanknoteType();
                        }
                        else if (banknote200.GetNumber() == 20 && banknote100.GetNumber() == 20 && banknote50.GetNumber() == 20 && banknote20.GetNumber() != 20 || (int)banknote20.GetBanknoteType() <= amount & amount < (int)banknote50.GetBanknoteType())
                        {
                            banknote20.SetNumber(BanknoteDeposit(banknote20, (int)banknote20.GetBanknoteType()));
                            amount -= (int)banknote20.GetBanknoteType();
                        }
                        else if (banknote200.GetNumber() == 20 && banknote100.GetNumber() == 20 && banknote50.GetNumber() == 20 && banknote20.GetNumber() == 20 && banknote10.GetNumber() != 20 || (int)banknote10.GetBanknoteType() <= amount & amount < (int)banknote20.GetBanknoteType())
                        {
                            banknote10.SetNumber(BanknoteDeposit(banknote10, (int)banknote10.GetBanknoteType()));
                            amount -= (int)banknote10.GetBanknoteType();
                        }
                        else if (banknote200.GetNumber() == 20 && banknote100.GetNumber() == 20 && banknote50.GetNumber() == 20 && banknote20.GetNumber() == 20 && banknote10.GetNumber() == 20 && banknote5.GetNumber() != 20 || 5 <= amount & amount < (int)banknote10.GetBanknoteType())
                        {
                            banknote5.SetNumber(BanknoteDeposit(banknote5, (int)banknote5.GetBanknoteType()));
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
    }

    
}
