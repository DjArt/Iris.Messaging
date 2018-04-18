using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

using Iris.Messaging.App.MDPage.ContactsMVVM;


namespace Iris.Messaging.App.MDPage
{
	public class MainPage : MasterDetailPage
	{
        MasterPage masterPage;
		public MainPage ()
		{
            masterPage = new MasterPage();
            Master = masterPage;
            Detail = new NavigationPage(new ContactsListPage());

            masterPage.ListView.ItemSelected += OnItemSelected;
        }

        void OnItemSelected (object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterPageItemList;
            if (item != null)
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(item.PageType));
                masterPage.ListView.SelectedItem = null;
                IsPresented = false;
            }
        }

	}
}