namespace Class2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string,bool, int, float, list, dic,char
            var p = "sadfa";
            Console.Write("x:");
            var x =int.Parse( Console.ReadLine());
            Console.Write("y:");
            var y =Convert.ToInt32( Console.ReadLine());
            Console.Write("operation:");
            var operation = Console.ReadLine();

            if (operation == "/") // == != < > <= >=
            {
                if(x>y && y != 0) //&& - and , || or
                {
                    Console.WriteLine(x + y);
                }
                if (p == null) { }
                
            }
            else if (operation == "-") 
            {
                Console.WriteLine(x-y);
            }
            else
            {
                Console.WriteLine("no operation found");
            }

            switch(operation) {
                case "+":
                    if (x > y && y != 0) //&& - and , || or
                    {
                        Console.WriteLine(x + y);
                    }
                    if (p == null) { }
                    break;
                case "-":
                    Console.WriteLine(x - y);
                    break;
                default:
                    Console.WriteLine("no operation found");
                    break;
            }

         

        }
    }
}