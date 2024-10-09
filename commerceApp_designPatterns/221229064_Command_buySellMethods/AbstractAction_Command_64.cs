using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _221229064_BilalEnes_Candemir_commerceApp3._221229064_Command_buySellMethods
{
    public abstract class AbstractAction : IAction
    {
        public abstract void Execute();
        public abstract void Undo();
        public abstract void Redo();

    }
}
