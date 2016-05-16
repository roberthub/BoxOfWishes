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
            var lang = Thread.CurrentThread.CurrentUICulture.Name;
            var culture = Thread.CurrentThread.CurrentCulture.Name;
            
        
            return lang;
        }


        public void SetLocale()
        {
           
            //System.Globalization.CultureInfo ci;
            //try
            //{
            //    ci = new System.Globalization.CultureInfo(netLocale);
            //}
            //catch
            //{
            //    ci = new System.Globalization.CultureInfo(GetCurrentCultureInfo());
            //}
            Console.WriteLine("culture: "+Thread.CurrentThread.CurrentCulture);
            Console.WriteLine("ui:      " + Thread.CurrentThread.CurrentUICulture);
            //Thread.CurrentThread.CurrentCulture = ci;
            //Thread.CurrentThread.CurrentUICulture = ci;
        }
    }
}
