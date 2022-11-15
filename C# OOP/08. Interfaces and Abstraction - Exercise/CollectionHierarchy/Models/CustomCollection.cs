namespace CollectionHierarchy.Models
{
    using System.Collections.Generic;

    public abstract class CustomCollection
    {

        private IList<string> collection;

        protected CustomCollection()
        {
            this.collection = new List<string>();
        }

        public IList<string> Collection
        {
            get
            {
                return this.collection;
            }
        }
    }
}
