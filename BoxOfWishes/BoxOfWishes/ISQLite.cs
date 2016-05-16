using SQLite.Net;

namespace BoxOfWishes.Data
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
