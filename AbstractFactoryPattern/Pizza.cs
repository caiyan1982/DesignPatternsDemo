using System;

namespace AbstractFactoryPattern
{
    public abstract class Pizza
    {
        protected string _name;
        protected IDough _dough;
        protected ISauce _sauce;
        protected ICheese _cheese;

        public abstract void Prepare();

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

        public virtual void SetName(string name)
        {
            _name = name;
        }

        public virtual string GetName()
        {
            return _name;
        }
    }
}
