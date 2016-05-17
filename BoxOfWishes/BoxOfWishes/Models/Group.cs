using System;
using SQLite.Net.Attributes;

namespace BoxOfWishes.Models
{
    public enum GROUP_STATUS
    {
        GS_ACTIVE,
        GS_INACTIVE,
        GS_DELETED,
        GS_BLOCKED
    };

    public class Group
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string BOWGroupId { get; set; } // Strong unique Universál Group key! e.g GUID
        public string GroupName { get; set; }
        public int GroupAdminId { get; set; } // Foreign Key from Member Table:Id
        public string Description { get; set; }
        public DateTime CreatedOn { get; set; }
        public GROUP_STATUS status { get; set; }
    }
}
