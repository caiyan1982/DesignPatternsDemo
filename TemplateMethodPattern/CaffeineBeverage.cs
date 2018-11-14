using System;

namespace TemplateMethodPattern
{
    public abstract class CaffeineBeverage
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            if (CustomerWantsCondiments())
            {
                AddCondiments();
            }
        }

        public abstract void Brew();

        public abstract void AddCondiments();

        public void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        public void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }

        protected virtual bool CustomerWantsCondiments()
        {
            return true;
        }
    }
}
