using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _221229064_BilalEnes_Candemir_atmProject
{
    public enum BanknoteType
    {
        BANKNOTE5 = 5, BANKNOTE10 = 10, BANKNOTE20 = 20, BANKNOTE50 = 50, BANKNOTE100 = 100, BANKNOTE200 = 200
    }
    class Banknote_221229064
    {
        private BanknoteType BanknoteType;
        private int number;

        public Banknote_221229064(BanknoteType banknoteType,int number)
        {
            this.BanknoteType = banknoteType;
            this.number = number;
        }

        public BanknoteType GetBanknoteType()
        {
            return this.BanknoteType;
        }
        public int GetNumber()
        {
               return this.number;
        }
        public void SetNumber(int number)
        {
            this.number = number;
        }
    }
}
