namespace BracketChecker
{
    public class Bracket
    {
        public char Opening { get; private set; }
        public char Closing { get; private set; }

        public Bracket(char opening, char closing)
        {
            Opening = opening;
            Closing = closing;
        }
    }
}