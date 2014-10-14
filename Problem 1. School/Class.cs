using System;
using System.Collections;
using System.Collections.Generic;

public class Class
{
    private string uniqueTextIdentifier;
    private IList<Teacher> teachers = new List<Teacher>();

    public Class(string uniqueTextIdentifier, IList<Teacher> teachers)
    {
        this.UniqueTextIdentifier = uniqueTextIdentifier;
        this.teachers = teachers;
    }

    public void AddTeacher(Teacher teacher)
    {
        this.teachers.Add(teacher);
    }

    public string UniqueTextIdentifier 
    { 
        get
        {
            return this.uniqueTextIdentifier;
        }
        set
        {
            if (String.IsNullOrEmpty(uniqueTextIdentifier))
            {
                throw new ArgumentNullException("Unique Text Identifier cannot be empty!");
            }
            this.uniqueTextIdentifier = value;
        }
    }
    
}