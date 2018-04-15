using Iris.Messaging.Contacts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Iris.Messaging.Dialog
{
    public class Chat
    {
        public List<Message> Messages { get; set; }
        public List<Contact> Participants { get; set; }
        public Contact Creator { get; set; }
        public DateTime CreationTime { get; set; }
    }
}
