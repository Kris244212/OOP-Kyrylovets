using System;

namespace lab1
{
    // Абстрактний клас Figure
    abstract class Figure
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Figure(string name)
        {
            _name = name;
            Console.WriteLine($"[Constructor] Figure '{_name}' created.");
        }

        ~Figure()
        {
            Console.WriteLine($"[Destructor] Figure '{_name}' destroyed.");
        }

        public virtual double GetArea()
        {
            return 0;
        }
    }

    // Клас Circle
    class Circle : Figure
    {
        private double _radius;

        public Circle(string name, double radius) : base(name)
        {
            _radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * _radius * _radius;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle("MyCircle", 5.0);
            double area = circle.GetArea();
            Console.WriteLine($"Name: {circle.Name}");
            Console.WriteLine($"Area of the circle: {area:F2}");
        }
    }
}
