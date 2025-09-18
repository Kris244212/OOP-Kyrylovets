public class Bike : Transport
{
    public string Type { get; set; }

    public Bike(string name, int speed, string type) 
        : base(name, speed)
    {
        Type = type;
        Console.WriteLine($"Bike {Name} створений. Тип: {Type}.");
    }


    ~Bike()
    {
        Console.WriteLine($"Bike {Name} знищено.");
    }

    public override void Move()
    {
        Console.WriteLine($"Bike {Name} їде зі швидкістю {Speed} км/год.");
    }
}
