using System;
using System.Collections.Generic;

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
    }
}