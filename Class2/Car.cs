using Cars;
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
        protected int Speed;
        public Car() {
        }
        public Car(string name) {
            Name = name;
            Color = "REd";
        }

        
        public virtual void DisplayIntroOfGame()
        {
            Console.WriteLine("Parent");
        }
    }

}

namespace test
{
    public class ElectricCar : Car
    {
        public int Charge { get; set; }

        public override void DisplayIntroOfGame()
        {
            
            Console.WriteLine("Child");
        }
    }
}