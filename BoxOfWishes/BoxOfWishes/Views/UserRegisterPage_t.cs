using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Diagnostics;
using TodoLocalized.Resx;

namespace BoxOfWishes
{
	public class UserRegisterPage : ContentPage
	{
		public TodoItemPage ()
		{
			this.SetBinding (ContentPage.TitleProperty, "FirstName");

			NavigationPage.SetHasNavigationBar (this, true);
			var firstnameLabel = new Label (); // no Text! localized later
			var firstnameEntry = new Entry ();
			
			firstnameEntry.SetBinding (Entry.TextProperty, "FirstName");

			var lastnameLabel = new Label (); // no Text! localized later
			var lastnameEntry = new Entry ();
			lastnameEntry.SetBinding (Entry.TextProperty, "LastName");

			var nameLabel = new Label (); // no Text! localized later
			var nameEntry = new Entry ();
			nameEntry.SetBinding (Entry.TextProperty, "Name");

			var emailLabel = new Label (); // no Text! localized later
			var emailEntry = new Entry ();
			emailEntry.SetBinding (Entry.TextProperty, "Email");

			var telephoneLabel = new Label (); // no Text! localized later
			var telephoneEntry = new Entry ();
			telephoneEntry.SetBinding (Entry.TextProperty, "LastName");

      		DatePicker datePicker = new DatePicker
            {
                Format = "D",
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

			var dateofbirthLabel = new Label (); // no Text! localized later
			var dateofbirthEntry = new Entry ();
			telephoneEntry.SetBinding (Entry.TextProperty, "DateOfBirth");
			dateofbirthEntry.Text = datePicker.Date.ToString();

			var doneLabel = new Label (); // no Text! localized later
			var doneEntry = new Switch ();
			doneEntry.SetBinding (Switch.IsToggledProperty, "Done");

			var saveButton = new Button (); // no Text! localized later
			saveButton.Clicked += (sender, e) => {
				var todoItem = (TodoItem)BindingContext;
				App.Database.SaveItem(todoItem);
				this.Navigation.PopAsync();
			};

			var deleteButton = new Button (); // no Text! localized later
			deleteButton.Clicked += (sender, e) => {
				var todoItem = (TodoItem)BindingContext;
				App.Database.DeleteItem(todoItem.ID);
                this.Navigation.PopAsync();
			};
							
			var cancelButton = new Button (); // no Text! localized later
			cancelButton.Clicked += (sender, e) => {
                this.Navigation.PopAsync();
			};

			var speakButton = new Button (); // no Text! localized later
			speakButton.Clicked += (sender, e) => {
				var todoItem = (TodoItem)BindingContext;
				DependencyService.Get<ITextToSpeech>().Speak(todoItem.Name + " " + todoItem.Notes);
			};


			// TODO: Forms Localized text using two different methods:

			// refer to the codebehind for AppResources.resx.designer
			nameLabel.Text = AppResources.NameLabel;
			notesLabel.Text = AppResources.NotesLabel;
			doneLabel.Text = AppResources.DoneLabel;

			// using ResourceManager
			saveButton.Text = AppResources.SaveButton;
			deleteButton.Text = L10n.Localize ("DeleteButton", "Delete");
			cancelButton.Text = L10n.Localize ("CancelButton", "Cancel");
			speakButton.Text = L10n.Localize ("SpeakButton", "Speak");

			// HACK: included as a 'test' for localizing the picker
			// currently not saved to database
			//var dueDateLabel = new Label { Text = "Due" };
			//var dueDatePicker = new DatePicker ();


			Content = new StackLayout {
				VerticalOptions = LayoutOptions.StartAndExpand,
				Padding = new Thickness(20),
				Children = {
					nameLabel, nameEntry, 
					notesLabel, notesEntry,
					doneLabel, doneEntry,
					//dueDateLabel, dueDatePicker,
					saveButton, deleteButton, cancelButton, speakButton
				}
			};
		}
	}
}