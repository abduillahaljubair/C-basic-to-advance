using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPinShort
{
    //class rectangle inheriting Animal1 class and implementing Ishape interface
    //class extended first and then implemented interface
    public class rectangle : Animal1, Ishape
    {
        public void draw()
        {
            Console.WriteLine("drawing rectangle");
        }

        public void details()
        {
            Console.WriteLine("this is rectangle class implementing Ishape interface");
        }

        Ishape rec2;

       public void des(Ishape rec2)
        {
            Console.WriteLine("this is rectangle class implementing Ishape interface" + rec2);
        }
    }
}
