using System;
using System.Collections;

namespace FactoryMethodPattern
{
    public abstract class Pizza
    {
        protected string _name;
        protected string _dough;
        protected string _sauce;
        protected ArrayList _toppings = new ArrayList();

        public void Prepare()
        {
            Console.WriteLine("Preparing " + _name);
            Console.WriteLine("Tossing " + _dough);
            Console.WriteLine("Adding " + _sauce);
            Console.WriteLine("Adding toppings:");
            for (int i = 0; i < _toppings.Count; i++)
            {
                Console.WriteLine("    " + _toppings[i]);
            }
        }

        public virtual void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public virtual void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }

        public virtual string GetName()
        {
            return _name;
        }
    }
}
