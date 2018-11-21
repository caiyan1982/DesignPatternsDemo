namespace CompositePattern
{
    public interface IIterator
    {
        bool HasNext();

        object Next();
    }
}
