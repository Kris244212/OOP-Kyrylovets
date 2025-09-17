public class Car : Transport
{
    private double fuelConsumptionPer100km;

    public Car(double consumption)
    {
        fuelConsumptionPer100km = consumption;
    }

    public override double Move(double distance)
    {
        return (fuelConsumptionPer100km / 100.0) * distance;
    }
}
class Car : Transport
{
    public double Consumption { get; set; }

    public Car(string name, double consumption) : base(name)
    {
        Consumption = consumption;
    }

    public override double FuelConsumption()
    {
        return Consumption;
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"Авто {Name} витрачає {Consumption} л/100км");
    }
}
