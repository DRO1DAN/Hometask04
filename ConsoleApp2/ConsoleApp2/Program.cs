namespace GeographicApp
{
    abstract class GeographicObject
    {
        public double CoordinateX { get; set; }
        public double CoordinateY { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public GeographicObject(double x, double y, string name, string description)
        {
            CoordinateX = x;
            CoordinateY = y;
            Name = name;
            Description = description;
        }

        public virtual string GetInfo()
        {
            return $"Назва: {Name}, Координати: ({CoordinateX}, {CoordinateY}), Опис: {Description}";
        }
    }

    class River : GeographicObject
    {
        public double FlowSpeed { get; set; }
        public double Length { get; set; }

        public River(double x, double y, string name, string description, double flowSpeed, double length)
            : base(x, y, name, description)
        {
            FlowSpeed = flowSpeed;
            Length = length;
        }

        public override string GetInfo()
        {
            return base.GetInfo() + $", Швидкість течії: {FlowSpeed} см/с, Довжина: {Length} км";
        }
    }

    class Mountain : GeographicObject
    {
        public double HighestPoint { get; set; }

        public Mountain(double x, double y, string name, string description, double highestPoint)
            : base(x, y, name, description)
        {
            HighestPoint = highestPoint;
        }

        public override string GetInfo()
        {
            return base.GetInfo() + $", Найвища точка: {HighestPoint} м";
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            River river = new River(48.4, 35.0, "Дніпро", "Найбільша річка України", 120, 2201);
            Mountain mountain = new Mountain(44.2, 33.6, "Говерла", "Найвища гора в Україні", 2061);

            Console.WriteLine(river.GetInfo());
            Console.WriteLine(mountain.GetInfo());

            Console.ReadKey();
        }
    }
}