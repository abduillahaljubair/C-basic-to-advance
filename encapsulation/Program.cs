using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;

namespace encapsulation
{
    //encapsulation is protecte,grouping data and methods together
    public class Program
    {
        //encapsulated variable of data
        private string name;//not readable and writeable outside the class

        //encapsulated method of data
        private void  Display1()
        {
            Console.WriteLine(+name);
            Console.WriteLine(age);
        }
        public  int age; //readable and writeable
       
        public void setName(string name)
        {
            this.name = name;
        }
        public string getname()
        {
            return name;
        }
        
        public void display()
        {
            Console.WriteLine("name= "+name);
            Console.WriteLine("age = "+age);
        }
    }
    public class test
    {
         public static void Main(string[] args)
        {
            Program p = new Program();
            p.age = 25; //accessible
            //p.name = "JUb"; //not accessible, as it is private
            //ACCESSABLE BY THE PUBLIC METHOD
            p.setName("john doe"); //accessible
            p.display();
            //p.display1(); //not accessible, as it is private
        }
    }
}
