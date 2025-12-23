using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPinShort
{
    public abstract class  abstractclass1
    {
        string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        void display()
        {
            Console.WriteLine("this is abstract class");
        }
        public abstract void show();
    }
    public class subclass : abstractclass1
    {
        public override void show()
        {
            Console.WriteLine("this is abstract method implemented in subclass");
        }
    }
}
