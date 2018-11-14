using System;

namespace FacadePattern
{
    public class Amplifier
    {
        public void On()
        {
            Console.WriteLine("Top-O-Line Amplifier on");
        }

        public void SetDvd()
        {
            Console.WriteLine("Top-O-Line Amplifier setting DVD player to Top-O-Line DVD Player");
        }

        public void SetSurroundSound()
        {
            Console.WriteLine("Top-O-Line Amplifier surround sound on(5 speakers, 1 subwoofer)");
        }

        public void SetVolume(int level)
        {
            Console.WriteLine("Top-O-Line Amplifier setting volume to {0}", level);
        }

        public void Off()
        {
            Console.WriteLine("Top-O-Line Amplifier off");
        }
    }
}
