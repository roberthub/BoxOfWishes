using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Runtime.CompilerServices;
using System.Threading;
using Xamarin.Forms;
using BoxOfWishes.Localization;

[assembly: Dependency(typeof(BoxOfWishes.Locale_WinPhone))]

namespace BoxOfWishes
{
    public class Locale_WinPhone : ILocalize
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
            Console.WriteLine("culture: "+Thread.CurrentThread.CurrentCulture);
            Console.WriteLine("ui:      " + Thread.CurrentThread.CurrentUICulture);
            //Thread.CurrentThread.CurrentCulture = ci;
            //Thread.CurrentThread.CurrentUICulture = ci;
            
        }
    }
}
