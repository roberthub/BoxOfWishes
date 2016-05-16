using SQLite.Net.Attributes;

namespace BoxOfWishes.Models
{
    public class MyWishItem
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string ItemName { get; set; }
        public string Description { get; set; }
        public double Value { get; set; }
    }
}
