using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

using Iris.Messaging.App.MDPage.Chats;
using Iris.Messaging.App.MDPage.ContactsPages;


namespace Iris.Messaging.App.MDPage
{
	public class MasterPage : ContentPage
	{
        public ListView ListView { get; private set; }

        public MasterPage ()
		{
            var masterPageItems = new List<MasterPageItemList>();
            masterPageItems.Add(new MasterPageItemList
            {
                Title = "Contacts",
                IconSource = "Cont.png",
                PageType = typeof(ContactsListPage)
            });

            masterPageItems.Add(new MasterPageItemList
            {
                Title = "Chats",
                IconSource = "Cont.png",
                PageType = typeof(ChatListPage)
            });

            ListView = new ListView
            {
                ItemsSource = masterPageItems,
                ItemTemplate = new DataTemplate(() =>
                {
                    var grid = new Grid { Padding = new Thickness(5, 10) };
                    grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(30) });
                    grid.ColumnDefinitions.Add(new ColumnDefinition { Width = GridLength.Star });

                    var image = new Image();
                    image.SetBinding(Image.SourceProperty, "IconSource");
                    var label = new Label { VerticalOptions = LayoutOptions.FillAndExpand };
                    label.SetBinding(Label.TextProperty, "Title");

                    grid.Children.Add(image);
                    grid.Children.Add(label, 1, 0);

                    return new ViewCell { View = grid };
                }),
                SeparatorVisibility = SeparatorVisibility.None
            };

            //Icon = "";
            Title = "Chat";


            Content = new StackLayout
            {
                Children = { ListView }
            };
        }
	}
}