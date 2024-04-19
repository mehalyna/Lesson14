using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14
{
    //Demonstrate OCP

    //Violates OCP
    public class DiscountCalculator
    {
        public double CalculatorDiscount(Order order)
        {
            if (order.Customer == "VIP")
            {
                return order.TotalAmount * 0.1;
            }
            return 0;
        }
    }

    //Refactoring
    public interface IDiscountStrategy 
    {
        double CalculateDiscount(Order order);
    }
    public class VIPDiscountStrategy : IDiscountStrategy
    {
        public double CalculateDiscount(Order order) 
        {
            return order.TotalAmount * 0.1;
        }
    }

    public class DiscountCalculatorOCP
    {
        private readonly IDiscountStrategy _discountStrategy;
        public DiscountCalculatorOCP(IDiscountStrategy discountStrategy)
        { 
            _discountStrategy = discountStrategy;
        }
        public double CalculateDiscount(Order order)
        { 
            return _discountStrategy.CalculateDiscount(order);
        }
    }


}
