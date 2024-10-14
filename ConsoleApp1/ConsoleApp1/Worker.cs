namespace ConsoleApplication;

abstract class Worker
{
    public string Name { get; set; }
    public string Position { get; protected set; }
    public List<string> WorkDay { get; private set; }

    public Worker(string name)
    {
        Name = name;
        WorkDay = new List<string>();
    }

    public void Call()
    {
        WorkDay.Add($"{Name} is making a call.");
    }

    public void WriteCode()
    {
        WorkDay.Add($"{Name} is writing code.");
    }

    public void Relax()
    {
        WorkDay.Add($"{Name} is relaxing.");
    }

    public abstract void FillWorkDay();
}