﻿using System;


class MyClass
{
    public int Val = 20;
}

class MainClass
{
    static void MyMethod(ref MyClass myObject, ref int intValue)
    {
        myObject.Val = myObject.Val + 5;
        intValue = intValue + 5;
    }

    static void Main()
    {
        MyClass myObject = new MyClass();
        int intValue = 10;

        Console.WriteLine("Before -- myObject.Val: {0}, intValue: {1}", myObject.Val, intValue);

        MyMethod(ref myObject, ref intValue);

        Console.WriteLine("After  -- myObject.Val: {0}, intValue: {1}", myObject.Val, intValue);
    }
}