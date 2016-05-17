namespace BoxOfWishes.Models
{
    public class Member
    {
        public int Id { get; set; } 
        public int UserID { get; set; }// UserId
        public string MemberName { get; set; }
        public int GroupId { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
    }
}
