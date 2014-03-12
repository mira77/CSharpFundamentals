using System;

class NullValues
{
    static void Main()
    {
        int? a = null;
        double? b = null;
        a = a + 2;
        b += 3;
        Console.WriteLine(a +"result"+ b);
    }
}

