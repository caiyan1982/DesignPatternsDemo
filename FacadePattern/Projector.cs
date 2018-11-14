using System;

namespace FacadePattern
{
    public class Projector
    {
        public void On()
        {
            Console.WriteLine("Top-O-Line Projector on");
        }

        public void WideScreenMode()
        {
            Console.WriteLine("Top-O-Line Projector in widescreen mode (16x9 aspect ratio)");
        }

        public void Off()
        {
            Console.WriteLine("Top-O-Line Projector off");
        }
    }
}
