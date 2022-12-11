namespace Exam.DeliveriesManager
{
    using System.Collections.Generic;

    public class Deliverer
    {
        public Deliverer(string id, string name) 
            :this()
        {
            Id = id;
            Name = name;
        }

        private Deliverer()
        {
            this.Packages = new HashSet<Package>();
        }

        public string Id { get; set; }

        public string Name { get; set; }

        public HashSet<Package> Packages { get; set; }
    }
}
