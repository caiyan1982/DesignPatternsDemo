using System;

namespace FacadePattern
{
    public class DvdPlayer
    {
        private string _movie;

        public void On()
        {
            Console.WriteLine("Top-O-Line Dvd Player on");
        }

        public void Play(string movie)
        {
            _movie = movie;
            Console.WriteLine("Top-O-Line Dvd Player playing \"{0}\"", _movie);
        }

        public void Stop()
        {
            Console.WriteLine("Top-O-Line Dvd Player stoped \"{0}\"", _movie);
        }

        public void Eject()
        {
            Console.WriteLine("Top-O-Line Dvd Player eject");
        }

        public void Off()
        {
            Console.WriteLine("Top-O-Line Dvd Player off");
        }
    }
}
