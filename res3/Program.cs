using System.Collections.Specialized;

namespace res3
{


    public abstract class Com1
    {
        public string name;
        public int age;

       public Com1(string name,int age)
        {
            this.name = name;
            this.age = age;
        }
        public abstract void display();
    }
    public class b1 : Com1
    {
        public int phn;
        public b1(string a ,int b,int phn):base(a,b)
        {
            this.phn = phn;
        }
        public override void display()
        {
            Console.WriteLine("the details:"+name+" "+age+" "+phn);
        }
    }

    public class b2 : b1
    {
        public int gen;
        public b2(string a,int b,int c,int d):base(a,b,c)
        {
            this.gen = d;
        }
        public override void display()
        {
            Console.WriteLine(name+age+phn+gen);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            b2 obj1 = new b2("jub", 13, 019, 2);
            obj1.display();
            b1 obj2 = new b1("jb", 12, 908);
            obj2.display();
            Com1 obj=new b2("jub",123,098,2);
            obj.display();
            Com1 ob2 = new b1("alh", 23, 2333);
            ob2.display();
        }
    }
}
