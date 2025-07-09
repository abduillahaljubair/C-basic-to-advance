namespace person
{
    public class person
    {
        public string address;
        public string dept;
        public string bloodgroup;

        // Constructor with parameters
        public person(string a, string d, string b)
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
        public person(string address, string dept)
        {
            this.address = address;
            this.dept = dept;
        }


        public void print2()
        {
            Console.WriteLine("name of add : " + address + " dept :  " +dept+ " blood: "+bloodgroup);
        }
        
    }

    public class EntryPoint
    {
        public static void Main(String[] args)
        {


            Console.WriteLine("Constructor Example :   ");

            person person1 = new person("133 street ", "cse", "A+");//constractor use korlam
            person1.print2();

            person person2 = new person();
            person2.print2();

            person person3 = new person("456 avenue ", "CSE");
            person3.print2();
        }
    }
}
//ekti class er obj baniye onno class ee use korlam 
//same class er obj same class ee us korlam

