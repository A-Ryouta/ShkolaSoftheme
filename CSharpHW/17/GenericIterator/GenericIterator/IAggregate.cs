namespace GenericIterator
{
    interface IAggregate<T>
    {
        IIterator<T> CreateIterator();
    }
}
