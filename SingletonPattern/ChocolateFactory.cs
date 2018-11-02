using System;

namespace SingletonPattern
{
    class ChocolateFactory
    {
        static void Main(string[] args)
        {
            ChocolateBoiler boiler1 = ChocolateBoiler.GetInstance();
            ChocolateBoiler boiler2 = ChocolateBoiler.GetInstance();

            boiler1.Fill();
            boiler2.Boil();
            boiler1.Drain();

            Console.Read();
        }
    }
}
