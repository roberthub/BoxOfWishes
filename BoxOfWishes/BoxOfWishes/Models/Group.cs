using System;
using SQLite.Net.Attributes;

namespace BoxOfWishes.Models
{
    public class Group
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string BOWGroupId { get; set; } // Strong unique Universál Group key! e.g GUID
        public string GroupName { get; set; }
        public int GroupAdminId { get; set; } // Foreign Key from Member Table:Id
        public string Description { get; set; }
       public DateTime CreatedOn { get; set; }

       }
}
