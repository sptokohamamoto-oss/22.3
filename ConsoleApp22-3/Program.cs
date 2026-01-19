using System;
using System.Collections.Generic;

public abstract class Employee
{
    public abstract void Work(int hours);
}

public class FullTimeEmployee : Employee
{
    public override void Work(int hours)
    {
        Console.WriteLine($"Full-time employee works {hours} hours.");
    }
}

public class InternEmployee : Employee
{
    private const int MaxHours = 4;

    public override void Work(int hours)
    {
        int actualHours = Math.Min(hours, MaxHours);
        Console.WriteLine($"Intern works {actualHours} hours (requested: {hours}).");
    }
}

