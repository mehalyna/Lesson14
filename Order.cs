using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14
{
    //Demonstrates SRP
    public class Order
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Customer { get; set; }
        public double TotalAmount { get; set; }
    }

    //Violating SRP
    public class OrderHandler
    {
        public void ProcessOrder(Order order)
        {
            //Process order
            //...
            LogOrder(order);
        }

        public void LogOrder(Order order)
        {
            // Log order processing details
            //...
        }
    }

    //Refactoring
    public class OrderProcessor
    {
        public void ProcessOrder(Order order)
        {
            //Process order
            //...
                
        }
    }

    public class OrderLogger
    {
        public void LogOrder(Order order)
        {
            //Process order
            //...
                
        }
    }

}
