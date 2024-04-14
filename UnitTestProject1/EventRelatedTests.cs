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
        public void Ctor_WhenViewIsLoaded_CallsViewRender()
        {
            IView mockView = Substitute.For<IView>();
            ILogger mockLogger = Substitute.For<ILogger>();

            Presenter p = new Presenter(mockView, mockLogger);
            mockView.Loaded += Raise.Event<Action>();
            mockView.Received().Render(Arg.Is<string>(x => x.Contains("Hello World")));

        }

        [Test]
        public void Ctor_WhenViewHasError_CallsLogger()
        {
            IView mockView = Substitute.For<IView>();
            ILogger mockLogger = Substitute.For<ILogger>();
            Presenter p = new Presenter(mockView, mockLogger);
            mockView.ErrorOccured += Raise.Event<Action<string>>("fake error");
            mockLogger.Received().LogError(Arg.Is<string>(x => x.Contains("fake error")));

        }
        [Test]
        public void EventFiringManual()
        {
            bool loadFired = false;
            SomeView view = new SomeView();
            view.Loaded += delegate
            {
                loadFired = true;
            };
            view.DoSomethingThatEventuallyFiresThisEvent();
            Assert.IsTrue(loadFired);

        }


    }

    public class SomeView
    {
        public event Action Loaded;

        public SomeView() { 
            
        }

        public void DoSomethingThatEventuallyFiresThisEvent()
        {

        }
    }
}
