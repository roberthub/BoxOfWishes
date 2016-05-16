using SQLite.Net.Attributes;

namespace BoxOfWishes.Models
{
    public class WishBox
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string GroupName { get; set; }
        public int WishId{ get; set; }
    }
}
