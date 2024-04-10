using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using aout2;
using NSubstitute;
using NUnit.Framework;
    

namespace UnitTestProject1
{
    [TestFixture]
    public class FileNameRuleTest
    {
        [Test]
        public void Returns_ByDefault_WorksForHardCodedArgument()
        {
            IFileNameRule fakeRules= Substitute.For<IFileNameRule>();
            fakeRules.IsValdLogFileName("xxx.txt").Returns(true);
            Assert.That(fakeRules.IsValdLogFileName("xxx.txt"));
        }

        [Test]
        public void Returns_ByDefault_WorksForHardCodedArgument2()
        {
            IFileNameRule fakeRules = Substitute.For<IFileNameRule>();
            fakeRules.IsValdLogFileName(Arg.Any<string>()).Returns(true);
            Assert.That(fakeRules.IsValdLogFileName(string.Empty));
        }

        [Test]
        public void Return_ArgAny_Throws()
        {
            IFileNameRule fakeRules = Substitute.For<IFileNameRule>();
            fakeRules.When(x => x.IsValdLogFileName(Arg.Any<string>()))
                .Do(context => { throw new Exception("Fake exception"); });
            Assert.Throws<Exception>(() =>
            {
                fakeRules.IsValdLogFileName("anything.txt");
            });
        }
    }
}
