namespace CollectionHierarchy.Models
{
    public class AddCollection : CustomCollection
    {
        public int Add(string item)
        {
            this.Collection.Add(item);
            var lastIndex = this.Collection.Count - 1;
            return lastIndex;
        }
    }
}
