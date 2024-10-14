namespace GeographicInterfaceApp;

interface IGeographicObject
{
    double CoordinateX { get; set; }
    double CoordinateY { get; set; }
    string Name { get; set; }
    string Description { get; set; }

    string GetInfo();
}