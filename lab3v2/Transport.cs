public abstract class Transport
{
    public string Name { get; set; }
    public int Speed { get; set; }

  
    public Transport(string name, int speed)
    {
        Name = name;
        Speed = speed;
        Console.WriteLine($"Transport {Name} створений зі швидкістю {Speed} км/год.");
    }


    ~Transport()
    {
        Console.WriteLine($"Transport {Name} знищено.");
    }

    public abstract void Move();
}

