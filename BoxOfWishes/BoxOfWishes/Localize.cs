using System;
using System.Reflection;
using System.Diagnostics;
using System.Resources;
using System.Threading;
using System.Globalization;
using Xamarin.Forms;

namespace BoxOfWishes.Localization
{
	public class Localize 
	{
		static readonly CultureInfo ci;

		static  Localize () 
		{
			ci = DependencyService.Get<ILocalize>().GetCurrentCultureInfo ();
		}

		public static string GetString(string key, string comment)
		{
			ResourceManager temp = new ResourceManager ("BoxOfWishes.Localization.AppResources", typeof(Localize).GetTypeInfo ().Assembly);

			string result = temp.GetString (key, ci);

			return result; 
		}
	}
}

