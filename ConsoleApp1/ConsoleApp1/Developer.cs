namespace ConsoleApplication;

class Developer : Worker
{
    public Developer(string name) : base(name)
    {
        Position = "Розробник";
    }

    public override void Call()
    {
        WorkDay.Add($"Developer {Name} is making a call.");
    }

    public override void WriteCode()
    {
        WorkDay.Add($"Developer {Name} is writing code.");
    }

    public override void Relax()
    {
        WorkDay.Add($"Developer {Name} is relaxing.");
    }

    public override void FillWorkDay()
    {
        WriteCode();
        Call();
        Relax();
        WriteCode();
    }
}