namespace _2.inheritancebasis
{
    public class A
    {
        public int i,j;
       
        public void showij()
        {
            Console.WriteLine("i and j :"+i+" "+j);
        }
    }

    public class  B:A
    {
        public int k;
        public void showk()
        {
            Console.WriteLine("k: " + k);
        }
        public void sum()
        {
            Console.WriteLine("i+j+k: " + (i + j + k));
        }
    }
}
