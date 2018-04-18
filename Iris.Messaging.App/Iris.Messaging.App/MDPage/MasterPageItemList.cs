using Xamarin.Forms;
using System;
using Xamarin;


namespace Iris.Messaging.App.MDPage
{
    internal class MasterPageItemList 
    {
        public string Title { get; set; }

        public ImageSource IconSource { get; set; }

        public  Type PageType { get; set; }
    }
}