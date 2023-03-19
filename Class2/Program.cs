using Cars;
using test;

namespace Class2
{
    public class Program : Car
    {
        static void Main(string[] args)
        {
            var child = new ElectricCar() ;
            var parent = new Car() ;
            var list = new List<Car>() ;
            var animal = new Animal() ;
            animal.AnimalSound();
            //list.Add(child) ;
            //child.DisplayIntroOfGame();
            //parent.DisplayIntroOfGame();
        }

        void Something()
        {
            var parent = new Car() ;
            parent.DisplayIntroOfGame();
            DisplayIntroOfGame();
        }
    }
}