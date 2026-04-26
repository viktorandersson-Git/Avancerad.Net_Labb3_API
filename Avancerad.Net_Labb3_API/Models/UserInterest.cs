namespace Avancerad.Net_Labb3_API.Models
{
    public class UserInterest
    {
        public int Id { get; set; }

        public User Users { get; set; } = null!;
        public int UserId { get; set; }
        public Interest Interests { get; set; } = null!;
        public int InterestId { get; set; }

        public ICollection<Link> Links { get; set; } = new List<Link>();



    }
}
