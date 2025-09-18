using System;

namespace Lab3v2
{
    class Bike : Transport
    {
        public override void Move(int speed)
        {
            Console.WriteLine($"Bike moving at {speed} km/h");
        }

    }
}
