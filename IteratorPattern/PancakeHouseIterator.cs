using System.Collections;

namespace IteratorPattern
{
    public class PancakeHouseIterator : IIterator
    {
        private ArrayList _items;
        private int _position = 0;

        public PancakeHouseIterator(ArrayList items)
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
