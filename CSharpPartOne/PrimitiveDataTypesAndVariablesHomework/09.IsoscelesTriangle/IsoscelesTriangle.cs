
using System;
using System.Text;

class IsoscelesTriangle
{
    public static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        char copyRight = (char)169;
        char whitespace = ' ';
        Console.Write("Enter height of triangle: ");
        int height = int.Parse(Console.ReadLine()); // Read height of triangle from the console.
        int col = height;
        int row = 0;
        for (int i = 0; i < height; i++) // Go trough rows
        {
            for (int j = 1; j <= col; j++) // Trough collumns
            {
                if (col-(row+row)==j || j==col) // Position of Copy Right symbols
                {
                    Console.Write(copyRight);
                }
                else if (i == height-1 && j%2!=0)   // Copyright symbols in last row of triangle
                {
                    Console.Write(copyRight);
                }
                else
                {
                    Console.Write(whitespace); // Whitespaces in triangle
                }
            }
            col++;
            row++;
            Console.WriteLine();
        }
    }
}