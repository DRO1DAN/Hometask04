namespace GeographicApp;

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