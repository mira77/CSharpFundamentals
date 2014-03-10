using System;

class AgeAfterTenYears
{
    static void Main()
    {
        DateTime birthDay = new DateTime();
        birthDay = DateTime.Parse(Console.ReadLine());
        System.TimeSpan myCurrentAge = new TimeSpan();
        myCurrentAge = (DateTime.Parse(Console.ReadLine()) - birthDay);
        int age = (int)(myCurrentAge.Days / 365.2 + 10);
        Console.WriteLine(age);
    }
}

