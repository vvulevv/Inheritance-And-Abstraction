using System;

public class Student : NamableAndDetailable
{
    private int uniqueClassNumber;

    public Student(string name, int uniqueClassNumber, string details = null)
        : base(name, details)
    {
        this.UniqueClassNumber = uniqueClassNumber;
    }

    public int UniqueClassNumber 
    { 
        get
        {
            return this.uniqueClassNumber;
        }
        set
        {
            if (uniqueClassNumber <= 0)
            {
                throw new ArgumentOutOfRangeException("Classs number should be positive integer in range [1..students count]");
            }
            this.uniqueClassNumber = value;
        }
    }
}
