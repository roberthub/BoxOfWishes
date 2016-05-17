using System;
using SQLite.Net.Attributes;

namespace BoxOfWishes.Models
{
    /// <summary>
    /// Events should our default wish catecogry. It is the 5th.
    /// It notifies members automatically wish reminders!
    /// </summary>
    public class Event : IBOWItem
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string EventName { get; set; }
        public int EventInitiatorID { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Description { get; set; }
        public double frequency { get; set; }

        public string GetTableName() { return "Event"; }

        public int GetPrimaryKey() { return Id; }
    }
}
