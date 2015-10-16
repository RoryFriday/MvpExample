using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvpExample.Presentation.Components
{
    public class SubscriberService : ISubscriberService
    {
        public SubscriberService(ISubscriberRepository repo)
        {
            
        }

        public void SaveSubscriber(string name, string email)
        {
            throw new NotImplementedException();
        }
    }
}
