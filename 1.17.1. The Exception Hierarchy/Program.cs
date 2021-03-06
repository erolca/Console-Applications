﻿using System;

class MainClass
{
    
    public static void Main()
    {

        /// <summary>
        /// 1.17.1.	The Exception Hierarchy
        /// In C#, exceptions are represented by classes.
        /// All exception classes must be derived from the built-in exception class System.Exception.
        /// SystemException class and ApplicationException class are derived from System.Exception.
        /// SystemException support exceptions generated by the C# runtime system (that is, the Common Language Runtime)
        /// ApplicationException support exceptions generated by application programs.
        /// SystemException and ApplicationException add nothing to Exception. 
        /// SystemException and ApplicationException define the tops of two different exception hierarchies.
        /// </summary>

        int Zero = 0;
        try
        {
            int j = 22 / Zero;
        }
        catch (DivideByZeroException e) // catch a specific exception
        {
            Console.WriteLine("DivideByZero {0}", e);
        }
        catch (Exception e)// catch any remaining exceptions
        {
            Console.WriteLine("Exception {0}", e);
        }


        



    }
}

//DivideByZero System.DivideByZeroException: Attempted to divide by zero.
//   at MainClass.Main()