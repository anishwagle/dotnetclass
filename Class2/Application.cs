using Class2.Interface;
using Class2.Models;
using Class2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Class2
{
    public class Application
    {
        private readonly IUserInfo _userInfoService;
        public Application(IUserInfo userInfoService)
        {
            _userInfoService = userInfoService;

        }
        public void Main()
        {
            var isAppRunning = true;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Welcome To Employee Management Portal.");
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("This app will help you to add, delete, update and view the list of our employees.");
            Console.ResetColor();
            Console.WriteLine("\n\n\n");

            SeedData();

            while (isAppRunning)
            {
                Options();

                var input = Console.ReadLine();

                if (input == "1")
                {
                    var userInfo = new UserInfoModel();
                    userInfo.Id = Guid.NewGuid();

                    Console.Write("Please enter the first name: ");
                    userInfo.FirstName = Console.ReadLine();

                    while (String.IsNullOrEmpty(userInfo.FirstName))
                    {
                        Console.WriteLine("\nInvalid Entry. Please try again.\n");
                        Console.Write("Please enter the first name: ");
                        userInfo.FirstName = Console.ReadLine();
                    }

                    Console.Write("Please enter the middle name: ");
                    userInfo.MiddleName = Console.ReadLine();

                    Console.Write("Please enter the last name: ");
                    userInfo.LastName = Console.ReadLine();

                    while (String.IsNullOrEmpty(userInfo.LastName))
                    {
                        Console.WriteLine("\nInvalid Entry. Please try again.\n");
                        Console.Write("Please enter the last name: ");
                        userInfo.LastName = Console.ReadLine();
                    }

                    Console.Write("Please enter the Email: ");
                    string email = Console.ReadLine();
                    userInfo.Email = email;

                    while (!IsValidEmail(email))
                    {
                        Console.WriteLine("\nInvalid Entry. Please try again.\n");
                        Console.Write("Please enter the Email Id: ");
                        email = Console.ReadLine();
                        userInfo.Email = email;
                    }

                    Console.Write("Please enter the phone number: ");
                    var phoneNumber = Console.ReadLine();
                    userInfo.PhoneNumber = phoneNumber;

                    while (!IsValidPhoneNumber(phoneNumber))
                    {
                        Console.WriteLine("\nInvalid Entry. Please try again.\n");
                        Console.Write("Please enter the phone number: ");
                        phoneNumber = Console.ReadLine();
                        userInfo.PhoneNumber = phoneNumber;
                    }

                    var response = _userInfoService.AddUserInfo(userInfo);
                    Console.WriteLine(response);

                    continue;
                }

                if (input == "2")
                {
                    var userInfos = _userInfoService.ListUserInfo();
                    ListAllEmployees(userInfos);
                    continue;
                }

                if (input == "3")
                {
                    var userInfos = _userInfoService.ListUserInfo();
                    ListAllEmployees(userInfos);
                    Console.WriteLine("Please enter the Id you wish to delete from the list.");
                    var id = Console.ReadLine();

                    while (String.IsNullOrEmpty(id))
                    {
                        Console.WriteLine("\nInvalid Entry. Please try again.\n");
                        Console.Write("Please enter the Id you wish to delete from the list: ");
                        id = Console.ReadLine();
                    }
                    var isSuccess = Guid.TryParse(id, out Guid result);

                    if (isSuccess)
                    {
                         var response = _userInfoService.DeleteEmployeeById(result);
                        Console.WriteLine(response);
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid Entry. Please try again.\n");
                        continue;
                    }

                }

                if (input == "4")
                {
                    var userInfos = _userInfoService.ListUserInfo();
                    ListAllEmployees(userInfos);
                    Console.WriteLine("Please enter the Id you wish to update from the list.");
                    var id = Console.ReadLine();

                    while (String.IsNullOrEmpty(id))
                    {
                        Console.WriteLine("\nInvalid Entry. Please try again.\n");
                        Console.Write("Please enter the Id you wish to update from the list: ");
                        id = Console.ReadLine();
                      
                    }
                    var isSuccess = Guid.TryParse(id, out Guid result);
                    if (isSuccess)
                    {
                        Console.WriteLine("PLease choose the field you wish to update.");
                        Console.WriteLine("1. First Name");
                        Console.WriteLine("2. MiddleName");
                        Console.WriteLine("3. Last Name");
                        Console.WriteLine("4. Email Id");
                        Console.WriteLine("5. Phone Number");
                        Console.WriteLine("0. Exit");

                        var userInput = Console.ReadLine();
                        var userInfo = _userInfoService.GetEmployeeInfoById(result);
                        if (userInfo == null)
                        {
                            Console.WriteLine("\nEmployee not found.");
                        }
                        else if(userInput == "1")
                        {
                            Console.Write("First Name: ");
                            var firstName = Console.ReadLine();
                            while (String.IsNullOrEmpty(firstName))
                            {
                                Console.WriteLine("\nInvalid Entry. Please try again.\n");
                                Console.Write("First name: ");
                                firstName = Console.ReadLine();
                            }
                            var response = _userInfoService.UpdateFirstName(result, firstName);
                            Console.WriteLine(response);
                            continue;
                          
                        }
                        else if (userInput == "2")
                        {
                            Console.Write("Middle Name: ");
                            var middleName = Console.ReadLine();

                            var response = _userInfoService.UpdateMiddleName(result, middleName);
                            Console.WriteLine(response);
                            continue;
                        }
                        else if (userInput == "3")
                        {
                            Console.Write("Last Name: ");
                            var lastName = Console.ReadLine();
                            while (String.IsNullOrEmpty(lastName))
                            {
                                Console.WriteLine("\nInvalid Entry. Please try again.\n");
                                Console.Write("Last name: ");
                                lastName = Console.ReadLine();
                            }
                            var response = _userInfoService.UpdateLastName(result, lastName);
                            Console.WriteLine(response);
                            continue;
                        }
                        else if (userInput == "4")
                        {
                            Console.Write("Email Id: ");
                            var email = Console.ReadLine();
                            while (!IsValidEmail(email))
                            {
                                Console.WriteLine("\nInvalid Entry. Please try again.\n");
                                Console.Write("Please enter the Email Id: ");
                                email = Console.ReadLine();
                            }
                            var response = _userInfoService.UpdateEmailId(result, email);
                            Console.WriteLine(response);
                            continue;
                        }
                        else if (userInput == "5")
                        {
                            Console.Write("Phone Number: ");
                            var phoneNumber = Console.ReadLine();
                            while (!IsValidPhoneNumber(phoneNumber))
                            {
                                Console.WriteLine("\nInvalid Entry. Please try again.\n");
                                Console.Write("Phone Number: ");
                                phoneNumber = Console.ReadLine();
                            }
                            var response = _userInfoService.UpdatePhoneNumber(result, phoneNumber);
                            Console.WriteLine(response);
                            continue;
                        }
                        else if (userInput == "0") 
                        {
                            continue; 
                        }
                        else
                        {
                            Console.WriteLine("You have entered an invalid option. Please try again.\n");
                            break;
                        }
                    }
                }

                if (input == "5")
                {
                    Console.WriteLine("Please enter the Id of an employee you wish to view.");
                    var id = Console.ReadLine();

                    while (String.IsNullOrEmpty(id))
                    {
                        Console.WriteLine("\nInvalid Entry. Please try again.\n");
                        Console.Write("Please enter the Id of an employee you wish to view.");
                        id = Console.ReadLine();
                    }
                    
                    var isSuccess = Guid.TryParse(id, out Guid result);
                    if (isSuccess)
                    {
                        var userInfo = _userInfoService.GetEmployeeInfoById(result);
                        if (userInfo == null)
                        {
                            Console.WriteLine("\nEmployee not found.");
                            continue;
                        }
                        else
                        {
                            DisplayItem(userInfo);
                            continue;
                        }
                        
                    }

                    else
                    {
                        Console.WriteLine("\nInvalid Entry. Please try again.\n");
                        continue;
                    }
                       
                }

                if (input == "6")
                {
                    Console.Write("Please enter Email or Phone Number to search the employee: ");
                    var response = Console.ReadLine();
                    var result = _userInfoService.Search(response);
                    ListAllEmployees(result);
                    continue;
                }

                if (input == "0")
                {
                    isAppRunning = false;
                    break;
                }
                else
                {
                    Console.WriteLine("You have entered an invalid option. Please try again.\n");
                    continue;
                }

            }


        }

        public void Options()
        {
            Console.WriteLine("Please choose from following options.\n");
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. List all Employees");
            Console.WriteLine("3. Delete Employee from the list");
            Console.WriteLine("4. Update Employee's Information");
            Console.WriteLine("5. List Employees By ID");
            Console.WriteLine("6. Search Employees by Email Or Phone Number");
            Console.WriteLine("0. Exit");
        }

        public void ListAllEmployees(List<UserInfoModel> userInfos)
        {

            foreach (var item in userInfos)
            {
                DisplayItem(item);
            }
        }

        void DisplayItem(UserInfoModel item)
        {
            Console.WriteLine($"ID: {item.Id}");
            Console.WriteLine($"First Name: {item.FirstName}");
            Console.WriteLine($"Middle Name: {item.MiddleName}");
            Console.WriteLine($"Last Name: {item.LastName}");
            Console.WriteLine($"Email Id: {item.Email}");
            Console.WriteLine($"Phone Number: {item.PhoneNumber}");
            Console.WriteLine("***************************************************************");
        }

        public void SeedData()
        {
            for (var i = 0; i < 10; i++)
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
        public static bool IsValidEmail(string email)
        {
            string pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            Regex regex = new Regex(pattern);

            return regex.IsMatch(email);
        }
        public static bool IsValidPhoneNumber(string phoneNumber)
        {
            string pattern = @"^\d{10}$";
            Regex regex = new Regex(pattern);

            return regex.IsMatch(phoneNumber);
        }
    }
}
