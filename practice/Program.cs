using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int max = Int32.MaxValue;
            int min= Int32.MinValue;
            Console.WriteLine($"maX AND MIN VALUE ={max} and {min} ");

            int a = 19;

            Console.WriteLine($"int is converted to double: {(double)a:F3}");
            Console.WriteLine($"int is converted to float: {(float)a:F1}");
            Console.WriteLine("int to double is " + Convert.ToDouble(a));

            string str = "";
            if(String.IsNullOrWhiteSpace(str))
            {
                Console.WriteLine("String is empty");
            }
            else
            {
                Console.WriteLine("String is not empty");
            }

            //condition? value_if_true : value_if_false;
            str = "JUB";
            string name =String.IsNullOrWhiteSpace(str) ? "null/empty": str;
            Console.WriteLine($"the value is {name}");


            var number = new int[] { 1, 2, 3, 4, 5 };
            int sum = 0;
            foreach(var container in number)
            {
                sum+=container;
            }
            Console.WriteLine($"sum is {sum}");

            List<string> student = new List<string>();//list is created that can store string values
            student.Add("Jub");
            student.Add("Jubin");
            student.Add("Jubilee");
            student.Add("Jubilee Jubin");
            student.Add("Jubin");
            
            student.Remove("Jubin");

            Console.WriteLine("students are ");
            foreach(var con in student)
            {
                Console.WriteLine(con);
            }

            Stack<int> s=new Stack<int>();
            s.Push(1);
            s.Push(2);
            s.Push(3);

            Console.WriteLine("ALL STACK ELEMENT");
            foreach(var item in s)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Pop details : ");
            for(var i=0;i<=s.Count()+1;i++)
            {
                Console.WriteLine(s.Pop());
            }


            Queue<int> q = new Queue<int>();

            int limit = 5;  
            switch (limit)
            {
                case >=5:
                    Console.WriteLine($"limit is grater than{limit}");
                    break;

                case <5:
                    Console.WriteLine($"limit is less than {limit}");
                    break;

            }

            Console.WriteLine("write the number of array: ");
            int n = int.Parse(Console.ReadLine()); // or get from user input
            int[] array = new int[n];

            var num =new int[] {1,2,3,4,5,6,7,8,9,10};
            for(int i=0;i<n;i++)
            {
                Console.WriteLine($"input the  {i+1} position  number :");
                array[i]=int.Parse(Console.ReadLine());
            }
             foreach(var item in array)
            {
                Console.WriteLine(item);
            }
            List<int> list = new List<int>() { 10, 20, 30, 40, 20 };
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(list[i]);
            }

            list.Remove(20);
            list.Insert(4, 50);

            Console.WriteLine("After removing 20 from the list:");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            int j;
            for(int i=5;i>=1;i--)
            {
                for(j=1;j<=5;j++)
                {
                    if(j>=i)
                    {
                        Console.Write("*");
                    }
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Pyramid :  ");
            int k;
            j = 1;
            int t=10;
            for (int i = 1; i <= 5; i++)
            {
                for (k= j; k <= t; k=k+2)
                {

                    Console.Write(k);
                    Console.Write(" ");
                }
                j = j +1;
                t = t -1;

                Console.WriteLine();
                if (i < 5)
                {
                    for (int l = 1; l <= i; l++)
                    {
                        Console.Write(" ");
                    }
                }
            }
             
            j = 10/2;
             t = j+1;
            for (int i = 5; i >= 1; i--)
            {
                for (int l = 1; l < i; l++)
                {
                    Console.Write(" ");
                }

                for (k = j; k <= t; k = k + 2)
                {

                    Console.Write(k);
                    Console.Write(" ");
                }
                j = j - 1;
                t = t + 1;
                Console.WriteLine();
                
            }
            Console.WriteLine();


            Console.WriteLine("Pyramid by * :  ");
            
            j = 1;
             t = 10;
            for (int i = 1; i <= 5; i++)
            {
                for (k = j; k <= t; k = k + 2)
                {

                    Console.Write("*");
                    Console.Write(" ");
                }
                j = j + 1;
                t = t - 1;

                Console.WriteLine();
                if (i < 5)
                {
                    for (int l = 1; l <= i; l++)
                    {
                        Console.Write(" ");
                    }
                }
            }

            j = 10 / 2;
            t = j + 1;
            for (int i = 5; i >= 1; i--)
            {
                for (int l = 1; l < i; l++)
                {
                    Console.Write(" ");
                }

                for (k = j; k <= t; k = k + 2)
                {

                    Console.Write("*");
                    Console.Write(" ");
                }
                j = j - 1;
                t = t + 1;
                Console.WriteLine();

            }


            string[] fr=new string[7];
           




        }



    }
}
