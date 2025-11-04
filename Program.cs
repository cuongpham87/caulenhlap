using System;

class Program
{
    public static void Main(string[] args)
    {
        // remove the stray semicolon after the for(...) header so the block is the loop body
        for (int i = 1; i <= 5; i++)
        {
            // print the loop index; use interpolation so the variable i is outside the string
            Console.WriteLine($"Lần lặp thứ {i}");
        }
    }
}