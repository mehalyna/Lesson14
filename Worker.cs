using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14
{
    //ISP
    public interface IWorker
    {
        void Work();
        void Eat();
    }
    public class HumanWorker : IWorker
    {
        public void Work() { }
        public void Eat() { }
    }
    public class RobotWorker : IWorker
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            //working
        }
    }

    //Refactoring
    public interface IWorkerISP
    {
        void Work();
        
    }
    public interface IEaterISP
    { 
        void Eat();
    }

    public class HumanWorkerISP : IWorkerISP, IEaterISP
    {
        public void Eat()
        {
            //eating...
        }

        public void Work()
        {
            //working...
        }
    }
    public class RobotWorkerISP : IWorkerISP
    {
        public void Work()
        {
           //working ...
        }
    }
}
