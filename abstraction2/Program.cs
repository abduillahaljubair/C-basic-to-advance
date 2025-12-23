namespace abstraction2
{
    public abstract class Shape
    {
        public abstract double printShape();
        public double dim2;
        public double dim1;
        public Shape(double dim1, double dim2)
        {
            this.dim1 = dim1;
            this.dim2 = dim2;
        }




    }
    public class Rectangle : Shape
    {
        public Rectangle(double dim1, double dim2) : base(dim1, dim2)
        {
        }

        public override double printShape()
        {
            return dim1 * dim2;
        }
    }


    public class circle : Shape
    {
        public double radius;
        public circle(double radius) : base(radius,radius)
        {
            //dim2 is used for radius in circle
        }
        public override double printShape()
        {
            return Math.PI * dim1 * dim2; //using dim2 as radius
        }
    }


    public class Triangle : Shape
    {
        public Triangle(double dim1, double dim2) : base(dim1, dim2)
        {

        }

        public override double printShape()
        {
           return 0.5* dim1 * dim2; //dim1 is base and dim2 is height   
        }
    }

    public class test
    {
        static void Main(string[] args)
        {
            Shape s;
            s = new Rectangle(3.5, 7.8);
            Console.WriteLine("Area of Rectangle: " + s.printShape());
            circle c = new circle(7.0);
            Console.WriteLine("Area of Circle: " + c.printShape());

        }
    }



}
