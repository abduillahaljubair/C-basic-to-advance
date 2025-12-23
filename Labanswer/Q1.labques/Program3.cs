using System;

namespace Q3.LIST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> l = new List<string>();
            l.Add("Bangladesh");
            l.Add("India");
            l.Add("Bhutan");
            l.Add("Rajshahi");
            l.Add("Sylhet");
            l.Add("Japan");
            foreach(var item in l)
            {
                Console.WriteLine(item);
            }
            l.Remove("Rajshahi");
            l.Remove("Sylhet");
            foreach (var item in l)
            {
                Console.WriteLine(item);
            }
            List<string> l2 = new List<string>() { "Pakistan","India" ,"Nepal"};
            foreach (var item in l2)
            {
                Console.WriteLine(item);
            }
            l.InsertRange(0, l2);
            foreach (var item in l)
            {
                Console.WriteLine(item.ToLower());
            }






        }
    }
}
