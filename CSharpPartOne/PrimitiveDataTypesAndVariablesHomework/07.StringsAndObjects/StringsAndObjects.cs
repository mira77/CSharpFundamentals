using System;

class StringsAndObjects
{
    static void Main()
    {
        string a = "Hello";
        string b = "World";
        object ab = a + " " + b;
        string typeCast = ab.ToString();
        Console.WriteLine(typeCast);
    }
}

