using System;
using SQLite.Net.Attributes;

namespace BoxOfWishes.Models
{
    public class WishCategory : IBOWItem
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [MaxLength(120)]
        public string Name { get; set; }
        [MaxLength(250)]
        public string Description { get; set; }
        public string Value { get; set; }
        public bool active { get; set; }
        public DateTime ValidUntil { get; set; }

        public string GetTableName() { return "WishCategory"; }

        public int GetPrimaryKey() { return Id; }
    }
}
