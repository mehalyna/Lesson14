using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14
{
    // LSP
    public class Bird
    {
        public virtual void Fly()
        {
            //Implementing of flying
        }
    }

    public class Penguin : Bird
    {
        public override void Fly()
        {
            throw new NotSupportedException("Penguins can't fly...");
        }
    }

    //Refactoring
    public abstract class BirdLSP
    {
    }
    public abstract class FlyingBird : BirdLSP 
    {
        public virtual void Fly()
        {
            //Implementing of flying
        }
    }
    public class Eagle : FlyingBird
    {
        public override void Fly()
        {
            //specific implementation for eagle
        }
    }
    public class PinguinLSP : BirdLSP
    { 
        //Implementing penguin's moving
    }
}
