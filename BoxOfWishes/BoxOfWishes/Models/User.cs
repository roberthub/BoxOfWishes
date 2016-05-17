using System;
using SQLite.Net.Attributes;

namespace BoxOfWishes.Models
{
    public enum USER_STATUS
    {
        U_ACTIVE,
        U_INACTIVE,
        U_DELETED,
        U_BLOCKED
    };
    public class User :IBOWItem
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string FirstName { get; set; } // optional
        public string Lastname { get; set; }  // optional
        public string Name { get; set; }
        public string Email {get;set;}
        public string Password { get; set; }
        public string Telephone { get; set; } //auto filled. 
        public string BirthDay { get; set; } // optional
        public DateTime DateOfBirth { get; set; } // optional
        public string Address { get; set; } // optional .. weglassen
        public string City { get; set; }  // optional
        public string Country { get; set; } // optional
        public USER_STATUS status { get; set; }

        public string GetTableName() { return "Event"; }

        public int GetPrimaryKey() { return Id; }
    }
}
