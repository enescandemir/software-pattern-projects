using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _221229064_BilalEnes_Candemir_commerceApp3._221229064_Facade_customerType
{
    public interface ICompositeUser
    {
        public void AddUser(IType graphic);
        public void AddUsers(List<IType> graphics);
        public void RemoveUser(IType graphic);
        public List<IType> GetUsers();
        public void ListUser();
    }
}
