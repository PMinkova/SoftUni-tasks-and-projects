namespace CollectionHierarchy.Core
{
    using System.Linq;

    using CollectionHierarchy.IO.Contracts;
    using CollectionHierarchy.Models;
    using Contracts;

    public class Engine : IEngine
    {
        private readonly IReader reader;
        private readonly IWriter writer;

        private readonly AddCollection addCollection;
        private readonly AddRemoveCollection addRemoveCollection;
        private readonly MyList myList;

        public Engine()
        {
            this.addCollection = new AddCollection();
            this.addRemoveCollection = new AddRemoveCollection();
            this.myList = new MyList();
        }

        public Engine(IReader reader, IWriter writer)
            : this()
        {
            this.reader = reader;
            this.writer = writer;
        }
        public void Run()
        {
            PrintAllAddOperations();
            PrintAllRemoveOperations();
        }

        private void PrintAllRemoveOperations()
        {
            var removeOperationsCount = int.Parse(reader.ReadLine());
            var currentRemovedElement = string.Empty;

            for (int i = 0; i < removeOperationsCount; i++)
            {
                currentRemovedElement = this.addRemoveCollection.Remove();
                writer.Write(currentRemovedElement + " ");
            }

            writer.WriteLine();

            for (int i = 0; i < removeOperationsCount; i++)
            {
                currentRemovedElement = this.myList.Remove();
                writer.Write(currentRemovedElement + " ");
            }

            writer.WriteLine();
        }

        private void PrintAllAddOperations()
        {
            var inputArguments = reader.ReadLine()
                .Split(' ')
                .ToArray();
            var currentIndex = 0;

            foreach (var item in inputArguments)
            {
                currentIndex = this.addCollection.Add(item);
                writer.Write(currentIndex + " ");
            }

            writer.WriteLine();

            foreach (var item in inputArguments)
            {
                currentIndex = this.addRemoveCollection.Add(item);
                writer.Write(currentIndex + " ");
            }

            writer.WriteLine();

            foreach (var item in inputArguments)
            {
                currentIndex = this.myList.Add(item);
                writer.Write(currentIndex + " ");
            }

            writer.WriteLine();
        }
    }
}