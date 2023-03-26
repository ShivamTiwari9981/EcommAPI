using EcommAPI.Model;

namespace EcommAPI.Service
{
    public interface IUserService
    {
        int Login(LoginModel model);
        ResponseModel Register(UserModel model);
        ResponseModel ViewUser(int userId);
        ResponseModel UserList();
    }
}
