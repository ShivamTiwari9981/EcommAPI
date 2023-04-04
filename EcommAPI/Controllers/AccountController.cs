using EcommAPI.Model;
using EcommAPI.Service;
using EcommAPI.Service.Category;
using EcommAPI.Service.Image;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EcommAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IUserService _userService;
        public AccountController(IImageService ImageService)
        {
            _userService = new UserService();
        }

        [Route("login")]
        [HttpPost]
        public ActionResult Index(LoginModel model)
        {
            try
            {
                ResponseModel responseModel = new ResponseModel();
                int err_no = _userService.Login(model);
                if (err_no == 0)
                {
                    responseModel.Status = true;
                    responseModel.Message = "Login Successfull";
                }
                else
                {
                    responseModel.Status = false;
                    responseModel.Message = "Login failed";
                }
                return Ok(responseModel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [Route("signup")]
        [HttpPost]
        public ActionResult SignUp(UserModel model)
        {
            try
            {
                ResponseModel responseModel = _userService.Register(model);
                return Ok(responseModel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
