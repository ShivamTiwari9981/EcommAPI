using EcommAPI.Model;
using EcommAPI.Service;
using EcommAPI.Service.Category;
using EcommAPI.Service.Image;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Web;
using System.Net;

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
        public ActionResult Login(LoginModel model)
        {
            ResponseModel responseModel=new ResponseModel();
            try
            {
                responseModel = _userService.Login(model);
            }
            catch (Exception ex)
            {
                responseModel.status = false;
                responseModel.message = ex.Message;
            }
            return Ok(responseModel);
        }
        [Route("signup")]
        [HttpPost]
        public ActionResult SignUp(UserModel model)
        {
            ResponseModel responseModel = new ResponseModel();
            try
            {
                responseModel = _userService.Register(model);
                
            }
            catch (Exception ex)
            {
                responseModel.status = false;
                responseModel.message = ex.Message;
            }
            return Ok(responseModel);
        }
       
    }
}

