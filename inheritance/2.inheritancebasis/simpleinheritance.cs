using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.inheritancebasis
{
    public class simpleinheritance
    {
        static void Main(string[] args)
        {
            A superclass = new A();
            B subclass=new B();

            superclass.i = 10;
            superclass.j = 20;
            Console.WriteLine("showing superclass :");
           superclass.showij();

            subclass.i = 30;
            subclass.j = 40;
            subclass.k = 50; // Assuming 'k' is accessible, otherwise use a property or protected field
            subclass.showij();
            subclass.showk();
            Console.WriteLine("showing subclass :");
            subclass.sum();
            

        }
    }
}
