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
        [Category("Positive Unit Test")]
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
        public void IsValidLogFileName_VariousExtensions_ChecksThem(string fileName, bool expected)
        {
            bool result = _Analyzer.IsValidLogFileName(fileName);
            Assert.That(result, Is.EqualTo(expected));
        }
        #endregion


        [Test]
        [Category("Exception Unit Test")]
        [ExpectedException(typeof(ArgumentException), ExpectedMessage = "filename has to be provided")]
        public void IsValidLogFileName_EmptyFileName_ThrowException()
        {
            _Analyzer.IsValidLogFileName(string.Empty);
        }

        [Test]
        [Category("Exception Unit Test")]
        public void IsValidLogFileName_EmptyFileName_ThrowException_way2()
        {
            Assert.Throws<ArgumentException>(()=> _Analyzer.IsValidLogFileName(string.Empty));
        }

        [Test]
        public void IsValidLogFileName_EmptyFileName_ThrowException_way3()
        {
            var analyzer = MakeAnalyzer();
            var ex = Assert.Catch<ArgumentException>(() => analyzer.IsValidLogFileName(string.Empty));
            NUnit.Framework.StringAssert.Contains("filename has to be provided", ex.Message);
        }
        [Test]
        [Ignore("to do this test method")]
        public void IsValidLogFileName_todo()
        {

        }

        private LogAnalyzer MakeAnalyzer() {
            return new LogAnalyzer();
        }
    }

}
