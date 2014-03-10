using System;

class CurrentDateTime
{
    static void Main()
    {
        DateTime currentDay = new DateTime();
        currentDay = DateTime.Now;
        Console.WriteLine("{0:dd.MM.yyyy hh:mm}",currentDay);
    }
}

