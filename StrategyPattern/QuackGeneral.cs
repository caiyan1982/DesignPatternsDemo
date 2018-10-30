using System;

namespace StrategyPattern
{
    public class QuackGeneral : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}
