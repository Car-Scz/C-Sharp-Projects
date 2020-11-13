using System;

namespace TechAcademyDailyProject
{
    class Program
    {
        static void Main()
        {
            //  Heading of report
            Console.WriteLine("THE TECH ACADEMY");
            Console.WriteLine("\nStudent Daily Report");
            // Question 1
            Console.WriteLine("\nWhat is your name?");
            string yourName = Console.ReadLine();
            // Question 2
            Console.WriteLine("\nWhat course are you on?");
            string myCourse = Console.ReadLine();
            //  Question 3
            Console.WriteLine("\nWhat page number?");
           string  myCoursePage = Console.ReadLine();
            //  Question 4
            Console.WriteLine("\nDo you need help with anything?  Please answer \"true\" or \"false\" ");
            string needHelp = Console.ReadLine();
            //  Question 5
            Console.WriteLine("\nWere there any positive experiences you’d like to share? Please give specifics.");
            string positiveExperiences = Console.ReadLine();
            //  Question 6
            Console.WriteLine("\nIs there any other feedback you’d like to provide? Please be specific.");
            string otherFeedback = Console.ReadLine();
            //  Question 7
            Console.WriteLine("\nHow many hours did you study today?");
            string hoursStudied = Console.ReadLine();
            //  Final response
            Console.WriteLine("\n\nThank you for your answers. An Instructor will respond to this shortly. Have a great day!");
                 
        }
    }
}
