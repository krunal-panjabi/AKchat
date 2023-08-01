using dataRepository.Interface;
using Microsoft.AspNetCore.Mvc;

namespace AKchat.Areas.user.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class UserController : Controller
    {

        private readonly IUserRepository _userrepo;
        private readonly IConfiguration _configuration;
        public UserController(IUserRepository userrepo, IConfiguration configuration)
        {
            _userrepo = userrepo;
            _configuration = configuration;

        }









        /*  [HttpPost]*/
        /*    public IActionResult Register(CompanyRegisterVm model)//company register
            {
                var i = _userrepo.registerrepo(model);
                if (i > 0)
                {
                    return Ok();
                }
                else
                {
                    return Content("false");
                }


            }*/
        [HttpPost("CheckForName")]
        public IActionResult CheckForName([FromBody] string name)
        {
            var i = _userrepo.checkforname(name);
            if(i==0)
            {
                return Ok(false);
            }
            else
            {
                return Ok(true);
            }
        }
    }
}
