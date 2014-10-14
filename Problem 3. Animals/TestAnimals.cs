using System;
using System.Collections.Generic;
using System.Linq;

class TestAnimals
{
    static void Main()
    {
        //Printing our beloved pets on the console:
        Dog charlie = new Dog("Charlie", 6, Gender.Male);
        Console.WriteLine(charlie);
        Cat jessica = new Cat("Jessica", 10, Gender.Female);
        Console.WriteLine(jessica);
        Frog chocho = new Frog("Chocho", 4, Gender.Male);
        Console.WriteLine(chocho);
        Kitten kitty = new Kitten("Kitty", 1);
        Console.WriteLine(kitty);
        Tomcat tommy = new Tomcat("Tommy", 7);
        Console.WriteLine(tommy);

        //Producing sounds:
        Console.WriteLine("\nAnimal concert:");
        kitty.ProduceSound();
        charlie.ProduceSound();
        jessica.ProduceSound();
        chocho.ProduceSound();
        tommy.ProduceSound();
        Console.WriteLine();

        //Creating arrays of different kind of animals and calculating their average age:
        Dog[] dogs =
        {
            new Dog("Roshko", 5, Gender.Male),
            new Dog("Rexy", 4, Gender.Male)
        };

        Kitten[] kittens = 
        {
            new Kitten("Shaki", 3),
            new Kitten("Marka", 14)
        };
        Tomcat[] tomcats =
        {
            new Tomcat("Gufi", 10),
            new Tomcat("Krumcho", 5)
        };
        Frog[] frogs =
        {
            new Frog("Kiki", 4, Gender.Female),
            new Frog("Shishka", 8, Gender.Female)
        };

        List<Animal> animals = new List<Animal>();
        animals.Add(charlie);
        animals.Add(jessica);
        animals.Add(chocho);
        animals.Add(tommy);
        animals.Add(kitty);
        animals.AddRange(dogs);
        animals.AddRange(kittens);
        animals.AddRange(tomcats);
        animals.AddRange(frogs);

        var groupedAnimals = from animal in animals
                             group animal by (animal is Cat) ? typeof(Cat) : animal.GetType() into g
                             select new { AnimalType = g.Key, AverageAge = g.ToList().Average(an => an.Age) };
        foreach (var groupedAnimal in groupedAnimals)
        {
            Console.WriteLine("Group: {0} --> Average age: {1:N2} years", groupedAnimal.AnimalType, groupedAnimal.AverageAge);
        }
    }
}