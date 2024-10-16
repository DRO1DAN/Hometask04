﻿namespace ConsoleApplication;

class Manager : Worker
{
    static private Random random = new Random();

    public Manager(string name) : base(name)
    {
        Position = "Менеджер";
    }

    public override void Call()
    {
        WorkDay.Add($"Manager {Name} is making a call.");
    }

    public override void WriteCode()
    {
        throw new NotImplementedException("Manager doesn't write a code");
    }

    public override void Relax()
    {
        WorkDay.Add($"Manager {Name} is relaxing.");
    }

    public override void FillWorkDay()
    {
        int firstCallCount = random.Next(1, 11);
        for (int i = 0; i < firstCallCount; i++)
        {
            Call();
        }
        Relax();
        int secondCallCount = random.Next(1, 6);
        for (int i = 0; i < secondCallCount; i++)
        {
            Call();
        }
    }
}