using System;

namespace FacadePattern
{
    class HomeTheaterTestDrive
    {
        static void Main(string[] args)
        {
            Amplifier amp = new Amplifier();
            CdPlayer cd = new CdPlayer();
            DvdPlayer dvd = new DvdPlayer();
            PopcornPopper popper = new PopcornPopper();
            Projector projector = new Projector();
            Screen screen = new Screen();
            TheaterLights lights = new TheaterLights();
            Tuner tuner = new Tuner();

            HomeTheaterFacade homeTheater = new HomeTheaterFacade(amp, tuner, dvd, cd, projector, lights, screen, 
                popper);
            homeTheater.WatchMovie("Raiders of the Lost Ark");
            homeTheater.EndMovie();

            Console.Read();
        }
    }
}
