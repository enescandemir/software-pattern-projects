using _221229064_BilalEnes_Candemir_commerceApp3._221229064_Facade_customerType;
using _221229064_BilalEnes_Candemir_commerceApp3._221229064_Facade_itemActivities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _221229064_BilalEnes_Candemir_commerceApp3._221229064_Command_buySellMethods
{
    public interface IAction
    {
        public void Execute();
        public void Undo();
        public void Redo();
    }

}
