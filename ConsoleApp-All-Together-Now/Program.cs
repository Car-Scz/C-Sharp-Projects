using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("CONSOLE APP ASSIGNMENT PARTS ONE, TWO, THREE");

        // Create a one dimensional array of strings
        string[] dim1 = new string[5];

        // Ask user to enter some text and iterate through each string in the array 
        // Uxe the comparison “<=” operator to determine whether to continue iterating the loop.
        for (int ind1 = 0; ind1 <= 4; ind1++)
        {
            Console.WriteLine("Please enter some text.");
            string inp1 = Console.ReadLine();

            // and adds the user's text input to the end of each string.
            // will update each array element by appending the user's text.
            dim1[ind1] = inp1;
        }

        // Then create a loop that prints off each string in the array on a separate line.
        Console.WriteLine("\n\nFinal Paragraph: ");

        // Add a comparison “<” operator that’s used to determine whether to continue iterating the loop.
        for (int ind1 = 0; ind1 < dim1.Length; ind1++)
        {
            Console.WriteLine(dim1[ind1]);
        }

        // Next section *****************************************************************
        Console.WriteLine("\n\nCONSOLE APP ASSIGNMENT PART FOUR");

        // A list of strings where each item in the list is unique.
        var values = new List<string>() { "acorn", "apple", "banana", "cantaloupe", "lettuce", "onion", "peach", "pepper", "squash", "tangerine" };
        Console.WriteLine("\nList element COUNT: " + values.Count);
        bool exists = false;

        // Ask the user to input text to search for in the list.
        // check if the text the user enterested isn't in the list.  If so, tell the user their input is not in the list.
        do
        {
            Console.WriteLine("\nWhat value are you looking for? ");
            string inp2 = Console.ReadLine();

            // Iterate through the list and then displays the index of the list tmatching list element.
            for (int ind2 = 0; ind2 < values.Count; ind2++)
            {
                if (inp2 == values[ind2])
                {
                    Console.WriteLine($"\n{ind2} = {values[ind2]}");
                    exists = true;
                }
            }
            if (exists == false)
            {
                Console.WriteLine("Element " + inp2 + " is NOT in the list!  Try again.");
            }
        }
        while (exists == false);

        // Next section *****************************************************************            
        Console.WriteLine("\n\nCONSOLE APP ASSIGNMENT PART FIVE");

        // list that contains at least two identical strings in the list
        var fruits = new List<string>() { "watermelon", "apples", "cherries", "cantaloupe", "apples" };
        Console.WriteLine("\nList element COUNT: " + fruits.Count);
        bool isDone = false;

        while (isDone == false)
        {
            // Ask the user to select text to search for in the list.
            Console.WriteLine("\nWhat text are you looking for? ");
            string inp3 = Console.ReadLine();

            // Create a loop that iterates through the list
            for (int indx1 = 0; indx1 < fruits.Count; indx1++)
            {
                // Iterate through the list and then displays the index of the list tmatching list element.
                if (inp3 == fruits[indx1])
                {
                    // displays the indices of the list that contain matching text on the screen
                    Console.WriteLine($"\n{indx1} = {fruits[indx1]}");
                    isDone = true;
                }
            }
            // check if the user put in text that isn't on the list.  If they did, tell the user their input is not on the list.
            if (isDone == false)
            {
                Console.WriteLine("Element " + inp3 + " is NOT in the list!  Try again.");
            }
        }

        // Next section *****************************************************************
        Console.WriteLine("\n\nCONSOLE APP ASSIGNMENT PART SIX\n");

        string[] strList = { "Red", "Orange", "Yellow", "Yellow", "Green", "Blue", "Indigo", "Violet", "Orange", "Green", "Blue" };
        var colorsList = new List<string>();
        var duplicates = new List<string>();

        int ind6 = 0;
        foreach (var elem in strList)
        {
            if (!colorsList.Contains(elem))
            {
                colorsList.Add(elem);
                Console.WriteLine("Element " + elem + " at index (" + ind6 + ")");
            }
            else
            {
                duplicates.Add(elem);
                Console.WriteLine("Element " + elem + " at index (" + ind6 + "): - DUPLICATE");
            }
            ind6++;
        }

        Console.ReadLine();
    }
}