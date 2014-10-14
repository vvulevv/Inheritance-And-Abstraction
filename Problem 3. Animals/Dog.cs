using System;

public class Dog : Animal
{
    public Dog(string name, int age, Gender gender)
        : base (name, age, gender)
    {
           
    }

    public override string ToString()
    {
        return String.Format("Dog name: {0} | Dog  age: {1} | Dog gender: {2}", this.Name, this.Age, this.Gender);
    }

    public override void ProduceSound()
    {
        Console.WriteLine("Wooof, woooof!");
    }
}