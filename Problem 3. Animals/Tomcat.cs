using System;

public class Tomcat : Cat
{
    public Tomcat(string name, int age)
        : base (name, age, Gender.Male)
    {

    }

    public override string ToString()
    {
        return String.Format("Tomcat name: {0} | Tomcat  age: {1} | Tomcat gender: {2}", this.Name, this.Age, this.Gender);
    }

    public override void ProduceSound()
    {
        Console.WriteLine("Maaaaaaaaouuuuuuuuuuuuuuu!!");
    }
}