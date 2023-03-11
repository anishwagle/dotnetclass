// Assignment 1 from first class
// Bot reply
namespace class1
{
    internal class program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter the Capital city of Nepal: ");
            var user1 = Console.ReadLine();
            Console.WriteLine($"The Capital City of Nepal is: {user1} \n");

            Console.WriteLine("What is the Size of Nepal: ");
            var area = int.Parse(Console.ReadLine());  //147,181km^2
            Console.WriteLine($"The Area of Nepal is: {area} KM^2 \n");

            Console.WriteLine("Enter three Religion that follows in Nepal: ");
            string input = Console.ReadLine();
            string[] religions = input.Split(' ');
            Console.WriteLine($"The three main religions that follows in Nepal are:");
            foreach (string religion in religions)
            {
                Console.WriteLine(religion);
            }
        }
    }
}
