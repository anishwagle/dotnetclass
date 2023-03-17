using Cars;
using test;

namespace Class2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Cars.Car car1 = new Cars.Car("a") ;
            
          
            Console.WriteLine(car1.GetName());
        }
    }
}