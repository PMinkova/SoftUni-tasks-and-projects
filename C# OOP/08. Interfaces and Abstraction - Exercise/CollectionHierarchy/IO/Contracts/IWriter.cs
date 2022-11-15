namespace CollectionHierarchy.IO.Contracts
{
    public interface IWriter
    {
        void Write(string text);

        void Write(int number);

        void WriteLine(string text);

        void WriteLine();

    }
}