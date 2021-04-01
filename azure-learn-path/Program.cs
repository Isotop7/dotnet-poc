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

            Console.WriteLine($"Hello, {name}! You have {mailCount} in your inbox.  The temperature is {temp} celsius.");

        }
    }
}
