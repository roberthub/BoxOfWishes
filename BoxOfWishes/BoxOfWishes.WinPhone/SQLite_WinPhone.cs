using System.IO;
using Xamarin.Forms;
using BoxOfWishes.Data;
using BoxOfWishes.WinPhone;

[assembly: Dependency(typeof(SQLite_WinPhone))]

namespace BoxOfWishes.WinPhone
{
    class SQLite_WinPhone : ISQLite
    {
        public SQLite_WinPhone()
        {
        }

        #region ISQLite implementation

        public SQLite.Net.SQLiteConnection GetConnection()
        {
            var fileName = "WishBoxData.db3";
            var path = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, fileName);

            var platform = new SQLite.Net.Platform.WindowsPhone8.SQLitePlatformWP8();
            var connection = new SQLite.Net.SQLiteConnection(platform, path);

            return connection;
        }

        #endregion
    }
}
