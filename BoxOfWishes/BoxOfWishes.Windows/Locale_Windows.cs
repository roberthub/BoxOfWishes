using Xamarin.Forms;
using BoxOfWishes.Localization;

[assembly: Dependency(typeof(BoxOfWishes.Locale_Windows))]

namespace BoxOfWishes
{
    public class Locale_Windows : ILocalize
    {
        /// <remarks>
        /// Not sure if we can cache this info rather than querying every time
        /// </remarks>
        public string GetCurrentCultureInfo()
        {
           return System.Globalization.CultureInfo.CurrentUICulture.Name;
        }


        public void SetLocale()
        {
           
          ////Console.WriteLine("culture: "+Thread.CurrentThread.CurrentCulture);
          ////Console.WriteLine("ui:      " + Thread.CurrentThread.CurrentUICulture);
         }
    }
}
