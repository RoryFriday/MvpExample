using System;
using MvpExample.Presentation.Components;
using MvpExample.Service;

namespace MvpExample.Components
{
    public partial class SubscriberFormView : System.Web.UI.UserControl, ISubscriberFormView
    {
        private SubscriberFormPresenter _presenter;

        #region ISubscriberForm Members

        public string Name
        {
            get { return txtName.Text; }
        }

        public string Email
        {
            get { return txtEmail.Text; }
        }

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            // This is using our IoC container to create our presenter (and its dependencies) for us
            _presenter = ServiceLocator.Get<ISubscriberFormView, SubscriberFormPresenter>(this);

            // Alternative to using IoC container, we would end up creating our own presenter factory
            // but ultimately would end up having to manually new up all our dependencies
            //_presenter = new SubscriberFormPresenter(this, new SubscriberService(new SubscriberRepository()));
        }

        protected void SubmitSubscriber_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                _presenter.SaveSubscriber();    
            }
        }
    }
}