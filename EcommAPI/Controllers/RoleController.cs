using EcommAPI.Model;
using EcommAPI.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EcommAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IUserService _userService;
        public RoleController()
        {
            _userService = new UserService();
        }

        [Route("getRole")]
        [HttpGet]
        public ActionResult GetAllRole()
        {
            try
            {
                ResponseModel responseModel = _userService.GetAllRole();
                return Ok(responseModel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [Route("add")]
        [HttpPost]
        public ActionResult AddUser([FromBody] RoleModel model)
        {
            ResponseModel responseModel = new ResponseModel();
            try
            {
                responseModel = _userService.AddRole(model);
                return Ok(responseModel);
            }
            catch (Exception ex)
            {
                responseModel.message = ex.Message;
                responseModel.status = false;
                return Ok(responseModel);
            }
        }
    }
}
