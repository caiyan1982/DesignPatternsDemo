using System.Collections;

namespace CompositePattern
{
    public class Iterator : IIterator
    {
        private ArrayList _items;
        private int _position = 0;

        public Iterator(ArrayList items)
        {
            _items = items;
        }

        public bool HasNext()
        {
            if (_position >= _items.Count)
            {
                return false;
            }

            return true;
        }

        public object Next()
        {
            object menuItem = _items[_position];
            _position++;
            
            return menuItem;
        }
    }
}
