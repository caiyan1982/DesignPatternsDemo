using System;
using System.Collections;

namespace CompositePattern
{
    public class Menu : MenuComponent
    {
        private ArrayList _menuComponents = new ArrayList();
        private string _name;
        private string _description;

        public Menu(string name, string description)
        {
            _name = name;
            _description = description;
        }

        public override void Add(MenuComponent menuComponent)
        {
            _menuComponents.Add(menuComponent);
        }

        public override void Remove(MenuComponent menuComponent)
        {
            _menuComponents.Remove(menuComponent);
        }

        public override MenuComponent GetChild(int i)
        {
            return (MenuComponent)_menuComponents[i];
        }

        public override string GetName()
        {
            return _name;
        }

        public override string GetDescription()
        {
            return _description;
        }

        public override void Print()
        {
            Console.Write("\n" + GetName());
            Console.WriteLine(", " + GetDescription());
            Console.WriteLine("---------------------");

            foreach (MenuComponent item in _menuComponents)
            {
                item.Print();
            }
        }

        public override IIterator CreateIterator()
        {
            return new CompositeIterator(new Iterator(_menuComponents));
        }
    }
}
