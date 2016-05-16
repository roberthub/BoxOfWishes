using System;
using SQLite.Net.Attributes;

namespace BoxOfWishes.Models
{
    public class User :IBOWItem
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string Name { get; set; }
        public string Email {get;set;}
        public string Telephone { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public string GetTableName() { return "Event"; }

        public int GetPrimaryKey() { return Id; }
    }
}
