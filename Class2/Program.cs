namespace Class2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //list
            List<string> list1 = new List<string>() { "apple","banana","cat","bat","bay"};
            var list2 = new List<string>() { "e", "f", "g","f","f" };
            list1.Add("d");
            list1.AddRange(list2);
            int[] x = { 1, 2, 3, 4, 5, 6, };
            var listx = x.ToList();
            var arrayx = x.ToArray();
            list1.Remove("d");
            list1.RemoveAt(0);
            list1.RemoveRange(0, 2);
            list1.RemoveAll(x => x == "f");
            Console.WriteLine(list1[2]);
            var result = list1.Where(x => x.StartsWith("ba") || x.Contains("t")).ToList();
            var result2 = list1.FirstOrDefault(x=>x.StartsWith("z"));
            var startsWithZ = list1.Any(x => x.Contains("a"));
            //var list3= list1.Union(list2);
            var result3 =  list1.Take(2);
            var result4 = list1.OrderBy(x=>x).ToList();
            var result5 = list1.OrderByDescending(x=>x).ToList();
            //var list4 = list1.Intersect(list2);

            //foreach
            foreach (var item in list1)
            {
                if (item.StartsWith("ba"))
                {
                    //result.Add(item);
                }
                Console.WriteLine(item);
            }

            //for loop
            //for (var i = 0; i <= list1.Count; i++)
            //{
            //    Console.WriteLine(list1[i]);
            //}
        }
    }
}