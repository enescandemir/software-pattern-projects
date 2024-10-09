using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _221229064_BilalEnes_Candemir_commerceApp3._221229064_Facade_customerType
{
    public class UserManager : UserObject, ICompositeUser
    {
        protected List<IType> listOfUsers;
        public UserManager(int balance, string name) : base(balance, name)
        {
            listOfUsers = new List<IType>();
        }

        public void AddUser(IType type)
        {
            listOfUsers.Add(type);
        }

        public void AddUsers(List<IType> types)
        {
            listOfUsers.AddRange(types);
        }
        public List<IType> GetUsers()
        {
            return listOfUsers;
        }
        public void ListUser()
        {
            Console.WriteLine("\nType objects:");

            foreach (Object type in listOfUsers)
            {
                Console.WriteLine(((IType)type).ToString());
            }
        }
        public void RemoveUser(IType type)
        {
            listOfUsers.Remove(type);
        }

        public override void LogIn()
        {
            foreach (var item in listOfUsers)
            {
                item.LogIn();
            }
        }

        public override void LogOff()
        {
            foreach (var item in listOfUsers)
            {
                item.LogOff();
            }
        }

        public override void ShowBalance()
        {
            foreach (var item in listOfUsers)
            {
                item.ShowBalance();
            }
        }

        public override void TypeDiscount()
        {
            foreach (var item in listOfUsers)
            {
                item.TypeDiscount();
            }
        }
        public override void TypeType()
        {
            foreach (var item in listOfUsers)
            {
                item.TypeType();
            }
        }

        public override void TypeMembershipCost()
        {
            foreach (var item in listOfUsers)
            {
                item.TypeMembershipCost();
            }
        }

        public override void setBalance(int balance)
        {
            throw new NotImplementedException();
        }

        public override void setPremiumStatus(bool isPremium)
        {
             
        }

        public override string getName()
        {
            throw new NotImplementedException();
        }

        public override int getBalance()
        {
            throw new NotImplementedException();
        }

        public override int getDiscount()
        {
            throw new NotImplementedException();
        }

        public override int getPremiumCost()
        {
            throw new NotImplementedException();
        }

        public override bool IsPremium()
        {
            throw new NotImplementedException();
        }

        public override bool IsLoggedIn()
        {
            throw new NotImplementedException();
        }
    }
}
