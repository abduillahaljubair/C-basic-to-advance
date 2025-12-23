namespace _3.publicconstractor
{
    public class box
    {
        //super class variables
        public double width;
        public double height;
        public double depth;


        public box(box ob)
        {
            width = ob.width;
            height = ob.height;
            depth = ob.depth;
        }
        //super class constructor
        public box(double w, double h, double d)
        {
            width = w;
            height = h;
            depth = d;
        }

        public box()
        {
            width = -1;
            height = -1;
            depth = -1;
        }

        public box(double len)
        {
            width = height = depth = len;
        }
        //super class method to calculate volume
        public double volume()
        {
            return width * height * depth;
        }


    }
    //inherit super class box
    public class boxWeight : box
    {
        public double weight;

        //superclass all variables are accessible
        public boxWeight(double w, double h, double d, double m) : base(w, h, d)
        {
        
            weight = m;
        }
        // Copy constructor and update the base class constructor
        public double volume()
        {
            return width * height * depth * weight ;
        }
    }
    public class  classdemo
        {
        static void Main(string[] args)
        {
          boxWeight box1 = new boxWeight(10, 20, 15, 34.3);
          boxWeight box2 = new boxWeight(2, 3, 4, 0.076);
            double vol;
            vol= box1.volume();
            Console.WriteLine("Volume of box1: " + vol);
            Console.WriteLine("Weight of box1: " + box1.weight);
            vol = box2.volume();
            Console.WriteLine("Volume of box2: " + vol);
            Console.WriteLine("Weight of box2: " + box2.weight);


          box plainbox= new box(box2);
         Console.WriteLine("Volume of plainbox: " + plainbox.volume());
         Console.WriteLine("height of plainbox: " + plainbox.height);
            Console.WriteLine("width of plainbox: " + plainbox.width);
            Console.WriteLine("depth of plainbox: " + plainbox.depth);


            plainbox = box1;// Using the copy constructor
            Console.WriteLine("plaibox volume : "+plainbox.volume());

        }
    }
}
