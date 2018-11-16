namespace IteratorPattern
{
    public interface IIterator
    {
        bool HasNext();

        object Next();
    }
}
