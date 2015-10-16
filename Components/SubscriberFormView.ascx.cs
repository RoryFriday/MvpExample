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
            _presenter = ServiceLocator.Get<ISubscriberFormView, SubscriberFormPresenter>(this);
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