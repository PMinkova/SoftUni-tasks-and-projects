namespace CollectionHierarchy.Models
{
    using Contracts;

    public class MyList : CustomCollection, IAddable, IRemovable, IUsable
    {
        public int Add(string item)
        {
            this.Collection.Insert(0, item);
            return 0;
        }

        public string Remove()
        {
            var firstElement = this.Collection[0];
            this.Collection.RemoveAt(0);
            return firstElement;
        }

        public int Used()
        {
            return this.Collection.Count;
        }
    }
}
