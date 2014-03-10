using System;

class SubsetSums
{
    static void Main()
    {
        long s = long.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        long sum = 0;
        int count = 0;
        int br = 0;
        long[] numbers = new long[n];
        string various = "";
        for (int i = 0; i < n; i++)
        {
            various = various + "1";
            numbers[i] = long.Parse(Console.ReadLine());
        }
        for (int i = 1; i <= Convert.ToInt32(various, 2); i++)
        {
            for (int j = 0; j <= n; j++)
            {
                int mask = 1;
                int bit = ((mask << j) & i) >> j;
                if (bit == 1)
                {
                    br++;
                    sum += numbers[j];
                }
            }
            if (br != 0)
            {
                if (sum == s)
                {
                    count++;
                }
            }
            sum = 0;
            br = 0;
        }
        Console.WriteLine(count);
    }
}