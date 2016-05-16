using System.IO;
using Xamarin.Forms;
using BoxOfWishes.Droid;
using BoxOfWishes.Data;

[assembly: Dependency(typeof(SQLite_Android))]

namespace BoxOfWishes.Droid
{
    public class SQLite_Android : ISQLite
    {
        public SQLite_Android()
        {
        }

        #region ISQLite implementation

        public SQLite.Net.SQLiteConnection GetConnection()
        {
            var fileName = "WishBoxData.db3";
            var documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentsPath, fileName);

            var platform = new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid();
            var connection = new SQLite.Net.SQLiteConnection(platform, path);

            return connection;
        }

        #endregion
    }
}