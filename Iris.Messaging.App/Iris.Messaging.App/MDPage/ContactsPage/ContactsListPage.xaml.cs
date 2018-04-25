using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Iris.Messaging.Contacts;
using Iris.Messaging.App.MDPage.ContactsPages.Model;
using  Iris.Messaging.TestDatabase;

namespace Iris.Messaging.App.MDPage.ContactsPages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContactsListPage : ContentPage
	{
		public ContactsListPage()
		{
			InitializeComponent ();

            BindingContext = new ContactsListViewModel() { Navigation = this.Navigation };
            booksList.ItemSelected += OnItemSelected;
            var data = Main.Init();
            foreach (Contact a in data.Item1)
            {

            }
            
        }

        void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            booksList.SelectedItem = null;
        }
    }
}