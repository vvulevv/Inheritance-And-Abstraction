using System;

public class Frog : Animal, ISound
{
    public Frog(string name, int age, Gender gender)
        : base (name, age, gender)
    {

    }

    public override string ToString()
    {
        return String.Format("Frog name: {0} | Frog  age: {1} | Frog gender: {2}", this.Name, this.Age, this.Gender);
    }

    public override void ProduceSound()
    {
        Console.WriteLine("Kwaaaaaaaaaak");
    }
}