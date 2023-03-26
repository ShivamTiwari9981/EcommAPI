using EcommAPI.Model;
using EcommAPI.Service.Category;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EcommAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        public CategoryController()
        {
            _categoryService=new CategoryService();
        }
        //public CategoryController(ICategoryService categoryService)
        //{
        //    this._categoryService = categoryService;
        //}

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
        public ActionResult Category(CategoryModel model)
        {
            try
            {
                ResponseModel responseModel=_categoryService.AddCategory(model);
                return Ok(responseModel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
