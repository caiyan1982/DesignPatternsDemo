using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public abstract class Duck
    {
        public IFlyBehavior _flyBehavior;
        public IQuackBehavior _quackBehavior;

        public void SetFlyBehavior(IFlyBehavior fb)
        {
            _flyBehavior = fb;
        }

        public void SetQuackBehavior(IQuackBehavior qb)
        {
            _quackBehavior = qb;
        }

        public abstract void Display();

        public void PerformFly()
        {
            _flyBehavior.Fly();
        }

        public void PerformQuack()
        {
            _quackBehavior.Quack();
        }

        public void Swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }
    }
}
