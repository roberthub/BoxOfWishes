using System.Collections.Generic;
using System.Linq;

using BoxOfWishes.Models;

namespace BoxOfWishes.Data
{
    public partial class BOWDatabase
    {

        public IEnumerable<Group> GetGroups()
        {
            lock (locker)
            {
                return (from t in _connection.Table<Group>()
                        select t).ToList();
            }
        }

        public Group GetGroup(int id)
        {
            lock (locker)
            {
                return _connection.Table<Group>().FirstOrDefault(t => t.Id == id);
            }
        }

        public int DeleteGroup(int id)
        {
            lock (locker)
            {
                return _connection.Delete<Group>(id);
            }
        }

        public int SaveGroup(Group group)
        {
            lock (locker)
            {
                if (group.Id != 0)
                {
                    _connection.Update(group);
                    return group.Id;
                }
                else
                {
                    return _connection.Insert(group);
                }
            }
        }
        public IEnumerable<Member> GetGroupMembers(int groupId)
        {
            return (from t in _connection.Table<Member>()
                    where t.GroupId == groupId
                    select t).ToList();
        }
    }
}
