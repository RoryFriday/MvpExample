using FakeItEasy;
using MvpExample.Presentation.Components;
using NUnit.Framework;

namespace MvpExample.Presentation.Tests
{
    [TestFixture]
    public class SubscriberFormPresenterTests
    {
        [Test]
        public void CanSaveSubscriber()
        {
            // Arrange
            var view = A.Fake<ISubscriberFormView>();
            var service = A.Fake<ISubscriberService>();

            var presenter = new SubscriberFormPresenter(view, service);

            // Act
            presenter.SaveSubscriber();

            // Assert
            A.CallTo(() => service.SaveSubscriber(view.Name, view.Email)).MustHaveHappened();
        }
    }
}
