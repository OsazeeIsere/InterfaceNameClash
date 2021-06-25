using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceNameClash
{
    class Octagon : IDrawToForm, IDrawToMemory, IDrawToPrinter
    {//explicitly bind Draw() to a given interface
         void IDrawToForm.Draw()
        {
            Console.WriteLine("Drawing to form....");
        }

        void IDrawToMemory.Draw()
        {
            Console.WriteLine("Drawing to Memory....");

        }
        void IDrawToPrinter.Draw()
        {
            Console.WriteLine("Drawing to Printer....");

        }
    }
}
