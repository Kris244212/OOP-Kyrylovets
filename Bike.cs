public class Bike : Transport
{
    public override double Move(double distance)
    {
        return 0.0; // Велосипед не витрачає пального
    }
}
class Bike : Transport
{
    public Bike(string name) : base(name) { }

    public override double FuelConsumption()
    {
        return 0;
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"Велосипед {Name} не витрачає пального");
    }
}
