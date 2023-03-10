namespace Class2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Dict
            var dic1 = new Dictionary<string, bool>();
            dic1["sun"] = false;
            dic1["mon"] = false;
            dic1["tue"] = false;
            dic1["wed"] = false;
            dic1["thr"] = false;
            dic1["fri"] = false;
            dic1["sat"] = true;

            //dic1.Remove("a");
            //dic1.Clear();
            //if (dic1.ContainsKey("a"))
            //{
            //    Console.WriteLine(dic1["a"]);

            //}
            var list = new List<string>();
            //foreach
            foreach (var item in dic1)
            {
                if(!item.Value) {
                    Console.WriteLine($"Its{item.Key} day,Go to work");

                }
                else
                {
                    Console.WriteLine("Its Holiday");
                }

            }

            
        }
    }
}