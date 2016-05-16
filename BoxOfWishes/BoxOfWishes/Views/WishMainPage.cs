using System.Diagnostics;
using Xamarin.Forms;

namespace BoxOfWishes
{
    public class WishMainPage : ContentPage
    {
        public WishMainPage()
        {
            ListView listView;
            listView = new ListView();
            listView.ItemTemplate = new DataTemplate
                    (typeof(WishesItemCell));
            listView.ItemSelected += (sender, e) =>
            {
                var todoItem = (TodoItem)e.SelectedItem;
                var todoPage = new TodoItemPage();
                todoPage.BindingContext = todoItem;

                ((App)App.Current).ResumeAtWishesId = todoItem.ID;
                Debug.WriteLine("setting ResumeAtWishesId = " + todoItem.ID);

                Navigation.PushAsync(todoPage);

            };
          
        }
    }
}
