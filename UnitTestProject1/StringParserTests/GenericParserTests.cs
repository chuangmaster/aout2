using aout2.Parser;
using NUnit.Framework;
using System;


namespace UnitTestProject1.StringParserTests
{
    public abstract class GenericParserTests<T> where T : IStringParser
    {
        protected abstract string GetInputHeaderSingleDigit();

        protected T GetParser(string input)
        {
            return (T)Activator.CreateInstance(typeof(T), input);
        }

        [Test]
        public void TestGetTextVersionFromHeader_SingleDigit_Found()
        {
            string input = GetInputHeaderSingleDigit();
            T parser = GetParser(input);
            var result = parser.GetTextVersionFromHeader();
            Assert.AreEqual("1", result);
        }
    }
}
