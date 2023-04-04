using EcommAPI.Model;

namespace EcommAPI.Service.Image
{
    public interface IImageService
    {
        ResponseModel SaveImage(IFormFile file, string filePath);
    }
}
