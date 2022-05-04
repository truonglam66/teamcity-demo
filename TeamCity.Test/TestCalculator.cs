using NUnit.Framework;

namespace TeamCity.Test
{
    [TestFixture]
    public class TestCalculator
    {
        private Calculator cal; 
        [SetUp]
        public void Setup()
        {
            cal = new Calculator();
        }

        [TestCase(1,1,3)]
        [TestCase(4,4,8)]
        [TestCase(3,2,5)]
        [TestCase(6,4,10)]
        public void TestAdd(int a, int b, int c)
        {
            Assert.AreEqual(c, cal.Add(a, b));
        }

        [TestCase(3, 1, 2)]
        [TestCase(5, 3, 2)]
        [TestCase(4, 3, 1)]
        [TestCase(1, 1, 0)]
        public void TestSub(int a, int b, int c)
        {
            Assert.AreEqual(c, cal.Sub(a, b));
        }
    }
}