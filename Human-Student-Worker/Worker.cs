using System;

public class Worker : Human
{
    private const int weekWorkDays = 5;
    private decimal weekSalary;
    private decimal workHoursPerDay;

    public Worker (string firstName, string lastName, decimal weekSalary, decimal workHoursPerDay)
        : base (firstName, lastName)
    {
        this.WeekSalary = weekSalary;
        this.WorkHoursPerDay = workHoursPerDay;
    }
    
    public decimal WeekSalary
    {
        get
        {
            return this.weekSalary;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Week salary cannot be negative number.");
            }
            this.weekSalary = value;
        }
    }
    public decimal WorkHoursPerDay
    {
        get
        {
            return this.workHoursPerDay;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Work hours per day cannot be negative number.");
            }
            this.workHoursPerDay = value;
        }
    }

    public decimal MoneyPerHour()
    {
        return Math.Round(((this.WorkHoursPerDay * weekWorkDays) / this.WeekSalary), 2);
    }

    public override string ToString()
    {
        return String.Format("Worker: {0} {1} works {2} hours per day for week salary: {3} leva.", this.FirstName, this.LastName, this.WorkHoursPerDay, this.WeekSalary);
    }
}