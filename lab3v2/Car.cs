public class Car : Transport
{
    public int FuelConsumption { get; set; }

 
    public Car(string name, int speed, int fuelConsumption) 
        : base(name, speed)
    {
        FuelConsumption = fuelConsumption;
        Console.WriteLine($"Car {Name} створений. Витрата пального: {FuelConsumption} л/100км.");
    }

 
    ~Car()
    {
        Console.WriteLine($"Car {Name} знищено.");
    }

    public override void Move()
    {
        Console.WriteLine($"Car {Name} рухається зі швидкістю {Speed} км/год.");
    }
}




