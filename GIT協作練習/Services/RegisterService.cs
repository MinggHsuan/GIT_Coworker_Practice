using GIT協作練習.Models;
using GIT協作練習.Unility;

namespace GIT協作練習.Services
{
    public class RegisterService
    {
        public bool UserRegist(RegisterModel model)
        {
            UserModel userModel = new UserModel();
            userModel.Account = model.Account;
            userModel.Password = model.Password;
            return true;
        }
    }
}