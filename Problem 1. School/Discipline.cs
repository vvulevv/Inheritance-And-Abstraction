using System;

public class Discipline : NamableAndDetailable
{
    private int numberOfLectures;
    private Student[] students;

    public Discipline(string name, int numberOfLectures, string details = null, params Student[] students)
        : base(name, details)
    {
        this.NumberOfLectures = numberOfLectures;
        this.Students = students;
    }

    public int NumberOfLectures
    {
        get
        {
            return this.numberOfLectures;
        }
        set
        {
            if (numberOfLectures < 0)
            {
                throw new ArgumentOutOfRangeException("Lectures cannot be negative number.");
            }
            this.numberOfLectures = value;
        }
    }
    public Student[] Students 
    { 
        get
        {
            return this.students;
        }
        set
        {
            this.students = value;
        }
    }
}