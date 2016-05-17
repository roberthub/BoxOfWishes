using System;
using System.Reflection;
using Xamarin.Forms;
using System.Diagnostics;
using System.Globalization;

using BoxOfWishes.Data;
using BoxOfWishes.Localization;
using BoxOfWishes.Views;

namespace BoxOfWishes
{
    public class App : Application
    {
        static BOWDatabase database;
        public App()
        {

            var assembly = typeof(App).GetTypeInfo().Assembly;
            foreach (var res in assembly.GetManifestResourceNames())
                System.Diagnostics.Debug.WriteLine(" ### found resource: " + res);

            if (Device.OS != TargetPlatform.WinPhone)
            {
                //var netLanguage = DependencyService.Get<ILocalize>().GetCurrentCultureInfo();
                //AppResources.Culture = new CultureInfo(netLanguage);
                DependencyService.Get<ILocalize>().SetLocale();
            }
            MainPage = new NavigationPage(new BOWMainPage());
           // MainPage = new NavigationPage(new UserRegisterPage());
        }

        public static BOWDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new BOWDatabase();
                }
                return database;
            }
        }
        public int ResumeAtWishesId { get; set; }
        protected override void OnStart()
        {
            Debug.WriteLine("OnStart");
            // always re-set when the app starts
            // users expect this (usually)
            //			Properties ["ResumeAtTodoId"] = "";
            if (Properties.ContainsKey("ResumeAtWishesId"))
            {
                var rati = Properties["ResumeAtWishesId"].ToString();
                Debug.WriteLine("   rati=" + rati);
                if (!String.IsNullOrEmpty(rati))
                {
                    Debug.WriteLine("   rati = " + rati);
                    ResumeAtWishesId = int.Parse(rati);

                    if (ResumeAtWishesId >= 0)
                    {
                        //var todoPage = new TodoItemPage();
                        //todoPage.BindingContext = Database.GetItem(ResumeAtWishesId);

                        //MainPage.Navigation.PushAsync(
                        //    todoPage,
                        //    false); // no animation
                    }
                }
            }
        }
        protected override void OnSleep()
        {
            Debug.WriteLine("OnSleep saving ResumeAtWishesId = " + ResumeAtWishesId);
            // the app should keep updating this value, to
            // keep the "state" in case of a sleep/resume
            Properties["ResumeAtWishesId"] = ResumeAtWishesId;
        }

        protected override void OnResume()
        {
            Debug.WriteLine("OnResume");
            if (Properties.ContainsKey("ResumeAtWishesId"))
            {
                var rati = Properties["ResumeAtWishesId"].ToString();
                Debug.WriteLine("   rati=" + rati);
                if (!String.IsNullOrEmpty(rati))
                {
                    Debug.WriteLine("   rati = " + rati);
                    ResumeAtWishesId = int.Parse(rati);

                    if (ResumeAtWishesId >= 0)
                    {
                        //var todoPage = new TodoItemPage();
                        //todoPage.BindingContext = Database.GetItem(ResumeAtWishesId);

                        //MainPage.Navigation.PushAsync(
                        //    todoPage,
                        //    false); // no animation
                    }
                }
            }
        }
    }
}
