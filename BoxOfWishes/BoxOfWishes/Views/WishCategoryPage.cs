
using Xamarin.Forms;
using BoxOfWishes.Models;

namespace BoxOfWishes.Views
{
    public class WishCategoryPage : ContentPage
    {
        public WishCategoryPage()
        {
            this.SetBinding(ContentPage.TitleProperty, "Wish Categories");

            NavigationPage.SetHasNavigationBar(this, true);
            var nameLabel = new Label { Text = "Name" };
            var nameEntry = new Entry();

            nameEntry.SetBinding(Entry.TextProperty, "Name");

            var descriptionLabel = new Label { Text = "Desscription" };
            var descriptionEntry = new Entry();
            descriptionEntry.SetBinding(Entry.TextProperty, "Description");

            var valueLabel = new Label { Text = "Value" };
            var valueEntry = new Entry();
            valueEntry.SetBinding(Entry.TextProperty, "Value");

            var validLabel = new Label { Text = "Valid Until" };
            var validEntry = new Entry();

            DatePicker datePicker = new DatePicker
            {
                Format = "D",
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            validEntry.Text = datePicker.Date.ToLocalTime().ToString();
            validEntry.SetBinding(Entry.TextProperty, "ValidUntil");


            var activeLabel = new Label { Text = "Active" };
            var activeEntry = new Switch();
            activeEntry.SetBinding(Switch.IsToggledProperty, "Active");

            var saveButton = new Button { Text = "Save" };
            saveButton.Clicked += (sender, e) => {
                var category = (WishCategory)BindingContext;
                App.Database.SaveItem(category);
                this.Navigation.PopAsync();
            };

            var deleteButton = new Button { Text = "Delete" };
            deleteButton.Clicked += (sender, e) => {
                var category = (WishCategory)BindingContext;
                App.Database.DeleteItem(category.Id);
                this.Navigation.PopAsync();
            };

            var cancelButton = new Button { Text = "Cancel" };
            cancelButton.Clicked += (sender, e) => {
                var category = (WishCategory)BindingContext;
                this.Navigation.PopAsync();
            };


            var speakButton = new Button { Text = "Speak" };
            speakButton.Clicked += (sender, e) => {
                var category = (WishCategory)BindingContext;
                DependencyService.Get<ITextToSpeech>().Speak(category.Name + " " + category.Description );
            };

            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.StartAndExpand,
                Padding = new Thickness(20),
                Children = {
                    nameLabel, nameEntry,
                    descriptionLabel, descriptionEntry,
                    valueLabel,valueEntry,
                    validLabel,validEntry,
                    activeLabel, activeEntry,
                    saveButton, deleteButton, cancelButton,
                    speakButton
                }
            };
        }
    }
}
