using Class2.Interfaces;
using Class2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class2.Services
{
    public class UserInfoService : IUserInfo
    {
        public List<UserInfoModel> UserInfo { get; set; }
        public UserInfoService()
        {
            UserInfo = new List<UserInfoModel>();

        }
        public string AddUserInfo(UserInfoModel userInfoModel)
        {
            UserInfo.Add(userInfoModel);
            return "\nUser has been added successfully";
        }

        public List<UserInfoModel> ListUserInfo()
        {
           return UserInfo;
        }

        public UserInfoModel GetEmployeeInfoById(Guid id)
        {
            return UserInfo.FirstOrDefault(x => x.Id == id);
        }

        public string DeleteEmployeeById(Guid Id)
        {
            var item = GetEmployeeInfoById(Id);

            if (item != null)
            {
                return "Employee with that Id does not exist. Please try again.";
            }
            else
            {
                UserInfo.Remove(item);
                return ("The employee with Id" + item + " has been deleted.");
            }
        }

        public string UpdateUserInfo(UserInfoModel userInfoModel)
        {
            UserInfo.Add(userInfoModel);
            return "\nUser has been added successfully";
        }
    }
}
