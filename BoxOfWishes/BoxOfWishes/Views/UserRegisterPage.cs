
using Xamarin.Forms;
using BoxOfWishes.Models;
using BoxOfWishes.Localization;

namespace BoxOfWishes.Views
{
    public class UserRegisterPage : ContentPage
    {
        public UserRegisterPage()
        {
            this.SetBinding(ContentPage.TitleProperty, "FirstName");

            NavigationPage.SetHasNavigationBar(this, true);
            var firstnameLabel = new Label(); // no Text! localized later
            var firstnameEntry = new Entry();

            firstnameEntry.SetBinding(Entry.TextProperty, "FirstName");
            

            var lastnameLabel = new Label(); // no Text! localized later
            var lastnameEntry = new Entry();
            lastnameEntry.SetBinding(Entry.TextProperty, "LastName");

            var nameLabel = new Label(); // no Text! localized later
            var nameEntry = new Entry();
            nameEntry.SetBinding(Entry.TextProperty, "Name");

            var emailLabel = new Label(); // no Text! localized later
            var emailEntry = new Entry();
            emailEntry.SetBinding(Entry.TextProperty, "Email");

            var telephoneLabel = new Label(); // no Text! localized later
            var telephoneEntry = new Entry();
            telephoneEntry.SetBinding(Entry.TextProperty, "LastName");

            DatePicker datePicker = new DatePicker
            {
                Format = "D",
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            var dateofbirthLabel = new Label(); // no Text! localized later
            var dateofbirthEntry = new Entry();
            telephoneEntry.SetBinding(Entry.TextProperty, "DateOfBirth");
            dateofbirthEntry.Text = datePicker.Date.ToString();

            var addressLabel = new Label(); // no Text! localized later
            var addressEntry = new Entry();
           addressEntry.SetBinding(Entry.TextProperty, "Address");

            var cityLabel = new Label(); // no Text! localized later
            var cityEntry = new Entry();
            cityEntry.SetBinding(Entry.TextProperty, "City");

            var countryLabel = new Label(); // no Text! localized later
            var countryEntry = new Entry();
            countryEntry.SetBinding(Entry.TextProperty, "Country");
            

            var saveButton = new Button(); // no Text! localized later
            saveButton.Clicked += (sender, e) =>
            {
                var user = (User)BindingContext;
                App.Database.SaveItem(user);
                this.Navigation.PopAsync();
            };

            var deleteButton = new Button(); // no Text! localized later
            deleteButton.Clicked += (sender, e) =>
            {
                var user = (User)BindingContext;
                App.Database.DeleteItem(user.Id);
                this.Navigation.PopAsync();
            };

            var cancelButton = new Button(); // no Text! localized later
            cancelButton.Clicked += (sender, e) => {
                this.Navigation.PopAsync();
            };

            var speakButton = new Button(); // no Text! localized later
            speakButton.Clicked += (sender, e) => {
                var user = (User)BindingContext;
                DependencyService.Get<ITextToSpeech>().Speak(user.FirstName + " " + user.Lastname);
            };

            // TODO: Forms Localized text using two different methods:

            // refer to the codebehind for AppResources.resx.designer
            firstnameLabel.Text = AppResources.FirstNameLabel;
            lastnameLabel.Text = AppResources.LastNameLabel;
            nameLabel.Text = AppResources.NameLabel;
            emailLabel.Text = AppResources.EmailLabel;
            telephoneLabel.Text = AppResources.TelephoneLabel;
            dateofbirthLabel.Text = AppResources.DateofbirthLabel;
            addressLabel.Text = AppResources.AddressLabel;
            cityLabel.Text = AppResources.CityLabel;
            countryLabel.Text = AppResources.CountryLabel;
            saveButton.Text = AppResources.SaveButton;
            deleteButton.Text = AppResources.DeleteButton;
            cancelButton.Text = AppResources.CancelButton;
            speakButton.Text = AppResources.SpeakButton;

            firstnameEntry.Placeholder = AppResources.FirstNamePlaceHolder;

            // using ResourceManager
            //saveButton.Text = AppResources.SaveButton;
            //saveButton.Text = AppResources.SaveButton; L10n.Localize("DeleteButton", "Delete");
            //cancelButton.Text = L10n.Localize("CancelButton", "Cancel");
            //speakButton.Text = L10n.Localize("SpeakButton", "Speak");

            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.StartAndExpand,
                Padding = new Thickness(20),
                Children = {
                    firstnameLabel, firstnameEntry,
                    lastnameLabel,lastnameEntry,
                    nameLabel, nameEntry,
                    emailLabel,emailEntry,
                    telephoneLabel,telephoneEntry,
                    dateofbirthLabel,dateofbirthEntry,
                    addressLabel,addressEntry,
                    cityLabel,cityEntry,
                    countryLabel,countryEntry,
					//dueDateLabel, dueDatePicker,
					saveButton, deleteButton, cancelButton, speakButton
                }
            };
        }
    }
}
