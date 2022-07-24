using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToBase
{
    class Program
    {
        static void conversion(string value)
        {
            Console.WriteLine("{0} to decimal is {1}.",
                value, Convert.ToInt32(value, 16));
            Console.WriteLine("{0} to binary is {1}.\n", value,
                Convert.ToString(Convert.ToInt32(value, 16), 2));
        }
        static void Main(string[] args)
        {
            bool endApp = false;
            // Display title as the C# console calculator app.
            Console.WriteLine("Number to Base in C#\r");
            Console.WriteLine("------------------------\n");

            while (!endApp)
            {
                int s, d;

                Console.Write("Enter N: ");
                string n = Console.ReadLine();

                do
                {
                    Console.Write("Enter S (S == 2, 8, 10 or 16): ");
                    s = Int32.Parse(Console.ReadLine());
                } while (s != 2 && s != 8 && s != 10 && s != 16);

                do
                {
                    Console.Write("Enter D (D == 2, 8, 10 or 16): ");
                    d = Int32.Parse(Console.ReadLine());
                } while (d != 2 && d != 8 && d != 10 && d != 16);


                try
                { 
                    n = Convert.ToString(Convert.ToInt32(n, s), d);
                }
                catch { 
                    Console.WriteLine("Oh no! Something went wrong...");
                }

                Console.WriteLine("Result is {0}.", n);

                Console.WriteLine("------------------------\n");

                // Wait for the user to respond before closing.
                Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
                if (Console.ReadLine() == "n") endApp = true;

                Console.WriteLine("\n"); // Friendly linespacing.
            }
            return;
        }
    }
}
