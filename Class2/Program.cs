namespace Class2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program lets you enter 6 numbers and \n" +
                "provides you with pair of numbers that is equal to the sum of your choice.\n");
            var nums = new List<int>();
            int numSum;
            bool pairs = false;

            for (int l = 0; l < 6; l++)
            {
                Console.WriteLine("Please enter number" + (l + 1) + " and press enter:");
                nums.Add(Convert.ToInt32(Console.ReadLine()));

            }

            Console.WriteLine("Now enter the Sum:");
            numSum = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i < 6; i++)
            {

                for (int j = i + 1; j < 6; j++)
                {
                    if (nums[i] + nums[j] == numSum)
                    {
                        Console.WriteLine("[" + nums[j] + ", " + nums[i] + "]");
                        pairs = true;
                    }
                }
            }
            if (!pairs)
            {
                Console.WriteLine("No pairs found.");
            }

        }
    }
}