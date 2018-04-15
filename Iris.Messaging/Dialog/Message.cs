using Iris.Messaging.Cache;
using Iris.Messaging.Contacts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Iris.Messaging.Dialog
{
    public class Message
    {
        public Guid ID { get; set; }
        public DateTime CreateTime { get; set; }
        public string Text { get; set; }
        public List<IResourceHandle> Attachments { get; set; }
        public Contact Author { get; set; }
    }
}
