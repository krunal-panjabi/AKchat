using Microsoft.AspNetCore.Mvc;

namespace AKchat.Areas.user.Controllers
{
    [ApiController]

    public class UserController : Controller
    {

        private readonly IUserRepository _userrepo;
        private readonly IConfiguration _configuration;
        //public string connectionstring = "Server=server=192.168.2.59\\SQL2019;Database=RestaurantPOS;User Id=sa;Password=Tatva@123;Encrypt=False";
        public UserController(IUserRepository userrepo, IConfiguration configuration)
        {
            _userrepo = userrepo;
            _configuration = configuration;

        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
