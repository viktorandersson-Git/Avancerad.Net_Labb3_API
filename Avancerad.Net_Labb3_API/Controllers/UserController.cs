using Avancerad.Net_Labb3_API.DTOs;
using Avancerad.Net_Labb3_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Avancerad.Net_Labb3_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserDbcontext _ctx;

        public UserController(UserDbcontext ctx)
        {
            _ctx = ctx;
        }

        [HttpGet]
        public ActionResult<IEnumerable<GetAllUsersDto>> GetAllUsers()
        {
            var users = _ctx.Users
                .Select(u => new GetAllUsersDto
                {
                    Id = u.Id,
                    Name = u.Name
                })
                .ToList();

            return Ok(users);
        }

        [HttpGet("{userId}/interests")]
        public ActionResult<IEnumerable<GetUserIdInterestsDto>> GetUserIdInterests(int userId)
        {
            var userInterest = _ctx.UserInterests
                .Where(ui => ui.UserId == userId)
                .Select(ui => new GetUserIdInterestsDto
                {
                    Title = ui.Interests.Title,
                    Description = ui.Interests.Description
                })
                .ToList();

            return Ok(userInterest);
        }

        [HttpGet("{userId}/links")]
        public ActionResult<IEnumerable<GetUserIdLinksDto>> GetUserIdLinks(int userId)
        {
            var links = _ctx.Links
                .Where(l => l.UserId == userId)
                .Select(l => new GetUserIdLinksDto
                {
                    InterestTitle = l.Interest.Title,
                    Url = l.Url
                }).ToList();

            return Ok(links);
        }

        [HttpPost("add-interest")]
        public ActionResult AddInterestToUser(AddInterestToUserDto dto)
        {
            var alreadyExists = _ctx.UserInterests
                .Any(ui => ui.UserId == dto.UserId && ui.InterestId == dto.InterestId);

            if (alreadyExists)
            {
                return BadRequest("Denna användare har redan detta intresse.");
            }

            var newUserInterest = new UserInterest
            {
                UserId = dto.UserId,
                InterestId = dto.InterestId
            };

            _ctx.UserInterests.Add(newUserInterest);
            _ctx.SaveChanges();

            return Ok("Intresset har lagts till");
        }

        [HttpPost("add-link")]
        public IActionResult AddLinkToUser(AddLinkToUserDto dto)
        {
            //var interestExisist = _ctx.Interests
            var existinInterest = _ctx.UserInterests
                .Any(ui => ui.UserId == dto.UserId && ui.InterestId == dto.InterestId);
            if (!existinInterest)
            {
                return BadRequest("Användaren måste ha intresset för att lägga till en länk.");
            }

            var newLink = new Link
            {
                Url = dto.Url,
                UserId = dto.UserId,
                InterestId = dto.InterestId
            };

            _ctx.Links.Add(newLink);

            _ctx.SaveChanges();
            return Ok("Länken har sparats och kopplats till användarens intresse.");
        }

    }
}
