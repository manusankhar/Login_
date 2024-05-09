using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using User_Profile.Models;

namespace User_Profile.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserProfileController : ControllerBase
    {
        [Authorize]
        [HttpPost]
        public string TitleMessage(User user)
        {
            return "Welcome " + user.UserName;
        }

        [Authorize]
        [HttpGet]
        public string WelcomeMessage()
        {
            return "Welcome to Authenticated API";
        }
    }
}
