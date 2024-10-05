using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _221229064_BilalEnes_Candemir_atmProject
{
    class getterSetter_221229064
    {
        public bool atmOnline { get; set; } = false;
        public bool isLoggedIn { get; set; } = false;
        public int userBalance { get; set; } = 1000;
        public int userDebt { get; set; } = 300 ;
        public int banknote5 { get; set; } = 10;
        public int banknote10 { get; set; } = 10;
        public int banknote20 { get; set; } = 10;
        public int banknote50 { get; set; } = 10;
        public int banknote100 { get; set; } = 10;
        public int banknote200 { get; set; } = 10;

        public readonly string bankName = "Candemir Bankacılık";
        public readonly int BANKNOTE_CAPACITY = 20;
        public readonly int ACCOUNT_NUMBER = 7562475;
        public readonly int DEBT_LIMIT = 1000;
        public readonly int WITHDRAW_LIMIT = 3000;
    }
}
