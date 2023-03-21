using Class2.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class2.Services.Interfaces
{
    public interface IUserInfoService
    {
        public string AddUserInfo(UserInfoModel userInfoModel);
    }
}
