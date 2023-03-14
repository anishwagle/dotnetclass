namespace Class2
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
         var sum=   Add(5.5f,2.3f);
            Console.WriteLine(sum);
            
        }

        static void WelcomeMessage(string name="Hari" )
        {
            Console.WriteLine("Hello "+name);
            Console.WriteLine("Everything is great");
        }

        
        static int Add(int a,int b)
        {
            Console.WriteLine("function2");

            return a + b;
        }
        static float Add(float? a, float? b)
        {
            if(b== null)
            {
                b = 0;
            }
            Console.WriteLine("function1");

            return a.Value + b.Value;
        }
        
    }
}