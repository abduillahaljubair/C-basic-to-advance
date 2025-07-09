using System.Xml.Serialization;

namespace statickeyword
{
    //static variables and methods and blocks
    public class student
    {
        string name;//instance variable
        int id;
        //static variable use korar jonno object bebohar korte hoina 
        public static string uniname = "AUST";//class variable ba static variable

        //non static hole prottecta variables er jonno object create korte hoy
        public int count = 0;
         static int count1 = 0;

        public student()
        {
            count++;
            count1++;
        }
        //non static method 
        public void displaycount()
        {
            Console.WriteLine("Total number of students: " + count);
        }
        //static method er jonno method er variable obosshoi static hotehobe
        public static void displaycount1()
        {    
            Console.WriteLine("Total number of students  ( static): " + count1);
        }

        public  student(string name, int id)
        {
            this.name = name;
            this.id = id;
        }

        public void display()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("ID: " + id);
            Console.WriteLine("University Name: " + uniname);
        }
    }

    public class  test
    {
       public  static void Main(string[] args)
        {
            student s1 = new student("Rift", 34);
            student s2 = new student("jubair", 23);
            s1.display();
            s2.display();
            //static hole object er name use na kore class er name use kora lage 
            Console.WriteLine("university name : "+ student.uniname);


            student t1= new student();
            t1.displaycount();
            student.displaycount1(); //static method call
            student t2 = new student();
            t2.displaycount();
            student.displaycount1(); //static method call
            student t3 = new student();
            t3.displaycount();
            student.displaycount1(); //static method call

        }
    }
}
