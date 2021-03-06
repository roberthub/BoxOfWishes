using System;
using Xamarin.Forms;
using System.Threading;
using System.Globalization;
using BoxOfWishes.Localization;

[assembly:Dependency(typeof(BoxOfWishes.Locale_Android))]

namespace BoxOfWishes
{
	public class Locale_Android : ILocalize
	{
		public void SetLocale (){

			var androidLocale = Java.Util.Locale.Default; // user's preferred locale
			var netLocale = androidLocale.ToString().Replace ("_", "-"); 
			var ci = new System.Globalization.CultureInfo (netLocale);
			Thread.CurrentThread.CurrentCulture = ci;
			Thread.CurrentThread.CurrentUICulture = ci;
		}

		/// <remarks>
		/// Not sure if we can cache this info rather than querying every time
		/// </remarks>
		public CultureInfo GetCurrentCultureInfo() 
		{
			var androidLocale = Java.Util.Locale.Default; // user's preferred locale

			// en, es, ja
			//var netLanguage = androidLocale.Language.Replace ("_", "-"); 
			// en-US, es-ES, ja-JP
			var netLocale = androidLocale.ToString().Replace ("_", "-"); 

			#region Debugging output
			Console.WriteLine ("android:  " + androidLocale.ToString());
		//	Console.WriteLine ("netlang:  " + netLanguage);
			Console.WriteLine ("netlocale:" + netLocale);

			var ci = new System.Globalization.CultureInfo (netLocale);
			Thread.CurrentThread.CurrentCulture = ci;
			Thread.CurrentThread.CurrentUICulture = ci;

			Console.WriteLine ("thread:  "+Thread.CurrentThread.CurrentCulture);
			Console.WriteLine ("threadui:"+Thread.CurrentThread.CurrentUICulture);
            #endregion

            return new System.Globalization.CultureInfo(netLocale);
		}
	}
}

