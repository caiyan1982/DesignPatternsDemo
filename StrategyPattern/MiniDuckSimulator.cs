using System;

namespace StrategyPattern
{
    class MiniDuckSimulator
    {
        static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();

            mallard.Display();
            mallard.PerformQuack();
            mallard.PerformFly();

            Duck model = new ModelDuck();

            model.Display();
            model.PerformFly();
            model.SetFlyBehavior(new FlyRocketPowered());
            model.PerformFly();

            Console.Read();
        }
    }
}
