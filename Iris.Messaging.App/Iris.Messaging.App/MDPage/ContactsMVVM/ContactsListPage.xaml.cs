using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Iris.Messaging.Contacts;
using Iris.Messaging.App.MDPage.ContactsMVVM.Model;

namespace Iris.Messaging.App.MDPage.ContactsMVVM
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContactsListPage : ContentPage
	{
		public ContactsListPage()
		{
			InitializeComponent ();
            BindingContext = new ContactsListViewModel() { Navigation = this.Navigation };
            booksList.ItemSelected += OnItemSelected;
            
        }

        void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            booksList.SelectedItem = null;
        }
    }
}