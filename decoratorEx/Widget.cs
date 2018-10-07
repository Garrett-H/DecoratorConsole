using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decoratorEx
{
    interface Widget
    {
        void Draw();
    }

    class TextField : Widget
    {
        public void Draw()
        {
            Console.WriteLine("Creating TextField");
        }
    }

    abstract class Decorator : Widget
    {
        private Widget wid;

        public Decorator(Widget w)
        {
            this.wid = w;
            Console.WriteLine("Decorator Beginning");
        }

        public abstract void Draw();
    }

    class BorderDecorator : Decorator
    {
        private Widget wid;
        public BorderDecorator(Widget w) : base(w)
        {
            Console.WriteLine("Beginning Border Decorator");
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing Border");
        }
    }

    class ScrollDecorator : Decorator
    {
        public ScrollDecorator(Widget w) : base(w)
        {
            Console.WriteLine("Beginning Scroll Decorator");
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing Scroll");
        }
    }
}
