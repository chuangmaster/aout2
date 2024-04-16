using aout2;
using NUnit.Framework;

namespace UnitTestProject1
{
    [TestFixture]
    [Culture("zh-TW")]
    public class TimeLoggerTests
    {
        [Test]
        public void SettingTime_Always_ChangesTime()
        {
            SystemTime.Set(new System.DateTime(2024, 4, 17));
            string output = TimeLogger.CreateMessage("Hello world");
            StringAssert.Contains("2024/4/17", output);
        }
    }
}
