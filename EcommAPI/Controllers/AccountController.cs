using DotNetOpenAuth.AspNet.Clients;
using EcommAPI.Model;
using EcommAPI.Service;
using EcommAPI.Service.Category;
using EcommAPI.Service.Image;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static DotNetOpenAuth.OpenId.Extensions.AttributeExchange.WellKnownAttributes.Contact;
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
            try
            {
                ResponseModel responseModel = _userService.Login(model);
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

