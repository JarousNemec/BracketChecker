using System;

namespace BracketChecker
{
    class Program
    {
        static void Main()
        {
            BracketChecker checker = new BracketChecker();
            Console.WriteLine("Zadejte výraz, který chcete zkontrolovat:");
            var result = checker.Bracket(Console.ReadLine());
            Console.WriteLine($"\nVýraz je napsán "+ (result ? "správně":"špatně"));
            Console.ReadKey();
        }
    }
}