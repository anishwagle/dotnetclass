namespace Class2
{
    internal class Program
    {
        //10=10*9*8*..*1
        static void Main(string[] args)
        {
            var n = 10;
            var factorial = 1;
            while (n > 0)
            {
                factorial *= n;
                n--;
            }
            Console.WriteLine(factorial);
            //Console.WriteLine(Factorial(10));


            int previousNo = 0;
            int currentNo = 1;
            int tem = 0;
            //0,1,1,2,3,5,8..
            //Console.WriteLine($"{previousNo}");
            //Console.WriteLine($"{currentNo}");
            for (int i = 2; i <= 10; i++)//O(N)
            {
                tem = currentNo + previousNo;
                previousNo = currentNo;
                currentNo = tem;

            }
            Console.WriteLine($"{currentNo}");

            //Console.WriteLine( Fib(10000));

        }


        //1*1*2*3*4*5*6*7*8*9*...
        public static double Factorial(int number)//10
        {
            if (number == 0)
                return 1;

            return number * Factorial(number-1); 
        }

        ////0,1,1,2,3,5,8..

        public static int Fib(int n)
        {

            if (n <= 1)
            {
                return n;
            }
            else
            {
                return Fib(n - 1) + Fib(n - 2);
            }
        }
    }
}