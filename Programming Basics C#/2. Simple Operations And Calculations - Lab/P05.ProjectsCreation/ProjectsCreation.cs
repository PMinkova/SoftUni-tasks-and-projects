using System;

namespace P05.ProjectsCreation
{
    class ProjectsCreation
    {
        static void Main(string[] args)
        {
            string nameArchitect = Console.ReadLine();
            int numberOfProjects = int.Parse(Console.ReadLine());
            int workingHours = 3 * numberOfProjects;

            Console.WriteLine("The architect {0} will need {1} hours to complete {2} project/s.", nameArchitect, workingHours, numberOfProjects);
        }
    }
}
