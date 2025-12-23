using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPinShort
{
    public class Animal
    {
        public string Name { get; set; }
        public string Description { get; set; }
      
        public void eat()
        {
            Console.WriteLine("this is animal");
        }

    }

    public class Dog : Animal
    {
       

        public void Bark()
        {
            Console.WriteLine("this is dog");
        }
    }
}

