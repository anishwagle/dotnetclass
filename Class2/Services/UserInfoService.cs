using Class2.Models;
using Class2.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class2.Services
{
    public class UserInfoService : IUserInfoService
    {
        public List<UserInfoModel> UserInfos { get; set; }

        public UserInfoService() {
        UserInfos = new List<UserInfoModel>();
        }

        public string AddUserInfo(UserInfoModel userInfoModel)
        {
            UserInfos.Add(userInfoModel);
            return "Added Successfully";
        }

        public List<UserInfoModel> GetAllUserInfo()
        {
            return UserInfos;
        }
    }
}
