using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a one-dimensional Array of strings. Ask the user to select an index of the Array 
        // and then display the string at that index on the screen.
        Console.WriteLine("Working with a string array...\n");
        string[] strArray = { "turkey", "cranberries", "potatoes", "pumpkin", "apples", "ham" };
        bool validIndex = false;

        while (validIndex == false)
        {
            Console.WriteLine("Pick a number between 0 and 5:");
            string inputNum = Console.ReadLine();
            // Add in a message that displays when the user selects an index that doesn’t exist.
            if (inputNum == "0" || inputNum == "1" || inputNum == "2" || inputNum == "3" ||
                inputNum == "4" || inputNum == "5")
            {
                int index = Convert.ToInt32(inputNum);
                Console.WriteLine("The element at index " + index + " is: " + strArray[index]);
                validIndex = true;
            }
            else
            {
                Console.WriteLine("The number MUST be between 0 and 5.  Try again.");
            }
        }

        // Create a one-dimensional Array of integers. Ask the user to select an index of the Array 
        // and then display the integer at that index on the screen.
        int[] numArray = { 1, 4, 9, 16, 25, 36, 49 };
        validIndex = false;
        Console.WriteLine("\n\nWorking with an integer array...\n");

        while (validIndex == false)
        {
            Console.WriteLine("\nPick a number between 0 and 6:");
            string inputNum = Console.ReadLine();

            // Add in a message that displays when the user selects an index that doesn’t exist.
            if (inputNum == "0" || inputNum == "1" || inputNum == "2" || inputNum == "3" ||
                inputNum == "4" || inputNum == "5" || inputNum == "6")
            {
                int index = Convert.ToInt32(inputNum);
                Console.WriteLine("The element at index " + index + " is: " + numArray[index]);
                validIndex = true;
            }
            else
            {
                Console.WriteLine("The number MUST be between 0 and 6.  Try again.");
            }
        }

        // Create a list of strings. Ask the user to select an index of the list 
        // and then display the content at that index on the screen.
        Console.WriteLine("\n\nWorking with List of strings...\n");

        // Collection of string  
        string[] animals = { "Cat", "Camel", "Elephant", "Llama", "Parrot" };
        // Create a List and add a collection
        List<string> animalsList = new List<string>();
        animalsList.AddRange(animals);

        Console.WriteLine("Animal List");
        foreach (string a in animalsList)
            Console.WriteLine(a);
        
        // get input from user
        Console.WriteLine("\nPick a number between 0 and 4:");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(animalsList[x]);

        Console.ReadLine();
    }
}