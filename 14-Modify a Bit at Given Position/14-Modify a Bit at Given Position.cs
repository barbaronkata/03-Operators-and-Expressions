//Problem 14. Modify a Bit at Given Position
//We are given an integer number n, a bit value v (v=0 or 1) and a position p.
//Write a sequence of operators (a few lines of C# code) that modifies n to hold the
// value v at the position p from the binary representation of n while preserving all other bits in n.

using System;

class Modify
{
    static void Main(string[] args)
    {
        Console.Write("n:");
        int n = int.Parse(Console.ReadLine());
        Console.Write("p:");
        int p = int.Parse(Console.ReadLine());
        Console.Write("v:");
        int v = int.Parse(Console.ReadLine());
        int c = 1;
        if (v == 1)
        {
            int mask = (c << p);
            int result = mask | n;
            Console.WriteLine("result: " + result);
        }
        if (v == 0)
        {
            int mask1 = ~(c << p);
            int result = mask1 & n;
            Console.WriteLine("result: " + result);
        }
    }
}