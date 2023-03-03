namespace Class2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string,bool, int, float, list, dic,char
            var list = new List<string>() { "krishna","radha"};
            var dic = new Dictionary<string, int>();
            dic["age"] = 20;
            //Console.Write("x:");
            //var x = Console.ReadLine();
            //Console.Write("y:");
            //var y =Console.ReadLine();
            //var z = x.ToString();
            var name3 = $"{dic["Husband"]} and {dic["Wife"]} are husband and wife";
            Console.WriteLine(name3);
            Console.WriteLine(" Ram and sam");

        }
    }
}