

using System;
using aout2;
using LogAn;
using NUnit.Framework;

namespace UnitTestProject1.LogAnalyzer
{

    [TestFixture]
    public class LogAnalyzer3Tests
    {

        [Test]
        [Ignore]
        public void TestAnalyze()
        {
            var input = "a\tb\t";

            LogAnalyzer3 analyzer = new LogAnalyzer3();

            AnalyzedOutput expexted = new AnalyzedOutput();
            expexted.AddLine("a", "b");
            AnalyzedOutput act = analyzer.Analyze(input);

            Assert.AreEqual(expexted, act);
        }
    }
}
