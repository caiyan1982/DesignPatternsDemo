using System;

namespace FacadePattern
{
    public class TheaterLights
    {
        public void Dim(int ratio)
        {
            Console.WriteLine("Theater Ceiling Lights dimming to {0}%", ratio);
        }

        public void On()
        {
            Console.WriteLine("Theater Ceiling Lights on");
        }
    }
}
