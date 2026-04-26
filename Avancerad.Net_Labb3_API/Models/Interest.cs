namespace Avancerad.Net_Labb3_API.Models
{
    public class Interest
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = string.Empty;

        public ICollection<Link> Links { get; set; } = new List<Link>();
    }
}
