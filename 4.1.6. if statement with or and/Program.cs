﻿using System;

class MainClass
{
    static void Main(string[] args)
    {
        int a = 5, b = 5, c = 10;

        if (a == b)
            Console.WriteLine(a);

        if ((a > c) || (a == b))
            Console.WriteLine(b);

        if ((a >= c) && (b <= c))
            Console.WriteLine(c);
    }
}