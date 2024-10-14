namespace GeographicApp;

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