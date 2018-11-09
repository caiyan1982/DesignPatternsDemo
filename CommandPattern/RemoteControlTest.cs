using System;

namespace CommandPattern
{
    class RemoteControlTest
    {
        static void Main(string[] args)
        {
            RemoteControl remote = new RemoteControl();
            Light light = new Light();
            LightOnCommand lightOn = new LightOnCommand(light);
            LightOffCommand lightOff = new LightOffCommand(light);
            GarageDoor garageDoor = new GarageDoor();
            GarageDoorOpenCommand garageOpen = new GarageDoorOpenCommand(garageDoor);
            GarageDoorCloseCommand garageClose = new GarageDoorCloseCommand(garageDoor);

            remote.SetCommand(0, lightOn, lightOff);
            remote.SetCommand(1, garageOpen, garageClose);

            Console.WriteLine(remote);

            remote.OnButtonWasPushed(0);
            remote.OffButtonWasPushed(0);
            remote.UndoButtonWasPushed();
            remote.OnButtonWasPushed(1);
            remote.OffButtonWasPushed(1);
            remote.OnButtonWasPushed(1);
            remote.UndoButtonWasPushed();

            CeilingFan ceilingFan = new CeilingFan("Living Room");
            CeilingFanHighCommand ceilingFanHigh = new CeilingFanHighCommand(ceilingFan);
            CeilingFanMediumCommand ceilingFanMedium = new CeilingFanMediumCommand(ceilingFan);
            CeilingFanOffCommand ceilingFanOff = new CeilingFanOffCommand(ceilingFan);

            remote.SetCommand(0, ceilingFanMedium, ceilingFanOff);
            remote.SetCommand(1, ceilingFanHigh, ceilingFanOff);

            remote.OnButtonWasPushed(0);
            remote.OffButtonWasPushed(0);
            Console.WriteLine(remote);
            remote.UndoButtonWasPushed();

            remote.OnButtonWasPushed(1);
            Console.WriteLine(remote);
            remote.UndoButtonWasPushed();

            Console.Read();
        }
    }
}
