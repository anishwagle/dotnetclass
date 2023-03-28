using Class2.Interfaces;
using Class2.Models;
using Class2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
                    userInfo.Email = Console.ReadLine();

                    while (String.IsNullOrEmpty(userInfo.Email))
                    {
                        Console.WriteLine("\nInvalid Entry. Please try again.\n");
                        Console.Write("Please enter the Email Id: ");
                        userInfo.Email = Console.ReadLine();
                    }

                    Console.Write("Please enter the phone number: ");
                    userInfo.PhoneNumber = Console.ReadLine();

                    while (String.IsNullOrEmpty(userInfo.PhoneNumber))
                    {
                        Console.WriteLine("\nInvalid Entry. Please try again.\n");
                        Console.Write("Please enter the phone number: ");
                        userInfo.PhoneNumber = Console.ReadLine();
                    }

                    var response = _userInfoService.AddUserInfo(userInfo);
                    Console.WriteLine(response);

                    continue;
                }

                if (input == "2")
                {
                    ListAllEmployees();
                    break;
                }

                if ( input == "3")
                {
                    ListAllEmployees();
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
                        _userInfoService.DeleteEmployeeById(result);
                        Console.WriteLine("Employee has been deleted successfully.");
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid Entry. Please try again.\n");
                    }
                    

                    break;
                }

                if (input == "4")
                {
                    ListAllEmployees();
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
                        var userInfo = _userInfoService.GetEmployeeInfoById(result);
                        _userInfoService.DeleteEmployeeById(result);
                        Console.WriteLine("Employee's information has been updated successfully.");
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid Entry. Please try again.\n");
                    }


                    break;
                }
                
                if(input == "0")
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
            Console.WriteLine("0. Exit");
        }
        
        public void ListAllEmployees()
        {
            var response = _userInfoService.ListUserInfo();

            foreach (var item in response)
            {
                Console.WriteLine($"ID: {item.Id}");
                Console.WriteLine($"First Name: {item.FirstName}");
                Console.WriteLine($"Middle Name: {item.MiddleName}");
                Console.WriteLine($"Last Name: {item.LastName}");
                Console.WriteLine($"Email Id: {item.Email}");
                Console.WriteLine($"Phone Number: {item.PhoneNumber}");
                Console.WriteLine("***************************************************************");
            }
        }
    }
}
