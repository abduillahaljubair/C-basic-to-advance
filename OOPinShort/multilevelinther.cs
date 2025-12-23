using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPinShort
{
    public class Animal1
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual void eat()
        {
            Console.WriteLine("this is animal");
        }

    }

    public class mammal1: Animal1
    {
        Animal1 name;

        public void des(Animal1 name)
        {
            Console.WriteLine("this is mammal" + name);

        }
        public override void eat()
        {
            Console.WriteLine("It can take baby");
        }
    }
    public class Dog1 : mammal1
    {


        public void Bark()
        {
            Console.WriteLine("this is dog");
        }
    }
}
