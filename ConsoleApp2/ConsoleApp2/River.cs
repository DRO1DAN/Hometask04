namespace GeographicApp;

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