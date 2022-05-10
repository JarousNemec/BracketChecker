using System;
using System.Collections.Generic;
using System.Linq;

namespace BracketChecker
{
    public class BracketChecker
    {
        private List<Bracket> brackets;
        private Stack<char> foundBrackets;

        public BracketChecker()
        {
            brackets = new List<Bracket>();
            foundBrackets = new Stack<char>();
            brackets.Add(new Bracket('(', ')'));
            brackets.Add(new Bracket('{', '}'));
            brackets.Add(new Bracket('[', ']'));
        }

        public bool Bracket(string expession)
        {
            var res = true;
            foreach (var c in expession)
            {
                var foundOpening = brackets.FirstOrDefault(x => x.Opening == c);
                if (foundOpening != null)
                {
                    Console.Write(c + " ");
                    foundBrackets.Push(c);
                    continue;
                }

                var foundClosing = brackets.FirstOrDefault(x => x.Closing == c);
                if (foundClosing != null)
                {
                    if (foundBrackets.Pop() != foundClosing.Opening)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(c + " ");
                        Console.ResetColor();
                        res = false;
                    }
                    else
                    {
                        Console.Write(c + " ");
                    }
                }
            }

            return res;
        }
    }
}