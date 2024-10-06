using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _221229064_BilalEnes_Candemir_commerceApp
{
    public abstract class WrongPointCalculator
    {
        public abstract void CalcutePoint(int membershipAge, int orderCount, User user);
        public abstract int CalculateOrderPoint(ItemData item, User user);
        public abstract void StudentBonusPoints(User user);
        public abstract void EmployeeBonusPoints(User user);

    }
    public class WrongPointCalculatorStudent : WrongPointCalculator
    {
        public override void CalcutePoint(int membershipAge, int orderCount, User user)
        {
            if (user.isPremium == false)
            {
                user.points = ((membershipAge * 50) + (orderCount * 30));
                Console.WriteLine(user.name + " named account has " + user.points + " points.");
            }
            else
            {
                user.points = ((membershipAge * 100) + (orderCount * 60));
                Console.WriteLine(user.name + " named account has " + user.points + " points.");
            }
        }
        public override int CalculateOrderPoint(ItemData item, User user)
        {
            Console.WriteLine("You can gain " + (item.cost * 4 + user.type.getShippingCost()) + " points from that purchase.");
            return (item.cost * 4 + user.type.getShippingCost());
        }
        public override void StudentBonusPoints(User user)
        {
            if (user.type.getType() == "Student")
            {
                Console.WriteLine(user.name + " named account gained 150 points for student account.");
                user.points += 150;
            }
            else
            {
                Console.WriteLine(user.name + " is not a student account. Bonus can't be claimed.");
            }

        }
        public override void EmployeeBonusPoints(User user)
        {
            throw new NotImplementedException();
        }
    }

    public class WrongPointCalculatorEmployee : WrongPointCalculator
    {
        public override void CalcutePoint(int membershipAge, int orderCount, User user)
        {
            if (user.isPremium == false)
            {
                user.points = ((membershipAge * 30) + (orderCount * 15));
                Console.WriteLine(user.name + " named account has " + user.points + " points.");
            }
            else
            {
                user.points = ((membershipAge * 60) + (orderCount * 30));
                Console.WriteLine(user.name + " named account has " + user.points + " points.");
            }
        }
        public override int CalculateOrderPoint(ItemData item, User user)
        {
            Console.WriteLine("You can gain " + (item.cost * 3 + user.type.getShippingCost()) + " points from that purchase.");
            return (item.cost * 3 + user.type.getShippingCost());
        }
        public override void EmployeeBonusPoints(User user)
        {
            if (user.type.getType() == "Employee")
            {
                Console.WriteLine(user.name + " named account gained 100 points for employee account.");
                user.points += 100;
            }
            else
            {
                Console.WriteLine(user.name + " is not an employee account. Bonus can't be claimed.");
            }
        }
        public override void StudentBonusPoints(User user)
        {
            throw new NotImplementedException();
        }
    }
    public class WrongPointCalculatorStandart : WrongPointCalculator
    {
        public override void CalcutePoint(int membershipAge, int orderCount, User user)
        {
            if (user.isPremium == false)
            {
                user.points = ((membershipAge * 30) + (orderCount * 15));
                Console.WriteLine(user.name + " named account has " + user.points + " points.");
            }
            else
            {
                user.points = ((membershipAge * 60) + (orderCount * 30));
                Console.WriteLine(user.name + " named account has " + user.points + " points.");
            }
        }
        public override int CalculateOrderPoint(ItemData item, User user)
        {
            Console.WriteLine("You can gain " + (item.cost * 3 + user.type.getShippingCost()) + " points from that purchase.");
            return (item.cost * 3 + user.type.getShippingCost());
        }
        public override void StudentBonusPoints(User user)
        {
            throw new NotImplementedException();
        }
        public override void EmployeeBonusPoints(User user)
        {
            throw new NotImplementedException();
        }
    }
}