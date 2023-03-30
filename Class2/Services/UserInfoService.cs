using Class2.Interface;
using Class2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

        public string DeleteEmployeeById(Guid Id)
        {
            var item = GetEmployeeInfoById(Id);

            if (item == null)
            {
                return "Employee with that Id does not exist. Please try again.";
            }
            else
            {
                UserInfo.Remove(item);
                return ("The employee with Id " + Id + " has been deleted.");
            }
        }

        public UserInfoModel GetEmployeeInfoById(Guid id)
        {
            return UserInfo.FirstOrDefault(x => x.Id == id);
        }

        public List<UserInfoModel> ListUserInfo()
        {
            return UserInfo;
        }

        public string UpdateFirstName(Guid Id, string firstName)
        {
            var item = UserInfo.Find(x => x.Id == Id);
            item.FirstName = firstName;
            return "First name updated successfully";
        }

        public string UpdateMiddleName(Guid Id, string middleName)
        {
            var item = UserInfo.Find(x => x.Id == Id);
            item.MiddleName = middleName;
            return "Middle name updated successfully";
        }

        public string UpdateLastName(Guid Id, string lastName)
        {
            var item = UserInfo.Find(x => x.Id == Id);
            item.LastName = lastName;
            return "Last name updated successfully";
        }

        public string UpdatePhoneNumber(Guid Id, string phoneNumber)
        {
            var item = UserInfo.Find(x => x.Id == Id);
            item.PhoneNumber = phoneNumber;
            return "Phone Number updated successfully";
        }

        public string UpdateEmailId(Guid Id, string emailId)
        {
            var item = UserInfo.Find(x => x.Id == Id);
            item.Email = emailId;
            return "Email updated successfully";
        }

        public List<UserInfoModel> Search(string query)
        {
            var result = UserInfo.Where(x=> x.Email.ToLower().StartsWith(query.ToLower()) || x.PhoneNumber.StartsWith(query)).ToList();
            return result;
        }
    }
}
