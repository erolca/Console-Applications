﻿using System;

class Example
{
    public static void Main()
    {
        byte b;
        int i;

        i = 255;
        b = (byte)i;
        Console.WriteLine("b after assigning 255: " + b +
                          " -- no data lost.");
    }

}