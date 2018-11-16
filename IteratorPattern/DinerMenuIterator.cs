using System;

namespace IteratorPattern
{
    public class DinerMenuIterator : IIterator
    {
        private MenuItem[] _items;
        private int _position = 0;

        public DinerMenuIterator(MenuItem[] items)
        {
            _items = items;
        }

        public bool HasNext()
        {
            if (_position >= _items.Length || _items[_position] == null)
            {
                return false;
            }

            return true;
        }

        public Object Next()
        {
            MenuItem menuItem = _items[_position];
            _position++;
            return menuItem;
        }
    }
}
