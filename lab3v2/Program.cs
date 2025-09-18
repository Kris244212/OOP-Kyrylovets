using System;

namespace Lab3v2
{
    class Program
    {
        static void Main()
        {
            Transport t = new Transport();
            t.Move(50);
            t.Move(60, "north");

            Car c = new Car();
            c.Move(100);
            c.Move(120, "east");
            c.Move(80, "west", "third");

            Bike b = new Bike();
            b.Move(30);
            b.Move(25, "south");
            b.Move(20, "mountain trail");
        }
    }
}

