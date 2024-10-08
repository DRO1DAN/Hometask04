namespace GeographicInterfaceApp
{
    interface IGeographicObject
    {
        double CoordinateX { get; set; }
        double CoordinateY { get; set; }
        string Name { get; set; }
        string Description { get; set; }

        string GetInfo();
    }

    class River : IGeographicObject
    {
        public double CoordinateX { get; set; }
        public double CoordinateY { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double FlowSpeed { get; set; }
        public double Length { get; set; }

        public River(double x, double y, string name, string description, double flowSpeed, double length)
        {
            CoordinateX = x;
            CoordinateY = y;
            Name = name;
            Description = description;
            FlowSpeed = flowSpeed;
            Length = length;
        }

        public string GetInfo()
        {
            return $"Назва: {Name}, Координати: ({CoordinateX}, {CoordinateY}), Опис: {Description}, Швидкість течії: {FlowSpeed} см/с, Довжина: {Length} км";
        }
    }

    class Mountain : IGeographicObject
    {
        public double CoordinateX { get; set; }
        public double CoordinateY { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double HighestPoint { get; set; }

        public Mountain(double x, double y, string name, string description, double highestPoint)
        {
            CoordinateX = x;
            CoordinateY = y;
            Name = name;
            Description = description;
            HighestPoint = highestPoint;
        }

        public string GetInfo()
        {
            return $"Назва: {Name}, Координати: ({CoordinateX}, {CoordinateY}), Опис: {Description}, Найвища точка: {HighestPoint} м";
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