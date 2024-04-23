using LogAn;
using NUnit.Framework;
using System.Management.Instrumentation;

namespace UnitTestProject1
{
    /// <summary>
    /// Summary description for UnitTest2
    /// </summary>
    [TestFixture]
    [Category("UnitTest")]
    public class MemCalculatorTest
    {
        [Test]
        public void Sum_WhenCalled_ReturnsZero()
        {
            MemCalculator calculator = MakeCalculator();
            int lastSum = calculator.Sum();
            Assert.AreEqual(0, lastSum);
        }

        [Test]
        public void Add_WhenCalled_ChangeSum()
        {
            MemCalculator calculator = MakeCalculator();
            calculator.Add(1);
            int sum = calculator.Sum();
            Assert.AreEqual(1, sum);
        }

        public MemCalculator MakeCalculator()
        {
            return new MemCalculator();
        }
    }
}