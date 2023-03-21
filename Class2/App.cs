using Class2.Models;
using Class2.Services;
using Class2.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class2
{
    public class App
    {
        private readonly IUserInfoService _userInfoService;

        public App(IUserInfoService userInfoService)
        {
            _userInfoService = userInfoService;
        }
        public void Main()
        {
            var userinfo = new UserInfoService();
            var response = _userInfoService.AddUserInfo(new UserInfoModel());
            Console.WriteLine(response);
        }
    }
}
