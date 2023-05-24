using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebAPISecurity.Model;

namespace WebAPISecurity.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private UserManager<IdentityUser> userManager;

        public UsersController(UserManager<IdentityUser> userManager)
        {
            this.userManager = userManager;
        }

        [HttpPost]
        public async Task<ActionResult<User>> PostUser(User user)
        {
           
            IdentityUser objUser = new IdentityUser();
            objUser.UserName = user.UserName;
            objUser.Email = user.Email;

            var result = await userManager.CreateAsync(objUser,user.Password);
            if(result.Succeeded)
            {
                return Created("",user);
             }
            else
            {
                return BadRequest(result.Errors);
            }

        }
    }
}
