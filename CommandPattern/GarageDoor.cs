using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class GarageDoor
    {
        public void Up()
        {
            Console.WriteLine("Garage Door is open");
        }

        public void Down()
        {
            Console.WriteLine("Garage Door is close");
        }
    }
}
