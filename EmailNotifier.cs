using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14
{
    //DIP
    public class EmailNotifier
    {
        public void SendEmail()
        { 
            //email sending...
        }
    }
    public class NotifierService
    { 
        private EmailNotifier _notifier = new EmailNotifier();
        public void Notify()
        { 
            _notifier.SendEmail();
        }
    }

    //Refactoring
    public interface INotifier
    {
        void Notify();
    }
    public class EmailNotifierDIP : INotifier
    {
        public void Notify()
        {
            //Send an email
        }
    }
    public class NotificationServiceDIP
    {
        private INotifier _notifier;
        public NotificationServiceDIP(INotifier notifier)
        { 
            _notifier = notifier;
        }
        public void Notify()
        { 
            _notifier.Notify();
        }
    
    }

}
