namespace GenericIterator
{
    interface IIterator<T>
    {
        T First();
        T Next();
        T CurrentItem();
        bool IsDone();
    }
}
