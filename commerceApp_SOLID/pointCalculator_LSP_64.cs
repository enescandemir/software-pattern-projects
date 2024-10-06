using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _221229064_BilalEnes_Candemir_commerceApp
{
    public abstract class PointCalculator
    {
        public abstract void CalcutePoint(int membershipAge, int orderCount, User user);
        public abstract int CalculateOrderPoint(ItemData item,User user);
    }
    public class PointCalculatorStudent : PointCalculator
    {
        public override void CalcutePoint(int membershipAge, int orderCount, User user)
        {
            if(user.isPremium == false)
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
        public override int CalculateOrderPoint(ItemData item,User user)
        {
            Console.WriteLine("You can gain " + (item.cost * 4 + user.type.getShippingCost()) + " points from that purchase.");
            return (item.cost * 4 + user.type.getShippingCost());
        }
        public void StudentBonusPoints(User user)
        {
            if(user.type.getType() == "Student")
            {
                Console.WriteLine(user.name + " named account gained 150 points for student account.");
                user.points += 150;
            }
            else
            {
                Console.WriteLine(user.name + " is not a student account. Bonus can't be claimed.");
            }
            
        }
    }
    public class PointCalculatorEmployee : PointCalculator
    {
        public override void CalcutePoint(int membershipAge, int orderCount, User user)
        {
            if(user.isPremium == false)
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
        public void EmployeeBonusPoints(User user)
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
    }
    public class PointCalculatorStandart : PointCalculator
    {
        public override void CalcutePoint(int membershipAge, int orderCount, User user)
        {
            if(user.isPremium == false)
            {
                user.points = ((membershipAge * 15) + (orderCount * 10));
                Console.WriteLine(user.name + " named account has " + user.points + " points.");
            }
            else
            {
                user.points = ((membershipAge * 30) + (orderCount * 20));
                Console.WriteLine(user.name + " named account has " + user.points + " points.");
            }
            
        }
        public override int CalculateOrderPoint(ItemData item, User user)
        {
            Console.WriteLine("You can gain " + (item.cost * 2 + user.type.getShippingCost()) + " points from that purchase.");
            return (item.cost * 2 + user.type.getShippingCost());
        }
    }





}
