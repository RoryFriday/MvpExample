namespace MvpExample.Presentation.Components
{
    public class SubscriberFormPresenter
    {
        private readonly ISubscriberFormView _view;
        private readonly ISubscriberService _service;

        public SubscriberFormPresenter(ISubscriberFormView view, ISubscriberService service)
        {
            _view = view;
            _service = service;
        }

        public void SaveSubscriber()
        {
            _service.SaveSubscriber(_view.Name, _view.Email);
        }
    }
}
