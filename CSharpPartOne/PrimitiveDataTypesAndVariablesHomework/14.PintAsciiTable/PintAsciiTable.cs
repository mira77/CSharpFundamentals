using System;
using System.Text;
class PintAsciiTable
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;
        for (int i = 0; i < 256; i++)
        {
            Console.WriteLine((char)i);
        }
    }
}

