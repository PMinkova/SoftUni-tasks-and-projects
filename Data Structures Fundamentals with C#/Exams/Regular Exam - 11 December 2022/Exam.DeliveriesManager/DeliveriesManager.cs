namespace Exam.DeliveriesManager
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DeliveriesManager : IDeliveriesManager
    {
        private HashSet<Deliverer> deliverers;
        private HashSet<Package> packages;

        public DeliveriesManager()
        {
            this.deliverers = new HashSet<Deliverer>();
            this.packages = new HashSet<Package>();
        }

        public void AddDeliverer(Deliverer deliverer)
        {
            this.deliverers.Add(deliverer);
        }

        public void AddPackage(Package package)
        {
            this.packages.Add(package);
        }

        public void AssignPackage(Deliverer deliverer, Package package)
        {
            if (!this.deliverers.Contains(deliverer) || !this.packages.Contains(package))
            {
                throw new ArgumentException();
            }

            deliverer.Packages.Add(package);
            package.Deliverer = deliverer;
        }

        public bool Contains(Deliverer deliverer)
        {
            return this.deliverers.Contains(deliverer);
        }

        public bool Contains(Package package)
        {
            return this.packages.Contains(package);
        }

        public IEnumerable<Deliverer> GetDeliverers()
        {
            return this.deliverers;
        }

        public IEnumerable<Deliverer> GetDeliverersOrderedByCountOfPackagesThenByName()
        {
            return this.deliverers
                .OrderByDescending(x => x.Packages.Count)
                .ThenBy(x => x.Name);
        }

        public IEnumerable<Package> GetPackages()
        {
            return this.packages;
        }

        public IEnumerable<Package> GetPackagesOrderedByWeightThenByReceiver()
        {
            return this.packages.OrderByDescending(x => x.Weight).ThenBy(x => x.Receiver);
        }

        public IEnumerable<Package> GetUnassignedPackages()
        {
            return this.packages.Where(x => x.Deliverer == null);
        }
    }
}
