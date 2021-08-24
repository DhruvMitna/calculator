using System;

namespace c_ {

    class Program {

        static void Main(string[] args) {

            Console.Write("Enter the first number: ");
            string first = Console.ReadLine();
            int First = int.Parse(first);

            Console.Write("Enter the second number: ");
            string second = Console.ReadLine();
            int Second = int.Parse(second);

            Console.Write("Enter the operation to be done on the numbers (+ - * /): ");
            string operation = Console.ReadLine();

            if (operation == "+") Console.WriteLine(First + Second);

            else if (operation == "-") {

                Console.Write("Enter 1 if you want to do " + first + " - " + second +" and enter 0 if you want to do " + second + " - " + first + ": ");

                string order = Console.ReadLine();

                if (order == "1") Console.WriteLine(First - Second);

                else if (order == "0") Console.WriteLine(Second - First);

                else Console.WriteLine("Please enter a valid value.");

            } else if (operation == "*") Console.WriteLine(First * Second);

            else if (operation == "/") {

                Console.Write("Enter 1 if you want to do " + first + " / " + second +" and enter 0 if you want to do " + second + " / " + first + ": ");
                string order = Console.ReadLine();

                if (order == "1") Console.WriteLine(First / Second);

                else if (order == "0") Console.WriteLine(Second / First);

                else Console.WriteLine("Pleaes enter a valid value.");               

            } else Console.WriteLine("Please enter a valid value.");

            Console.Write("\nPress enter to exit...");
            Console.ReadLine();

        }

    }

}