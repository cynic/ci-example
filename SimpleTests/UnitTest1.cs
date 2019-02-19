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
        public void Test1()
        {
            Program p = new Program();
            string result = p.Reverse("MooCow");
            Assert.AreEqual("woCooM", result);
        }
    }
}