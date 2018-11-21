using System;

namespace CompositePattern
{
    public class MenuItem : MenuComponent
    {
        private string _name;
        private string _description;
        private bool _vegetarian;
        private double _price;

        public MenuItem(string name, string description, bool vegetarian, double price)
        {
            _name = name;
            _description = description;
            _vegetarian = vegetarian;
            _price = price;
        }

        public override string GetName()
        {
            return _name;
        }

        public override string GetDescription()
        {
            return _description;
        }

        public override double GetPrice()
        {
            return _price;
        }

        public override bool IsVegetarian()
        {
            return _vegetarian;
        }

        public override void Print()
        {
            Console.Write("  " + GetName());
            if (IsVegetarian())
            {
                Console.Write("(v)");
            }
            Console.WriteLine(", " + GetPrice());
            Console.WriteLine("     -- " + GetDescription());
        }

        public override IIterator CreateIterator()
        {
            return new NullIterator();
        }
    }
}
