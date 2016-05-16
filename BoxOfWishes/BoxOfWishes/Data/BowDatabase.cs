using System;
using System.Collections.Generic;
using System.Linq;
using SQLite.Net;
using Xamarin.Forms;
using BoxOfWishes.Models;

namespace BoxOfWishes.Data
{

    public partial class BOWDatabase
    {
        private SQLiteConnection _connection;
        static object locker = new object();

        public BOWDatabase()
        {
            _connection = DependencyService.Get<ISQLite>().GetConnection();
            if(_connection != null)
            {
                CreateTables();
            }
            else
            {

            }
         }
        private bool CreateTables()
        {
            bool created = false;
            try
            {
                _connection.CreateTable<User>();
                _connection.CreateTable<WishCategory>();
                _connection.CreateTable<Group>();
                _connection.CreateTable<Member>();
                _connection.CreateTable<MyWishItem>();
                _connection.CreateTable<Wish>();
                _connection.CreateTable<WishBox>();
                _connection.CreateTable<MyWishList>();

                created = true;
            }
            catch (SQLite.Net.SQLiteException) { }
            return created;
        }
        public int SaveItem(IBOWItem item)
        {

            lock (locker)
            {
                if (item.GetPrimaryKey()!= 0)
                {
                    _connection.Update(item);
                    return item.GetPrimaryKey();
                }
                else
                {
                    return _connection.Insert(item);
                }
            }
        }
        public IEnumerable<IBOWItem> GetItems()
        {
            lock (locker)
            {
                return (from t in _connection.Table<IBOWItem>()
                        select t).ToList();
            }
        }
        public IBOWItem GetItem(int id)
        {
            lock (locker)
            {
                return _connection.Table<IBOWItem>().FirstOrDefault(t => t.GetPrimaryKey() == id);
            }
        }
        public int DeleteItem(int id)
        {
            lock (locker)
            {
              return  _connection.Delete<IBOWItem>(id);
            }
        }
    }
}
