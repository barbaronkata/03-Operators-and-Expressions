﻿﻿
//Problem 13. Check a Bit at Given Position

//Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) 
//in given integer number n, has value of 1.

using System;

class ChekBit
{
    static void Main()
    {
        Console.Write("n :");
        int n = int.Parse(Console.ReadLine());
        Console.Write("p :");
        int p = int.Parse(Console.ReadLine());
        int c = 1;
        int mask = c << p;
        int reslt = mask & n;
        bool isTrue = (reslt != 0);
        Console.WriteLine(isTrue);
    }
}
