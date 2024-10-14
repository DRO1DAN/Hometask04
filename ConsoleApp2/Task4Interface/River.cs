namespace GeographicInterfaceApp;

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