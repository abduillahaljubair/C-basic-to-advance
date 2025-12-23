namespace labques
{
    public class Program
    {
       public static void matrix()

        {
            int m;
            int n;
            m = int.Parse(Console.ReadLine());
            n= int.Parse(Console.ReadLine());
            double[,] a = new double[m,n];
            if(m!=n)
            {
                Console.WriteLine("Invalid Input (should be a square matrix)\r\n");

                return;
            }
            for(int i=0;i<m;i++)
            {
                for(int j=0;j<n;j++)
                {
                    Console.WriteLine("write " + i+j+"index :");
                    a[i, j] = double.Parse(Console.ReadLine());
                }
                
            }
            int sum = 0;

            for (int i = 0; i <m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("" +a[i,j]+" ");
                    if(i == j)
                    {
                        sum += (int)a[i, j];
                    }
                }
                Console.WriteLine();
            }
            //traverse matrix and 2d dimentional mirror 
            
            double[,] b= new double[m,n];

            int f = m-1;
            for (int i = 0; i < m; i++)
            {
                
                int k = m-1;
                for (int j = 0; j < n; j++)
                {
                    b[i, j] = a[f,k];
                     
                    
                    k--;

                   
                }
                f--;
                
            }


            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("" + b[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("the traverse matrix is "+sum);


        }
    }
}
