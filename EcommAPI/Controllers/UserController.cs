using EcommAPI.Service.Image;
using EcommAPI.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EcommAPI.Model;

namespace EcommAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController()
        {
            _userService = new UserService();
        }
        [Route("getAll")]
        [HttpGet]
        public ActionResult GetAllUser()
        {
            try
            {
                ResponseModel responseModel = _userService.GetAllUser();
                return Ok(responseModel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
