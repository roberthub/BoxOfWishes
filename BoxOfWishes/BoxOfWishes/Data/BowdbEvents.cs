using System.Collections.Generic;
using System.Linq;

using BoxOfWishes.Models;

namespace BoxOfWishes.Data
{
    public partial class BOWDatabase
    {
        public IEnumerable<Event> GetEvents()
        {
            return (from t in _connection.Table<Event>()
                    select t).ToList();
        }


        public Event GetEvent(int id)
        {
            return _connection.Table<Event>().FirstOrDefault(t => t.Id == id);
        }

        public void DeleteEvent(int id)
        {
            _connection.Delete<Event>(id);
        }

        public int SaveEvent(Event _event )
        {

            lock (locker)
            {
                if (_event.Id != 0)
                {
                    _connection.Update(_event);
                    return _event.Id;
                }
                else
                {
                    return _connection.Insert(_event);
                }
            }
        }
    }
}
