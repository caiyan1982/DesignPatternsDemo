using System;

namespace StrategyPattern
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            _flyBehavior = new FlyNoWay();
            _quackBehavior = new QuackGeneral();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a model duck.");
        }
    }
}
