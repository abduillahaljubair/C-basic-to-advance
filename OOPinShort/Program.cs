namespace OOPinShort
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*//this is single inheritance
            Animal mammal=new Animal();
            mammal.Name = "Tiger";
            mammal.Description = "it is so cruel animal";
            mammal.eat();*/
            /*//this is multilevel inheritance
            Animal1 dome =new Animal1();
            dome.Name = "cow";
            mammal1 f1 = new mammal1();
            f1.des(dome);*/

            rectangle p1= new rectangle();
            p1.draw();
            p1.des(p1);


        }
    }
}
