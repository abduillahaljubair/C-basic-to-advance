namespace ConsoleApp1
{
    public interface a1
    {
        public string a1 { get; set; }
        public int age { get; set; }
        public void display();
        public abstract string show();

    }
    public class a2 : a1
    {
        public string a1 { get; set; }
        public int age { get; set; }
        public void display()
        {
            Console.WriteLine($"Name: {a1}, Age: {age}");
        }
        public string show()
        {
            return $"Show Method - Name: {a1}, Age: {age}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
