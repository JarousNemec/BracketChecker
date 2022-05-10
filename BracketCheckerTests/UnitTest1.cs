using NUnit.Framework;

namespace BracketCheckerTests
{
    public class Tests
    {
        private BracketChecker.BracketChecker _checker;
        [SetUp]
        public void Setup()
        {
            _checker = new BracketChecker.BracketChecker();
        }

        [Test]
        public void CheckTestTrue()
        {
            Assert.True(_checker.Bracket("{ 2 * { (3-1) / (2+4) } - [ 69 * 96] }"));
        }
        [Test]
        public void CheckTestFalse()
        {
            Assert.False(_checker.Bracket("{ 2 *  3-1) / (2+4)  -  69 * 96] }"));
        }
    }
}