namespace Class2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //while,do while, for,foreach
            //var i = 0;
            //while(i<=10)
            //{
            //    i++;

            //    if (i==5)
            //    {
            //        break;
            //    }
            //   if(i==2)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine($"Hi{i}");

            //}
            //while(true) {
            //    Console.Write("x:");
            //    var x = Convert.ToInt32(Console.ReadLine());
            //    Console.Write("y:");
            //    var y = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Operations:+,-,*,/");
            //    Console.WriteLine("e to end");
            //    Console.Write("Operation:");
            //    var z = Console.ReadLine();

            //    switch(z)
            //    {
            //        case "+":
            //            Console.WriteLine($"{x+y}");
            //            break;
            //        case "-":
            //            Console.WriteLine($"{x - y}");
            //            break;
            //        case "*":
            //            Console.WriteLine($"{x * y}");
            //            break;
            //        case "/":
            //            Console.WriteLine($"{x / y}");
            //            break;
            //        default: 
            //            Console.WriteLine("Enter valid operatins");
            //            break;
            //    }
            //}

            //do while
            //var i = 10;
            //do {
            //    Console.WriteLine($"Hi{i}");
            //    i++;
            //} while (i<10);

            //for loop
            //for(var i = 0; i < 5; i++)
            //{

            //    for (var j = 0; j < 5; j++)
            //    {

            //        Console.WriteLine($"{i}_{j}");
            //    }
            //}
            
            for (var i =0; i< 10; i++)
            {
                for(var j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}