using Identity.Aplication.User;
using Microsoft.AspNetCore.Mvc;

namespace Identity.Controllers.User
{
    [ApiController]
    [Route("api/v1/user")]
    public class UserController : ControllerBase
    {
        private readonly IAplicUser _aplicUser;

        public UserController(IAplicUser aplicUser) 
        {
            _aplicUser = aplicUser;
        }
    }
}
