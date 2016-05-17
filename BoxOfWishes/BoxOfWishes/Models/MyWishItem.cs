using SQLite.Net.Attributes;

namespace BoxOfWishes.Models
{
    /// <summary>
    /// Notepad for my Wish Item that put into WishList.
    /// The user chooces this List to request for a List.
    /// </summary>
    public class MyWishItem
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string ItemName { get; set; }
        public string Description { get; set; }
        public string Tips { get; set; }
        public double Value { get; set; }
    }
}
