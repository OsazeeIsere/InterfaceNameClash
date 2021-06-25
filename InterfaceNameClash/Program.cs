using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceNameClash
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fun with interface name clash");
            //all of these invocations call the same
            //Draw() method!
            Octagon oct = new Octagon();
            IDrawToForm itfForm = (IDrawToForm)oct;
            itfForm.Draw();

            IDrawToMemory itfMemory = (IDrawToMemory)oct;
            itfMemory.Draw();

            IDrawToPrinter itfPrinter = (IDrawToPrinter)oct;
            itfPrinter.Draw();
        }
    }
}
