using System;

namespace _02_Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int period = int.Parse(Console.ReadLine());
            int doctors = 7;
            int treatedPatients = 0;
            int untreatedpatients = 0;
            int totalTreatedPatients = 0;
            int totalUntreatedPatients = 0;

            for (int i = 1; i <= period; i++)
            {
                int patientsCount = int.Parse(Console.ReadLine());

                if (i % 3 == 0 && totalUntreatedPatients > totalTreatedPatients)
                {
                    doctors++;
                }

                if (patientsCount > 7)
                {
                    treatedPatients = doctors;
                    untreatedpatients = patientsCount - treatedPatients;
                    
                }
                else
                {
                    treatedPatients = patientsCount;
                    untreatedpatients = 0;
                }
                totalTreatedPatients += treatedPatients;
                totalUntreatedPatients += untreatedpatients;

                treatedPatients = 0;
                untreatedpatients = 0;
            }

            Console.WriteLine($"Treated patients: {totalTreatedPatients}.");
            Console.WriteLine($"Untreated patients: {totalUntreatedPatients}.");
        }
    }
}
