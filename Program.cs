// The default code
using System;

namespace calculator {

    class Program {

        static void Main(string[] args) {

            try {

                // Getting the necessary values from the user.
                Console.Write("Enter the first number: ");
                string first = Console.ReadLine();
                int First = int.Parse(first);

                Console.Write("Enter the second number: ");
                string second = Console.ReadLine();
                int Second = int.Parse(second);

                Console.Write("Enter the operation to be done on the numbers (+ - * /): ");
                string operation = Console.ReadLine();

                // Executing the correct operation by comparing user input.
                if (operation == "+") Console.WriteLine(First + Second);

                else if (operation == "-") {

                    Console.Write($"Enter 1 if you want to do {first} - {second} and enter 0 if you want to do {second} - {first}: ");

                    if (Console.ReadLine() == "1") Console.WriteLine(First - Second);

                    else if (Console.ReadLine() == "0") Console.WriteLine(Second - First);

                    else Console.WriteLine("Please enter a valid value.");

                } else if (operation == "*") Console.WriteLine(First * Second);

                else if (operation == "/") {

                    Console.Write($"Enter 1 if you want to do {first} / {second} and enter 0 if you want to do {second} / {first}: ");

                    if (Console.ReadLine() == "1") Console.WriteLine(First / Second);

                    else if (Console.ReadLine() == "0") Console.WriteLine(Second / First);

                    else Console.WriteLine("Pleaes enter a valid value.");

                } else Console.WriteLine("Please enter a valid value.");

            // If the user enters a string when a number is supposed to be entered, the program wont crash with an error and will print out this message instead.
            } catch (FormatException) {

                Console.WriteLine("Please enter a valid value.");

            } catch (DivideByZeroException) {

                Console.WriteLine("Devision by 0 is not defined");

            }  

            // Stopping the window from closing instantly using an input.
            Console.Write("\nPress enter to exit...");
            Console.ReadLine();    

        }

    }

}