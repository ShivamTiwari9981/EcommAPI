using EcommAPI.Model;
using EcommAPI.Service.Category;
using EcommAPI.Service.Image;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EcommAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly IImageService _ImageService;
        public CategoryController(IImageService ImageService)
        {
            _categoryService=new CategoryService();
            _ImageService=ImageService;
        }

        [Route("getAllCategory")]
        [HttpGet]
        public ActionResult Index()
        {
            try
            {
                ResponseModel responseModel = _categoryService.GetAllCategory();
                return Ok(responseModel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [Route("category")]
        [HttpPost]
        public ActionResult Category([FromForm]CategoryModel model)
        {
            try
            {
                ResponseModel responseModel=_categoryService.AddCategory(model);
                if(responseModel.Status)
                {
                    responseModel= _ImageService.SaveImage(model.ImageFile, model.ImageUrl);
                }
                return Ok(responseModel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



    }
}
