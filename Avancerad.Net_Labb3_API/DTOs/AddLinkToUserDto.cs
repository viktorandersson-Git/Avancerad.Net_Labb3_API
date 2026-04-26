namespace Avancerad.Net_Labb3_API.DTOs
{
    public class AddLinkToUserDto
    {
        public string Url { get; set; } = null!;

        public int UserId { get; set; }
        public int InterestId { get; set; }
    }
}
