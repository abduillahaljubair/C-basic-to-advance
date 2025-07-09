namespace ShapeDemo

{
    public class Circle
    {
        public double radius;
        public string color;

      public Circle()
        {

        }
      public Circle(double radius, String color)
        {
            this.radius = radius;
            this.color = color;
        }

       public double CalculateArea()
        {
           return Math.PI*radius*radius;
        }
    }

    public class ShapeDemo
    {
        public static void Main(String[] args)
        {
            Circle c1 = new Circle(12,"green");
            double p1=c1.CalculateArea();
            Console.WriteLine("Circle Area: " + p1);
            Console.WriteLine("circle color: " + c1.color);

            c1.color = "blue";
            Console.WriteLine("Updated Circle color: " + c1.color);


        }
    }

}
