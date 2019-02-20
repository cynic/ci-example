using NUnit.Framework;
using Simple;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SimpleReversalWorks()
        {
            Program p = new Program();
            string result = p.Reverse("MooCow");
            Assert.AreEqual("woCooM", result);
        }

        [Test]
        public void ReversalOfEmptyStringWorks()
        {
            Program p = new Program();
            string result = p.Reverse("");
            Assert.AreEqual("", result);
        }

        [Test]
        public void ReversalOfNullWorks()
        {
            Program p = new Program();
            string result = p.Reverse(null);
            Assert.AreEqual(null, result);
        }
    }
}