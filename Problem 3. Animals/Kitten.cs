using System;

public class Kitten : Cat
{
    public Kitten(string name, int age)
        : base(name, age, Gender.Female)
    {

    }

    public override string ToString()
    {
        return String.Format("Kitten name: {0} | Kitten  age: {1} | Kitten gender: {2}", this.Name, this.Age, this.Gender);
    }

    public override void ProduceSound()
    {
        Console.WriteLine("miauu..");
    }
}