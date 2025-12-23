using System.Formats.Asn1;

namespace restart2
{

    public class box
    {
        public int length;
        public int height;
        public int depth;

        public box(box ob)
        {
            length = ob.length;
            height = ob.height;
            depth = ob.depth;
        }

        public box(int length, int height, int depth)
        {
            this.length = length;
            this.height = height;
            this.depth = depth;

        }
        public box()
        {
            length = -1;
            height = -1;
            depth = -1;
        }
        public int Volume()
        {
            return length * height * depth;
        }
        public void area()
        {
            int area1 = 2 * (length * height + height * depth + depth * length);
            Console.WriteLine("the arae is "+area1);
        }
    }
    public class boxWeight:box
    {
        int weight;
        public boxWeight(int a,int b,int c,int d):base(a,b,c)
        {
            weight = d;
        }
        public int Volume()
        {
            return height * weight*depth*length;
        }
        public void area()
        {
            int see=height*depth*weight;
            Console.WriteLine("this is the area="+see);
        }

    }
    public class Program
    {
         public static void Main(string[] args)
        {
            box b1 = new box(10,10,10);
            int vol = b1.Volume();
            Console.WriteLine(vol);
            b1.area();

            boxWeight b2=new boxWeight(10,10,10,10);
            vol = b2.Volume();
            Console.WriteLine(vol);
            b2.area();

        }
    }
}
