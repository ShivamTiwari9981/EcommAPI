using EcommAPI.Service.Image;
using EcommAPI.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EcommAPI.Service.Module;
using EcommAPI.Model;

namespace EcommAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModuleController : ControllerBase
    {
        private readonly IAppModuleService _moduleService;
        public ModuleController()
        {
            _moduleService = new AppModuleService();
        }
        [Route("modules")]
        [HttpGet]
        public ActionResult GetModule()
        {
            try
            {
                ResponseModel responseModel = _moduleService.GetAllModule();
                return Ok(responseModel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
