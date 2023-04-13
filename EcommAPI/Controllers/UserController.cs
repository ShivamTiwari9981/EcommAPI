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
        public UserController(IWebHostEnvironment _environment)
        {
            Environment = _environment;
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

        [Route("add")]
        [HttpPost]
        public ActionResult AddUser([FromForm]UserModel model)
        {
            try
            {
                ResponseModel responseModel=new ResponseModel ();
                //var res=SaveImage(model);
                if(true)
                {
                    responseModel = _userService.Register(model);
                }
                return Ok(responseModel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //private bool SaveImage(UserModel model)
        //{
        //    bool isSaved = false;
        //    if (model.ImageFile != null)
        //    {
        //        if (model.ImageFile.Length > 0)
        //        {
        //            //Getting FileName
        //            var fileName = Path.GetFileName(model.ImageFile.FileName);

        //            //Assigning Unique Filename (Guid)
        //            var myUniqueFileName = Convert.ToString(Guid.NewGuid());

        //            //Getting file Extension
        //            var fileExtension = Path.GetExtension(fileName);

        //            // concatenating  FileName + FileExtension
        //            var newFileName = String.Concat(myUniqueFileName, fileExtension);

        //            string contentPath = this.Environment.ContentRootPath;
        //            string filepath = Path.Combine(contentPath, "Image/uploads/");
        //            if (!Directory.Exists(filepath))
        //            {
        //                Directory.CreateDirectory(filepath);
        //            }

        //            // Combines two strings into a path.
        //            var combineFilePath = filepath + newFileName;
        //            using (FileStream fs = System.IO.File.Create(combineFilePath))
        //            {
        //                model.ImageFile.CopyTo(fs);
        //                fs.Flush();
        //                isSaved = true;
        //            }
        //        }
        //    }
        //    return isSaved;
        //}
    }
}
