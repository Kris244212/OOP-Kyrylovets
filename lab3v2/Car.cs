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
