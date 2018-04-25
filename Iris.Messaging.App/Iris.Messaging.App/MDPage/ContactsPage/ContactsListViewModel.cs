using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Input;

using Xamarin.Forms;

using Iris.Messaging.Contacts;
using Iris.Messaging.App.MDPage.ContactsPages;
using Iris.Messaging.TestDatabase;

namespace Iris.Messaging.App.MDPage.ContactsPages.Model
{
    public class ContactsListViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<ContactsViewModel> Contact { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand CreateContactCommand { protected set; get; }
        public ICommand DeleteContactCommand { protected set; get; }
        public ICommand SaveContactCommand { protected set; get; }
        public ICommand BackCommand { protected set; get; }
        ContactsViewModel selectedContact;
        public INavigation Navigation { get; set; }


        public ContactsListViewModel()
        {
            Contact = new ObservableCollection<ContactsViewModel>();
            CreateContactCommand = new Command(CreateContact);
            DeleteContactCommand = new Command(DeleteContact);
            SaveContactCommand = new Command(SaveContact);
            BackCommand = new Command(Back);
        }

        protected void OnPropertyChanged(string strName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(strName));
        }

        public ContactsViewModel SelectedContact
        {
            get { return selectedContact; }
            set
            {
                if (selectedContact != value)
                {
                    ContactsViewModel tempContact = value;
                    selectedContact = null;
                    OnPropertyChanged("SelecredContact");
                    Navigation.PushAsync(new ContactsPage(tempContact));
                }
            }
        }

        private void CreateContact()
        {
            Navigation.PushAsync(new ContactsPage(new ContactsViewModel { ListViewModel = this }));
        }

        private void Back()
        {
            Navigation.PopAsync();
        }

        private void SaveContact(object ContactsObj)
        {
            ContactsViewModel contacts = ContactsObj as ContactsViewModel;
            if (contacts != null && contacts.IsValid)
            {
                Contact.Add(contacts);
                Back();
            }

            
        }

        private void DeleteContact(object ContactsObj)
        {
            ContactsViewModel contacts = ContactsObj as ContactsViewModel;
            if (contacts != null)
            {
                Contact.Remove(contacts);
            }
            Back();
        }
    }
}
