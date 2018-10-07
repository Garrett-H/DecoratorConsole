using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decoratorEx
{
    class DecoratorDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting Main");

            Widget text = new TextField();
            text.Draw();
            Console.WriteLine();
            Decorator Border = new BorderDecorator(text);
            Border.Draw();
            Console.WriteLine();
            Decorator Scroll = new ScrollDecorator(text);
            Scroll.Draw();

            Console.ReadKey();
        }
    }
}
