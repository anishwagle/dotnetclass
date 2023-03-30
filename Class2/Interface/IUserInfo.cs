using Class2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class2.Interface
{
    public interface IUserInfo
    {
        public string AddUserInfo(UserInfoModel userInfoModel);
        public List<UserInfoModel> ListUserInfo();

        public UserInfoModel GetEmployeeInfoById(Guid id);

        public string DeleteEmployeeById(Guid Id);
        public string UpdateFirstName(Guid Id, string firstName);
        public string UpdateMiddleName (Guid Id, string middleName);
        public string UpdateLastName (Guid Id, string lastName);
        public string UpdatePhoneNumber (Guid Id, string phoneNumber);
        public string UpdateEmailId (Guid Id, string emailId);
        public List<UserInfoModel> Search(string query);

    }
}
