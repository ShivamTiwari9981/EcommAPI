using EcommAPI.Model;

namespace EcommAPI.Service.Category
{
    public interface ICategoryService
    {
        ResponseModel AddCategory(CategoryModel category);
        ResponseModel GetAllCategory();
        ResponseModel PlaceOrder(int userId);
    }
}
