using System;
using System.Collections;

namespace CompositePattern
{
    public class CompositeIterator : IIterator
    {
        private Stack _stack = new Stack();
        private string _id;

        public CompositeIterator(IIterator iterator)
        {
            _stack.Push(iterator);
            _id = Guid.NewGuid().ToString();
        }

        public bool HasNext()
        {
            if (_stack.Count == 0)
            {
                return false;
            }
            else
            {
                IIterator iterator = (IIterator)_stack.Peek();
                if (!iterator.HasNext())
                {
                    _stack.Pop();
                    return HasNext();
                }
                else
                {
                    return true;
                }
            }
        }

        public object Next()
        {
            if (HasNext())
            {
                IIterator iterator = (IIterator)_stack.Peek();
                MenuComponent component = (MenuComponent)iterator.Next();
                if (component is Menu && !(iterator is CompositeIterator))
                {
                    _stack.Push(component.CreateIterator());
                }
                return component;
            }
            else
            {
                return null;
            }
        }
    }
}
