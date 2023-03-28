using Class2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class2.Interfaces
{
    public interface IUserInfo
    {
        public string AddUserInfo(UserInfoModel userInfoModel);
        public List<UserInfoModel> ListUserInfo();

        public UserInfoModel GetEmployeeInfoById(Guid id);

        public string DeleteEmployeeById(Guid Id);
        public string UpdateUserInfo(UserInfoModel userInfoModel);
    }
}
