using System;

class Program
{
    static void Main(string[] args)
    {
        // Масив об'єктів базового класу Transport
        Transport[] transports = new Transport[]
        {
            new Car("BMW", 200, 8),
            new Bike("Trek", 30, "Гірський")
        };

        Console.WriteLine("=== Демонстрація поліморфізму ===\n");

        foreach (var t in transports)
        {
            t.Move();   // Виклик перевизначеного методу
            Console.WriteLine();
        }

        Console.WriteLine("\nПрограма завершила роботу.");
    }
}



