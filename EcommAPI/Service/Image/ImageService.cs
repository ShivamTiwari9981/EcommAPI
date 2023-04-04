using EcommAPI.Model;
using EcommAPI.UnitOfWork;

namespace EcommAPI.Service.Image
{
    public class ImageService: IImageService
    {
        private IWebHostEnvironment Environment;
        public ImageService(IWebHostEnvironment _environment)
        {
            Environment = _environment;
        }
        public ResponseModel SaveImage(IFormFile file, string filePath)
        {
            ResponseModel response = new ResponseModel();
            if (file != null)
            {
                if (file.Length > 0)
                {
                    //Getting FileName
                    var fileName = Path.GetFileName(file.FileName);

                    //Assigning Unique Filename (Guid)
                    var myUniqueFileName = Convert.ToString(Guid.NewGuid());

                    //Getting file Extension
                    var fileExtension = Path.GetExtension(fileName);

                    // concatenating  FileName + FileExtension
                    var newFileName = String.Concat(myUniqueFileName, fileExtension);

                    string contentPath = this.Environment.ContentRootPath;
                    string filepath = Path.Combine(contentPath, filePath);
                    if (!Directory.Exists(filepath))
                    {
                        Directory.CreateDirectory(filepath);
                    }

                    // Combines two strings into a path.
                    var combineFilePath = filepath + newFileName;
                    using (FileStream fs = System.IO.File.Create(combineFilePath))
                    {
                        file.CopyTo(fs);
                        fs.Flush();
                        response.Status = true;
                        response.Message = "Created Successfull";
                    }
                }
            }
            return response;
        }
    }
}
