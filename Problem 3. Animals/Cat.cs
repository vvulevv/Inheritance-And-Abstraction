using System;

public class Cat : Animal, ISound
{
    public Cat(string name, int age, Gender gender)
        : base(name, age, gender)
    {

    }

    public override string ToString()
    {
        return String.Format("Cat name: {0} | Cat  age: {1} | Cat gender: {2}", this.Name, this.Age, this.Gender);
    }

    public override void ProduceSound()
    {
        Console.WriteLine("Miaaaaaaaaaauuuuuuuuuu");
    }
}