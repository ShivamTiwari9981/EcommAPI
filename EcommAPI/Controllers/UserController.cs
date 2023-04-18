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
        private IWebHostEnvironment Environment;
        public UserController()
        {
            _userService = new UserService();
        }
        //public UserController(IWebHostEnvironment _environment)
        //{
        //    Environment = _environment;
        //}
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

        [Route("add")]
        [HttpPost]
        public ActionResult AddUser([FromForm]UserModel model)
        {
            try
            {
                ResponseModel responseModel=new ResponseModel ();
                 responseModel = _userService.Register(model);
                return Ok(responseModel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
    }
}
