using System;

namespace Lab3v2
{
    class Car : Transport
    {
        public override void Move(int speed)
        {
            Console.WriteLine($"Car moving at {speed} km/h");
        }

        public override void Move(int speed, string direction)
        {
            Console.WriteLine($"Car moving at {speed} km/h towards {direction}");
        }

        // Додатковий метод для 3 аргументів
        public void Move(int speed, string direction, string gear)
        {
            Console.WriteLine($"Car moving at {speed} km/h towards {direction} in {gear} gear");
        }
    }
}




