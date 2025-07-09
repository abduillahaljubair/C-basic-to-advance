using System.Security.Cryptography;

namespace GetterSetterandobjectasparameter
{
    public class Program
    {
       private string name;
       private int age;
        public int width;
        public int height;
        public int area;

        public Program(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public Program(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public Program()
        {

        }
        public void print()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
        }
        public void setNameAge(String name,int age)
        {
            this.name = name;
            if(age>=18)
            {
                this.age = 18;
            }
            else
            { 
                this.age = age;
            }  
        }
        public string getName()
        {
            return name;
        }
        public int getAge()
        {
            return age;
        }


        //object as parameter
        public void objpassing(Program P)
        {
            if(this.width*this.height==P.width*P.height)
            {
                Console.WriteLine("Both objects have same area");
            }
            else
            {
               P.area = P.width * P.height;
               this.area = this.width * this.height;
            }
        }

        //return object 
        public Program mixProgram(Program tulip)
        {
            Program mixedtulip = new Program();
            mixedtulip.age = this.age + tulip.age / 2;
            mixedtulip.name = "Yellow tulip";
            return mixedtulip;
        }
        //return object with 2 parameter
        public Program mixProgram2(Program tuilip1,Program tuilip2)
        {
            Program p1 = new Program();
            p1.name=this.name+" "+tuilip1.name+" "+tuilip2.name;
            p1.age = this.age + tuilip1.age + tuilip2.age / 3;
            return p1;
        }


    }
    public class getter
    {
       public static void Main(string[] args)
        {
            //creating object and passing by the getter setter
            Program p = new Program();
            p.setNameAge("john", 12);
            Console.WriteLine("Name: " + p.getName());
            Console.WriteLine("age:" + p.getAge());

            //creating object using constructor

            Program p1 = new Program("jubair",23);//chaile initialize korar por oo get method call korte pari
            Console.WriteLine("Name: " + p1.getName());
            Console.WriteLine("Age: " + p1.getAge());//initialize tumi jevabe koro na keno(by objct ba by set) tomar get method call korte hobe 



            //creating object using constructor
            Program t1 = new Program(10, 20);
            Program t2 = new Program(30, 40);


            //passing objects as parameters
            t1.objpassing(t2);


            Console.WriteLine("area:" + (double)t1.area);//type casting
            Console.WriteLine("area:" + t2.area);


            Program redtulip=new Program("red", 25);
            Program blueTulip = new Program("Blue ", 30);
            Program greenTuilip = new Program("green", 40);
            Console.WriteLine("Red Tulup Details:");
            Console.WriteLine("Name: " + redtulip.getName());
            Console.WriteLine("Age: " + redtulip.getAge());
            Console.WriteLine("Blue Tulup Details:");
            Console.WriteLine("Name: " + blueTulip.getName());
            Console.WriteLine("Age: " + blueTulip.getAge());

            //passing object as parameter retrun mixtulip
            Program mixedtulip = new Program();
            mixedtulip = redtulip.mixProgram(blueTulip);
            Console.WriteLine("Mixed Tulip Details:");
            Console.WriteLine("Name: " + mixedtulip.getName());
            Console.WriteLine("Age: " + mixedtulip.getAge());

            //passing 2 object as parameter
            Program mixedtuilip2= new Program();
            mixedtuilip2=redtulip.mixProgram2(blueTulip, greenTuilip);
            Console.WriteLine("after 2 object as parameter Details:");
            Console.WriteLine(mixedtuilip2.getName());
            Console.WriteLine(mixedtuilip2.getAge());


        }
    }
}
