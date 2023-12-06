using System;

/*
===============================================================================
PROJECT 12: BETTER AREA CALCULATOR
===============================================================================
Objective:
- Learn how to refactor code into more manageable chunks using methods, improving readability and reusability of the code.

Main Tasks:
1. Copy and paste your program from the previous lesson into this one.
2. Write methods for each of the main functions of the program. E.g. ShowMenu, CalculateRectangle, CalculateTriangle, etc.
3. Move the corresponding code into each method.
4. Call the methods from the Main method.

Questions:
1. What is the purpose of splitting the code into smaller chunks (methods)?
2. Why is it important to give a warning message to the user in the else statement?

Extension Tasks:
1. Add a trapezium option to the program. It should also be a separate method.

Example:
- Below is an example of the program's output:

    Choose an Option:
    1. Area of Circle
    2. Area of Rectangle
    3. Area of Triangle

    2

    Enter Width: 3
    Enter Height: 4

    The area of the rectangle is 12

    "Press any key to exit...

Additional Resources:
- Methods: https://www.w3schools.com/cs/cs_methods.php
===============================================================================
*/

namespace ProgrammingExercisesIST
{
    class Project_12_BetterAreaCalculator
    {
        static void Main(string[] args)
        {
            // Your code goes below here
            Console.WriteLine("Chose an option");
            Console.WriteLine("1. area of a circle");
            Console.WriteLine("2. Area of  a Rectangle");
            Console.WriteLine("3. Area of a Triangle");

            String Choice = Console.ReadLine();


            if (Choice == "1")
            {
                Console.Write("What is the radius? ");
                double radius = Convert.ToDouble(Console.ReadLine());
                double area = Math.PI * radius;
                Console.WriteLine($"the area of a circle is {area}");
            }

            else if (Choice == "2")
            {
                Console.Write("width of rectangle");
                double w = Convert.ToDouble(Console.ReadLine());
                Console.Write("height of rectangle");
                double h = Convert.ToDouble(Console.ReadLine());
                double area = (w * h);
                Console.WriteLine($"the area of the rectangle is{area}");
            }

            else if (Choice == "3")
            {
                Console.Write("width of trigangle");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("height of triangle");
                double b = Convert.ToDouble(Console.ReadLine());
               
                double area = (a * b);
                Console.WriteLine($"the area of the triangle is {area / 2}");
            }



            Console.ReadKey();
            



        }
    }
}
/*
===============================================================================
FEEDBACK AREA: Paste your AI feedback here before submission:
===============================================================================



===============================================================================
*/