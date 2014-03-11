using System;

class AgeAfterTenYears
{
    static void Main()
    {
        Console.Write("Enter your birhday: ");
        DateTime birthDay = new DateTime();
        birthDay = DateTime.Parse(Console.ReadLine());
        System.TimeSpan myCurrentAge = new TimeSpan();
        myCurrentAge = (DateTime.Now - birthDay);
        int age = (int)(myCurrentAge.Days / 365.2 + 10);
        Console.WriteLine("Your age after ten years will be: "+ age);
    }
}

