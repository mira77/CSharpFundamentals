using System;

class ExchangeVeriableValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine(a + " " + b);
        a = a ^ b; //Very fast exchange with bitwise operations, without using third veriable.
        b = a ^ b;
        a = a ^ b;
        Console.WriteLine(a + " " + b);
    }
}

