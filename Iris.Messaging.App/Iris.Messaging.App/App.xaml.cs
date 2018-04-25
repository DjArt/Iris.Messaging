using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

using Iris.Messaging.App.MDPage;
using Iris.Messaging.App.MDPage.ContactsPages;
using Iris.Messaging.TestDatabase;

namespace Iris.Messaging.App
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();
			MainPage = new MainPage();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
