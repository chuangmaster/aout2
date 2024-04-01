using LogAn;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System;

namespace UnitTestProject1
{
    [TestFixture]
    public class UnitTest1
    {

        //[Test]
        //public void IsValidLogFileName_BadExtension_ReturnsFalse()
        //{

        //    LogAnalyzer analyzer = new LogAnalyzer();

        //    bool result = analyzer.IsValidLogFileName("filewithbadextension.foo");

        //    Assert.That(result, Is.False, "這是被log的文字");

        //    //NUnit 4.0以前寫法
        //    //ClassicAssert.True(result);
        //}

        //[Test]
        //public void IsValidLogFileName_GoodExtensionLowercase_ReturnsTrue()
        //{
        //    LogAnalyzer analyzer = new LogAnalyzer();

        //    bool result = analyzer.IsValidLogFileName("filewithgoodextension.slf");

        //    Assert.That(result, Is.True);
        //}

        //[Test]
        //public void IsValidLogFileName_GoodExtensionUppercase_ReturnsTrue()
        //{
        //    LogAnalyzer analyzer = new LogAnalyzer();

        //    bool result = analyzer.IsValidLogFileName("filewithgoodextension.SLF");

        //    Assert.That(result, Is.True);
        //}

        private LogAnalyzer _Analyzer;
        [SetUp]
        public void Setup()
        {
            _Analyzer = new LogAnalyzer();
        }
        [TearDown]
        public void Teardown()
        {
            //This is demo
            //_Analyzer = null;
        }
        [TestFixtureSetUp]
        public void Init()
        { /* ... */ }

        [TestFixtureTearDown]
        public void Cleanup()
        { /* ... */ }

        #region Use Test Case
        [TestCase("filewithgoodextension.slf")]
        [TestCase("filewithgoodextension.SLF")]

        public void IsValidLogFileName_GoodExtensionUppercase_ReturnsTrue(string fileName)
        {
            bool result = _Analyzer.IsValidLogFileName(fileName);

            Assert.That(result, Is.True);
        }
        [TestCase("filewithgoodextension.slf", true)]
        [TestCase("filewithgoodextension.SLF", true)]
        [TestCase("filewithgoodextension.foo", false)]
        [TestCase("filewithgoodextension.Foo", false)]
        public void IsValidLogFileName_VariousExtensions_CheksThem(string fileName, bool expected)
        {
            bool result = _Analyzer.IsValidLogFileName(fileName);
            Assert.That(result, Is.EqualTo(expected));
        }
        #endregion


    }
}
