using Iris.Messaging.Contacts;
using Iris.Messaging.Dialog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Iris.Messaging.TestDatabase
{
    public class Main
    {
        public static List<Chat> Init()
        {
            Contact first = new Contact()
            {
                Name = "FirstContact"
            };
            Contact second = new Contact()
            {
                Name = "SecondContact"
            };
            Contact thirds = new Contact()
            {
                Name = "ThirdsContact"
            };
            Message m0 = new Message()
            {
                Author = first,
                Text = "Hi!"
            };
            Message m1 = new Message()
            {
                Author = second,
                Text = "Hello!"
            };
            Message m2 = new Message()
            {
                Author = thirds,
                Text = "F*ck!"
            };
            Chat chat = new Chat()
            {
                Participants = new List<Contact>()
                {
                    first, second, thirds
                },
                Messages = new List<Message>()
                {
                    m0, m1, m2
                }
            };
            return new List<Chat>() { chat };
            // Артем тут 
        }
    }
}