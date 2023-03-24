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

            var isAppRunning = true;
            Console.WriteLine("Welcome To Our Contact Management Software");
            SeedData();
            while (isAppRunning)
            {

                Options();
                var input = Console.ReadLine();
                switch (input)
                {
                    case "5":
                        Console.Write("Search:");
                        var searchParam = Console.ReadLine();
                        var searchResult = _userInfoService.Search(searchParam);
                        ListAllContacts(searchResult);
                        break;
                    case "4":
                        var userInfos3 = _userInfoService.GetAllUserInfo();
                        ListAllContacts(userInfos3);
                        Console.Write("ID:");
                        var updateId = Console.ReadLine();
                        while (String.IsNullOrEmpty(updateId))
                        {
                            Console.WriteLine("Id Cannot Be null");
                            Console.Write("ID:");
                            updateId = Console.ReadLine();
                        }
                        var updateIsSuccess = Guid.TryParse(updateId, out Guid updateGuid);
                        if (updateIsSuccess) { 
                        
                            var getByIdResponse = _userInfoService.GetUserInfoById(updateGuid);
                            if(getByIdResponse == null) {
                                Console.WriteLine("UserNotFound");
                            }
                            else
                            {
                                Console.Write("Phone:");
                                var phone  = Console.ReadLine();
                                while (String.IsNullOrEmpty(phone))
                                {
                                    Console.WriteLine("PhoneNumber Cannot Be null");
                                    Console.Write("PhoneNumber:");
                                    phone = Console.ReadLine();
                                }
                                var res = _userInfoService.UpdatePhone(updateGuid,  phone);
                                Console.WriteLine(res);
                            }
                        }
                        else
                        {
                            Console.WriteLine("You Entered Invalid Id");
                        }
                        break;
                    case "3":
                        var userInfos1 = _userInfoService.GetAllUserInfo();
                        ListAllContacts(userInfos1);
                        Console.Write("Plese Enter The ID Of Contact you want to Delete:");
                        var id = Console.ReadLine();
                        while (String.IsNullOrEmpty(id))
                        {
                            Console.WriteLine("Id Cannot Be null");
                            Console.Write("ID:");
                            id = Console.ReadLine();
                        }
                        var isSuccess = Guid.TryParse(id, out Guid result);
                        if (isSuccess)
                        {
                            var res = _userInfoService.DeleteUserInfo(result);
                            Console.WriteLine(res);
                        }
                        else { 
                            Console.WriteLine("You Entered Invalid Id"); 
                        }
                        break;
                    case "2":
                        var userInfos = _userInfoService.GetAllUserInfo();
                        ListAllContacts(userInfos);
                        break;
                    case "1":
                        var userinfo = new UserInfoModel();
                        userinfo.Id = Guid.NewGuid();
                        Console.Write("FirstName:");
                        userinfo.FirstName = Console.ReadLine();
                        while (String.IsNullOrEmpty(userinfo.FirstName))
                        {
                            Console.WriteLine("FirstName Cannot Be null");
                            Console.Write("FirstName:");
                            userinfo.FirstName = Console.ReadLine();
                        }
                        Console.Write("MiddleName:");
                        userinfo.MiddleName = Console.ReadLine();
                        Console.Write("LastName:");
                        userinfo.LastName = Console.ReadLine();
                        while (String.IsNullOrEmpty(userinfo.LastName))
                        {
                            Console.WriteLine("LastName Cannot Be null");
                            Console.Write("LastName:");
                            userinfo.LastName = Console.ReadLine();
                        }
                        Console.Write("Email:");
                        userinfo.Email = Console.ReadLine();
                        while (String.IsNullOrEmpty(userinfo.Email))
                        {
                            Console.WriteLine("Email Cannot Be null");
                            Console.Write("Email:");
                            userinfo.Email = Console.ReadLine();
                        }
                        Console.Write("Phone:");
                        userinfo.PhoneNumber = Console.ReadLine();
                        while (String.IsNullOrEmpty(userinfo.PhoneNumber))
                        {
                            Console.WriteLine("PhoneNumber Cannot Be null");
                            Console.Write("PhoneNumber:");
                            userinfo.PhoneNumber = Console.ReadLine();
                        }
                        var response = _userInfoService.AddUserInfo(userinfo);
                        Console.WriteLine(response);
                        break;
                    case "0":
                        isAppRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please Enter Valid Option");
                        break;
                }

            }

        }
        public void ListAllContacts(List<UserInfoModel> userInfos)
        {
            
            foreach (var item in userInfos)
            {
                Console.WriteLine($"ID:{item.Id}");
                Console.WriteLine($"FirstName:{item.FirstName}");
                Console.WriteLine($"MiddleName:{item.MiddleName}");
                Console.WriteLine($"LastName:{item.LastName}");
                Console.WriteLine($"Email:{item.Email}");
                Console.WriteLine($"Phone:{item.PhoneNumber}");
                Console.WriteLine("--------------------------------------------");
            }
        }
        public static void Options()
        {
            Console.WriteLine("Please Choose Your Option:");
            Console.WriteLine("1.Add Contact");
            Console.WriteLine("2.Get All Contact");
            Console.WriteLine("3.Delete Contact");
            Console.WriteLine("4.Update Phone Number");
            Console.WriteLine("5.Search");
            Console.WriteLine("0.Exit");
        }
        public void SeedData()
        {
            for(var i = 0; i < 10; i++)
            {
                var user = new UserInfoModel()
                {
                    Id = Guid.NewGuid(),
                    FirstName = $"{i}First",
                    MiddleName = $"{i}MiddleName",
                    LastName = $"{i}LastName",
                    Email = $"{i}Email",
                    PhoneNumber = $"{i}111111",

                };
                var response = _userInfoService.AddUserInfo(user);
            }
        }
    }
}
