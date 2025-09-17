public abstract class Transport
{
    public abstract double Move(double distance);
}
abstract class Transport
{
    public string Name { get; set; }

    public Transport(string name)
    {
        Name = name;
    }

    public abstract double FuelConsumption(); // абстрактний метод
    public virtual void ShowInfo()            // віртуальний метод
    {
        Console.WriteLine($"Транспорт: {Name}");
    }
}
