using EcommAPI.Model;

namespace EcommAPI.Service
{
    public interface IUserService
    {
        ResponseModel Login(LoginModel model);
        ResponseModel Register(UserModel model);
        ResponseModel ViewUser(int userId);
        ResponseModel UserList();
    }
}
