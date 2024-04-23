using aout2;
using NSubstitute;
using NUnit.Framework;
using System;

namespace UnitTestProject1
{
    [TestFixture]
    public class EventRelatedTests
    {
        [Test]
        [Property("UnitTest", "T")]
        public void Ctor_WhenViewIsLoaded_CallsViewRender()
        {
            IView mockView = Substitute.For<IView>();
            Presenter p = new Presenter(mockView);
            mockView.Loaded += Raise.Event<Action>();
            mockView.Received().Render(Arg.Is<string>(x => x.Contains("Hello World")));

        }
    }
}
