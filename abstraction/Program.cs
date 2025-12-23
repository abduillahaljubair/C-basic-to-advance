namespace abstraction
{
     public abstract class Program
    {
        //declare abstract method
        abstract public void display();
        //concrete method 
        public void show()
        {
            Console.WriteLine("This is a concrete method in an abstract class.");
        }

    }

    public class  A : Program
    {
        //implement the abstract method from the abstract class and upadate the concrete method
        public override void display()
        {
            Console.WriteLine("A class display method");
        }
    }
    public class  B: Program
    {
        //implement the abstract method from the abstract class and upadate the concrete method
        public override void display()
        {
            Console.WriteLine("B is the override class ");
        }
    }

    public class test {

        static void Main(string[] args)
        {
            //abtract class has not any object to create
            Program p;//reference type variable
            p = new A();
            p.display(); // A class display method
            B b = new B();
            b.display();
            p.show();
            b.show();
            

        }

    }


}
