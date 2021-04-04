using System;

namespace azure_learn_path
{
    class Program
    {
        static void Main(string[] args)
        {
            string surname = "MüllerMeierSchmidt";

            Console.WriteLine("This is the first line.");
            Console.WriteLine("This is the second line.");

            Console.WriteLine("String: " + "<String>");
            Console.WriteLine("Literal: " + 'y');
            Console.WriteLine("Integer: " + 4711);
            Console.WriteLine("Decimal: " + 12.8m);
            Console.WriteLine("Bool: " + true + " and " + false);

            Console.WriteLine("Call string var 'newVar': " + surname);

            var name = "Bob";
            var mailCount = 8;
            var temp = 34.4m;

            Console.WriteLine(arrow() + $"Hello, {name}! You have {mailCount} in your inbox.  The temperature is {temp} celsius.");

            // csharp-basic-formatting
            basicFormatting();

            // csharp-basic-operations
            basicOperations();
        }

        static void basicOperations() 
        {
            printHeader("Simple addition");
            int x = 3183;
            int y = 785;
            Console.WriteLine($"Adding {x} to {y} = {x+y}");

            printHeader("Mixed Data:");
            string name = "Arthur";
            int soldUnits = 49;
            Console.WriteLine($"{name} sold {soldUnits} units");
            
            printHeader("Math operations");
            int a = 32;
            int b = 6;
            Console.WriteLine($"Adding {a} to {b} = {a+b}");
            Console.WriteLine($"Subtracting {b} from {a} = {a-b}");
            Console.WriteLine($"Multiplying {a} with {b} = {a*b}");
            Console.WriteLine($"Dividing {b} from {a} = {(decimal)a/b}");
            Console.WriteLine($"Modulues when dividing {b} from {a} = {a%b}");
            Console.WriteLine($"Multiplying {a} with {a} {b}-times = {System.Math.Pow(a, b)}");

            printHeader("Increment and decrement");
            int dec = 10;
            int inc = 10;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Decrement {dec} by 1; new value: {--dec}");
                Console.WriteLine($"Increment {inc} by 1; new value: {++inc}");
            }

            printHeader("Temperature Converter");
            int fahrenheit = 94;
            decimal celsius = System.Math.Round((fahrenheit-32) * ( (decimal)5/9 ),2);
            Console.WriteLine($"{fahrenheit} degrees fahrenheit are {celsius} degrees celsius");
        }

        static void basicFormatting()
        {
            printHeader("Basic formatting");
            Console.WriteLine("\n\ncsharp-basic-formatting:");
            Console.WriteLine("Invoice\t\t\t\"mockup\"");
            Console.WriteLine("Invoice path: C:\\DATA\\invoices\\2021");
            Console.WriteLine(@"Invoice 1:
            
            Company ABC:    191,54$");

            printHeader("Unicode strings:");
            Console.WriteLine("\n\nWe also have unicode strings! \u3053\u3093\u306B\u3061\u306F World!");
            Console.WriteLine("\u039E\t\u039E\t\u039E");

            printHeader("String concatenation");
            string firstName = "Arthur";
            Console.WriteLine("Hello, " + firstName + '!');

            printHeader("String interpolation");
            Console.WriteLine($"Hello, {firstName}!");

            printHeader("String interpolation and verbatim literals");
            string projectName = "azure-learn-path";
            Console.WriteLine(@$"Folder: C:\{projectName}\source\code");
        }

        static void printHeader(string header)
        {
            Console.WriteLine();
            Console.WriteLine($"__________________________________________\n{arrow()}{header}:");
        }

        static string arrow()
        {
            return "\u21aa ";
        }
    }
}
