using System;
using System.Globalization;

namespace BoxOfWishes.Localization
{
    public interface ILocalize
	{
        CultureInfo GetCurrentCultureInfo();

		void SetLocale();
	}
}

