using System.Xml.Linq;

namespace inheritance1
{
    public class student
    {
        string name;
        int age;

        public student()
        {

        }
        public student(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void display()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
        }

    }

    public class teacher : student
    {
        string qualification;
        public teacher()
        {

        }

        public teacher(string name, int age, string qualification)
        {
            this.name = name; // Assuming 'name' is accessible, otherwise use a property or protected field
            this.qualification = qualification;
        }
        public void display2()
        {
            display();
            Console.WriteLine("Qualification: " + qualification);
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            student s = new student("John", 20);
            s.display();
            teacher t = new teacher("Alice", 30, "PhD");
            t.display2();
        }
    }
}
