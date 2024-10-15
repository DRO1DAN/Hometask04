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

    abstract public void Call();

    abstract public void WriteCode();

    abstract public void Relax();

    public abstract void FillWorkDay();
}