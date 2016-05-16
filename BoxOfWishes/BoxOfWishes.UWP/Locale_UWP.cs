using Xamarin.Forms;
using System.Threading;
using BoxOfWishes.Localization;

[assembly: Dependency(typeof(BoxOfWishes.Locale_UWP))]

namespace BoxOfWishes
{
    public class Locale_UWP : ILocalize
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
           
            //System.Globalization.CultureInfo ci;
            //try
            //{
            //    ci = new System.Globalization.CultureInfo(netLocale);
            //}
            //catch
            //{
            //    ci = new System.Globalization.CultureInfo(GetCurrentCultureInfo());
            //}
            Console.WriteLine("culture: "+ System.Globalization.CultureInfo.CurrentCulture.Name);
            Console.WriteLine("ui:      " + System.Globalization.CultureInfo.CurrentUICulture.Name);
            //Thread.CurrentThread.CurrentCulture = ci;
            //Thread.CurrentThread.CurrentUICulture = ci;
            
        }
    }
}
