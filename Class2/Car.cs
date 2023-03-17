using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
  
    public class Car
    {
       
        public string Name { get; set; }
        public string Color { get; set; }

        public Car() {
            Console.WriteLine("Init");
        }
        public Car(string name) {
            Console.WriteLine("Init param");
            Name = name;
            Color = "REd";
        }

        public void SetName(string name)
        {
            Name= name;
        }
        public string GetName()
        {
            Console.WriteLine("GetName");
            return Name;
        }
        public static void DisplayIntroOfGame()
        {
            Console.WriteLine("Welcome To Our Car Game");
        }
    }
}
namespace test
{
    public class Car
    {

    }
}