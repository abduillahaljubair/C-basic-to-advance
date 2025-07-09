namespace classandobj
{
    public class Program
    {
        public int age;
        public string name;
        public int number;


       public Program()
        {

        }

        //method with no parameters
        public void print()
        {
            Console.WriteLine("Name :" + name);
            Console.WriteLine("Age:" + age);
            Console.WriteLine("Number:" + number);

        }

        //method with parameters
        public void print1(string name,int age,int number)
        {
           Console.WriteLine("Name :" + name); 
           Console.WriteLine("Age:" + age);
           Console.WriteLine("Number:" + number);
        }

        //method with parameters and different order
        public void Print3(int s,string m,int l)
        {
            name = m;
            age = l;
            number = s;
        }
      

    }
    public class  person
    {
        public string address;
        public string dept;
        public string bloodgroup;

        // Constructor with parameters
        public person(string a,string d,string b)
        {
            address = a;
            dept = d;
            bloodgroup = b;
        }

        // Default constructor
        public person()
        {

        }

        // Constructor with two parameters
        public person(string address,string dept)
        {
            this.address = address;
            this.dept = dept;
        }


        public void print2()
        {
            Console.WriteLine("name of add : " + address + " dept :  " + " blood: ");
        }

        public static void Main(String[] args)
        {
            Program p1 = new Program();
            p1.age = 25;
            p1.name = "alvi";
            p1.number = 1234567890;
            p1.print();//method call kortesi


            Program p3 = new Program();


            

            person p2 = new person();
            p2.address= "123 Main St";
            Console.WriteLine("Name: "+p1.name+" Age: "+p1.age+" Number: "+p1.number);
            Console.WriteLine("Person Details:");
            Console.WriteLine("Address: " + p2.address); 


            //method call kortesi
            p3.print1("alic", 24, 124534890);


            Program p4 = new Program();



            // method call kortesi
            p4.Print3(1234567890, "alvi", 25);
            Console.WriteLine("Name: " + p4.name + " Age: " + p4.age + " Number: " + p4.number);

          


        }
    }


   /* public class EntryPoint
    {
      public  static void Main(String[] args)
        {


            Console.WriteLine("Constructor Example :   ");

            person person1 = new person("133 street ","cse","A+");//constractor use korlam
            person1.print2();

            person person2 = new person();
            person2.print2();

            person person3 = new person("456 avenue ", "CSE");
            person3.print2();
        }
    }*/
}
//ekti class er obj baniye onno class ee use korlam 
//same class er obj same class ee us korlam