using System.Security.Cryptography.X509Certificates;

namespace Avancerad.Net_Labb3_API.Models
{
    public class Link
    {
        public int Id { get; set; }

        public string Url { get; set; } = string.Empty;

        public User Users { get; set; } = null!;
        public int UserId { get; set; }

        public Interest Interest { get; set; } = null!;
        public int InterestId { get; set; }
    }
}

