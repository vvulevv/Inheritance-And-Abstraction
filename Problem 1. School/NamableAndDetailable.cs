using System;

public class NamableAndDetailable : INamable, IDetailable
{
    private string name;
    private string details;
    public NamableAndDetailable(string name, string details = null)
    {
        this.Name = name;
        this.Details = details;
    }

    public string Name 
    {
        get
        {
            return this.name;
        }
        set
        { 
            if (String.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("Name cannot be null or empty.");
            }
            this.name = value;
        }
    }
    public string Details
    { 
        get
        {
            return this.details;
        }
        set
        {
            this.details = value;
        }
    }
}