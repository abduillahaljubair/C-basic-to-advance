namespace privatesupercontractor
{
    public class box
    {
        private double width;
        private double height;
        private double depth;


        public box(box ob)
        {
            width = ob.width;
            height = ob.height;
            depth = ob.depth;
        }

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

        public double volume()
        {
            return width * height * depth;
        }


    }

    public class boxweight : box
    {
        public double weight;


        public boxweight(boxweight ob): base(ob)
        {
            weight = ob.weight;
        }

    }
}
