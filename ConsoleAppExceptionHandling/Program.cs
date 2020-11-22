using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a list of integers
        var numList = new List<int>() { 4, 16, 8 };
        
        try
        {
            // Ask the user for a number to divide each number in the list by...
            Console.WriteLine("\nEnter a non-zero number: ");
            string str1 = Console.ReadLine();
            int userNum = Convert.ToInt32(str1);
            // Write a loop that takes each integer in the list, divides it by the number the user entered
            int result = 0;
            for (int idx1 = 0; idx1 < numList.Count; idx1++)
            {
                result = numList[idx1] / userNum;
                // and displays the result to the screen.
                Console.WriteLine(numList[idx1] + " divided by " + userNum + " equals " + result);
            }
        }
        // Catch any other error message   
        catch (FormatException err1)
        {
            Console.WriteLine("You did not enter a valid number!\n");
            Console.WriteLine("Exception caught: " + err1);
        }
        // System.DivideByZeroException: 'Attempted to divide by zero.'
        catch (DivideByZeroException err2)
        {
            Console.WriteLine("You cannot divide by zero!\n");
            Console.WriteLine("Exception caught: " + err2);
        }
        catch (Exception err3)
        {
            Console.WriteLine(err3.Message);
        }
        Console.WriteLine("\nThe try-catch blocks have been successfully navigated!");
        Console.ReadLine();
    }
}
