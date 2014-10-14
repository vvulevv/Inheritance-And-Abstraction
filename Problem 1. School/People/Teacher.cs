using System;

public class Teacher : NamableAndDetailable
{
    private Discipline[] disciplines;
    public Teacher(string name, string details = null, params Discipline[] disciplines)
        : base (name, details)
    {
        this.Disciplines = disciplines;
    }

    public Discipline[] Disciplines
    { 
        get
        {
            return this.disciplines;
        }
        set
        {
            this.disciplines = value;
        }
    }
}