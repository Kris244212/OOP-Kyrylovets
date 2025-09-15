using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Transport> transports = new List<Transport>
        {
            new Car(7.5),  // Авто з витратою 7.5 л/100 км
            new Bike()
        };

        double distance = 100.0;
        double totalFuel = 0.0;

        foreach (var t in transports)
        {
            double fuel = t.Move(distance);
            totalFuel += fuel;
            Console.WriteLine($"Витрати пального на {distance} км: {fuel} л");
        }

        Console.WriteLine($"Загальні витрати пального: {totalFuel} л");
    }
}
