using System;

namespace Lab3v2
{
    class Transport
    {
        public virtual void Move(int speed)
        {
            Console.WriteLine($"Transport moving at {speed} km/h");
        }

        public virtual void Move(int speed, string direction)
        {
            Console.WriteLine($"Transport moving at {speed} km/h towards {direction}");
        }
    }
}
