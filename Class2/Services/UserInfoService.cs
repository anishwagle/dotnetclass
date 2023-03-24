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
        public string UpdatePhone(Guid Id, string phone)
        {
            var item = UserInfos.Find(x => x.Id == Id);
            item.PhoneNumber= phone;
            return "Updated Successfully";
        }
        public List<UserInfoModel> GetAllUserInfo()
        {
            return UserInfos;
        }

        public List<UserInfoModel> Search(string query)
        {
            var result = UserInfos.Where(x=>x.Email.ToLower().StartsWith(query.ToLower())||x.PhoneNumber.StartsWith(query)).ToList();
            return result;
        }
        public UserInfoModel GetUserInfoById(Guid id)
        {
            return UserInfos.FirstOrDefault(x => x.Id == id);
        }

        public string DeleteUserInfo(Guid Id)
        {
            var item = GetUserInfoById(Id);
            if(item == null)
            {
                return "Item Doesnot exist";
            }
            else
            {
                UserInfos.Remove(item);
                return "Item Deleted Successfully";
            }
        }
    }
}
