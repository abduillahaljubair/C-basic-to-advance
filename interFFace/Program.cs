namespace public interface
    {


    // sob class abstract obostai thake 
    public interface Animal
    {
        public int age ;
        public int year;

        public abstract void makeSound();


    }
    public class  Dog:Animal
    {
        public int home;


        public override void makeSound()
        {
            Console.WriteLine("Dog barks");
        }
    }
    public class test
    {
       
        static void Main(string[] args)
        {
            Dog d=new Dog();
            d.makeSound(); // Dog barks
        }
    }
    
}
