using System;

namespace BoxOfWishes.Models
{

    public enum WISH_STATES
    {
        WS_FREE,
        WS_WISHEDBY,
        WS_WISHEDFROM,
        WS_PROMISEDTO,
        WS_PROMISEDBY,
        WS_HONOUREDBY,
        WS_HONOUREDTO,
        WS_BLOCKED,
        WS_ARCHIVED
    }

    public class Wish
    {
        public int WishID { get; set; }
        public string WishName { get; set; }
        public int CategoryId { get; set; }
        public string WishBox { get; set; }
        public string OfferedBy { get; set; }
        public string WishedBy { get; set; }
        public double WishValue { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime Expires { get; set; }
        public WISH_STATES state { get; set; }
    }
}
