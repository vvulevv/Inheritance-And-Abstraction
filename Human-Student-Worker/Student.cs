using System;
using System.Text.RegularExpressions;

public class Student : Human
{
    private string facultyNumber;

    public Student(string firstName, string lastName, string facultyNumber)
        : base (firstName, lastName)
    {
        this.FacultyNumber = facultyNumber;
    }

    public string FacultyNumber
    {
        get
        {
            return this.facultyNumber;
        }
        set
        {
            if (value.Length < 5 || value.Length > 10 || value.Length < 0)
            {
                throw new ArgumentOutOfRangeException("Faculty number length should be [5..10] digits or letters");
            }
            try
            {
                Regex.IsMatch(value, @"^[a-zA-Z0-9]+$");
            }
            catch (FormatException exception)
            {
                Console.WriteLine("You've entered invalid value." + exception.Message);
            }
            this.facultyNumber = value;
        }
    }

    public override string ToString()
    {
        return String.Format("Student: {0} {1} has faculty number: {2}", this, FirstName, this.LastName, this.FacultyNumber);
    }
}