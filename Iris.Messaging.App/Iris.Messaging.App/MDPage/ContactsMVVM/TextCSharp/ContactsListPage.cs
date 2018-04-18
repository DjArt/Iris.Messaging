using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Iris.Messaging.App.MDPage.ContactsMVVM.Model;
using Xamarin.Forms;

namespace Iris.Messaging.App.MDPage.ContactsMVVMtest
{
	public class ContactsListPage : ContentPage
	{
        ContactsListViewModel CLWM;
        ListView listView;
        public ContactsListPage()
        {
            
            BindingContext = new ContactsListViewModel() { Navigation = this.Navigation };

            CLWM = new ContactsListViewModel();
            var Stack1 = new StackLayout { Padding = new Thickness() };
            var button = new Button { Text = "Add contact", Command = CLWM.CreateContactCommand };

            Stack1.Children.Add(button);

            listView = new ListView
            {
                ItemsSource = CLWM.Contact,
                SelectedItem = CLWM.SelectedContact, 
               // Mode =TwoWay,
                HasUnevenRows = true,
                ItemTemplate = new DataTemplate(() =>
                {
                    var Stack = new StackLayout { Padding = new Thickness() };
                    var label = new Label { VerticalOptions = LayoutOptions.FillAndExpand, FontSize = 20};

                    label.SetBinding(Label.TextProperty, "Name");
                    Stack.Children.Add(label);

                    return new ViewCell { View = Stack };
                }),
                SeparatorVisibility = SeparatorVisibility.None
            };

            Title = "Contacts";
        }
    
	}
}