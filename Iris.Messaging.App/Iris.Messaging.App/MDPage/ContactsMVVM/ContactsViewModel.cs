using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

using Xamarin.Forms;

using Iris.Messaging.Contacts;

namespace Iris.Messaging.App.MDPage.ContactsMVVM.Model
{
	public class ContactsViewModel : INotifyPropertyChanged
	{
        public event PropertyChangedEventHandler PropertyChanged;
        ContactsListViewModel ListVM;

        public Contact Contact { get; private set; }

        public ContactsViewModel ()
		{
            Contact = new Contact();
		}

        protected void OnPropertyChanged(string strName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(strName));
        }

        public ContactsListViewModel ListViewModel
        {
            get { return ListVM; }
            set
            {
                if (ListVM != value)
                {
                    ListVM = value;
                    OnPropertyChanged("ListViewModel");
                }
            }
        }

        public string Name
        {
            get { return Contact.Name; }
            set
            {
                if (Contact.Name != value)
                {
                    Contact.Name = value;
                    OnPropertyChanged("Name");
                }
            }
        }

        public bool IsValid
        {
            get
            {
                return (!string.IsNullOrEmpty(Name));
            }
        }

    }
}