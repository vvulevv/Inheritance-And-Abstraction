using System;
using System.Collections.Generic;
using System.Linq;

class CreatingAndSortingHumans
{
    static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student("Kristina", "Vuleva", "03090309"),
            new Student("Rayana", "Angelova", "ajfaiwk"),
            new Student("Charlie", "Vulev", "20008"),
            new Student("Cristiano", "Ronaldo", "realmadrid"),
            new Student("Marcelo", "Vieira", "m12gji12"),
            new Student("Gareth", "Bale", "siafjoa"),
            new Student("David", "Beckham", "2314fsa"),
            new Student("David", "Jones", "isajfof"),
            new Student("Shyla", "Styles", "faifashi"),
            new Student("Asa", "Akira", "asianbeaty")
        };

        List<Worker> workers = new List<Worker>
        {
            new Worker("Jose", "Mourinho", 300000m, 5),
            new Worker("Carlo", "Ancelotti", 250000m, 8),
            new Worker("Georgi", "Ivanov", 50000m, 4),
            new Worker("Valyu", "Valev", 30000m, 7),
            new Worker("Vladimir", "Gadzhev", 350865, 7),
            new Worker("Stanimir", "Stoilov", 152000m, 12),
            new Worker("Barak", "Obama", 76000m, 6),
            new Worker("Boiko", "Borisov", 456000m, 6),
            new Worker("Jesse", "Jane", 315000m, 5),
            new Worker("Mitio", "Pishtova", 10000m, 1)
        };

        foreach(var student in students)
        {
            Console.WriteLine(student);
        }
        Console.WriteLine();
        foreach(var worker in workers)
        {
            Console.WriteLine(String.Format("{0} \nmoney per hour for {2} --> {1}", worker,
                worker.MoneyPerHour(), worker.FirstName));
        }
        Console.WriteLine("\nSorting students by fac. number in ascending order.\n");

        var sortedStudentstByFacNumber = students.OrderBy(x => x.FacultyNumber);
        foreach (var st in sortedStudentstByFacNumber)
        {
            Console.WriteLine("{0} | {1} {2}", st.FacultyNumber, st.FirstName, st.LastName);
        }

        Console.WriteLine("\nSorted workers by paymen per hour\n");

        var sortedWorkersByPaymentPerHour = workers.OrderByDescending(x => x.MoneyPerHour());
        foreach (var wor in sortedWorkersByPaymentPerHour)
        {
            Console.WriteLine("{0} | {1} {2}", wor.MoneyPerHour(), wor.FirstName, wor.LastName);
        }

        Console.WriteLine("\nSorted humans by first and last name.\n");

        var humans = new List<Human>();
        humans.AddRange(students);
        humans.AddRange(workers);

        var sortedHumansByName = humans.OrderBy(x => x.FirstName)
            .ThenBy(x => x.LastName);
        foreach (var human in sortedHumansByName)
        {
            Console.WriteLine("{0} {1} | {2}", human.FirstName, human.LastName, human.GetType());
        }
    }
}
