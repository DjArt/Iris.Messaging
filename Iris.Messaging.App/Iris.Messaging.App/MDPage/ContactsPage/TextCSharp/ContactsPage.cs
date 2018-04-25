using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

using Iris.Messaging.App.MDPage.ContactsPages.Model;
using Iris.Messaging.Contacts;

namespace Iris.Messaging.App.MDPage.ContactsMVVMtest
{
	public class ContactsPage : ContentPage
	{
        ContactsViewModel CVM; 
        public ContactsViewModel ViewModel { get; private set; }
		public ContactsPage (ContactsViewModel VM)
		{
            ViewModel = VM;
            this.BindingContext = ViewModel;
            // Title = "Chat";

            CVM = new ContactsViewModel();

            var Stack1 = new StackLayout {  };
            var label = new Label {Text = "Name", FontSize = 10};
            var entry = new Entry { };
            entry.SetBinding(Entry.TextProperty, "Name");

            Stack1.Children.Add(label);
            Stack1.Children.Add(entry);

            var Stack = new StackLayout { Orientation = StackOrientation.Horizontal, HorizontalOptions = LayoutOptions.CenterAndExpand };

            var But0 = new Button { Text = "Add", Command = CVM.ListViewModel.SaveContactCommand, CommandParameter = BindingContext };
            var But1 = new Button { Text = "Delete", Command = CVM.ListViewModel.DeleteContactCommand, CommandParameter = BindingContext };
            var But2 = new Button { Text = "Back", Command = CVM.ListViewModel.BackCommand };

            Stack.Children.Add(But0);
            Stack.Children.Add(But1);
            Stack.Children.Add(But2);

        }
	}
}