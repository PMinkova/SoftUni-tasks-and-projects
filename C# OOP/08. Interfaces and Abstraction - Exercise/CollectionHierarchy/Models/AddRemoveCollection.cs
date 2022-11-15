namespace CollectionHierarchy.Models
{
    using Contracts;

    public class AddRemoveCollection : CustomCollection, IAddable, IRemovable
    {
        public int Add(string item)
        {
            this.Collection.Insert(0, item);
            return 0;
        }

        public string Remove()
        {
            var lastIndex = this.Collection.Count - 1;
            var removedElement = this.Collection[lastIndex];
            this.Collection.RemoveAt(lastIndex);

            return removedElement;
        }
    }
}
