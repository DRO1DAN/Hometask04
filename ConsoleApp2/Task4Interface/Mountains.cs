namespace GeographicInterfaceApp;

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