using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Iris.Messaging.App.MDPage.ContactsPages.Model;

namespace Iris.Messaging.App.MDPage.ContactsPages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContactsPage : ContentPage
	{
        public ContactsViewModel ViewModel { get; private set; }
		public ContactsPage (ContactsViewModel VM)
		{
			InitializeComponent ();
            ViewModel = VM;
            this.BindingContext = ViewModel;
        }


	}
}