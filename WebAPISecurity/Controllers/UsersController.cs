using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebAPISecurity.Model;
using WebAPISecurity.Services;

namespace WebAPISecurity.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private UserManager<IdentityUser> userManager;
        private JwtService jwtService;

        public UsersController(UserManager<IdentityUser> userManager,JwtService jwt)
        {
            this.userManager = userManager;
            this.jwtService = jwt;
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

        [HttpGet]
        public async Task<ActionResult<User>> ReadUser(string username)
        {

            IdentityUser user = await userManager.FindByNameAsync( username);
            if (user!=null)
            {
                User objUser = new User();
                objUser.UserName = user.UserName;
                objUser.Email = user.Email;
                return objUser;
            }
            else
            {
                return NotFound();
            }

        }

        

        [HttpPost("BearerToken")]
        public async Task<ActionResult<AuthenticationResponse>> CreateBearerToken (AuthenticationRequest authenticationRequest)
        {
            IdentityUser user = await userManager.FindByNameAsync(authenticationRequest.UserName);
            bool IsPasswordValid = await userManager.CheckPasswordAsync(user, authenticationRequest.Password);
            if(!IsPasswordValid)
            {
                return BadRequest("Wrong Password");
            }
            var token = jwtService.CreateToken(user);
            return Ok(token);
        }
        

    }
}
