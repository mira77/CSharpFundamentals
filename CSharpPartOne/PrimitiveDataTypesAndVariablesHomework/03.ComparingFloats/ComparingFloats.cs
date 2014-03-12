using System;

class ComparingFloats
{
    static void Main()
    {
        decimal eps = 0.000001M;
        decimal a = -4.999999M;
        decimal b = -4.999998M;
        decimal difference = a - b;
        if (Math.Abs(eps)>Math.Abs(difference))
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }

    }
}

