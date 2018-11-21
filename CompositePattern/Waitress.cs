using System;

namespace CompositePattern
{
    public class Waitress
    {
        private MenuComponent _allMenus;

        public Waitress(MenuComponent allMenus)
        {
            _allMenus = allMenus;
        }

        public void PrintMenu()
        {
            _allMenus.Print();
        }

        public void PrintVegetarianMenu()
        {
            IIterator iterator = _allMenus.CreateIterator();
            Console.WriteLine("\nVEGETARIAN MENU\n----");
            while(iterator.HasNext())
            {
                MenuComponent menuComponent = (MenuComponent)iterator.Next();
                try
                {
                    if (menuComponent.IsVegetarian())
                    {
                        menuComponent.Print();
                    }
                }
                catch (NotSupportedException)
                {
                }
            }
        }
    }
}
