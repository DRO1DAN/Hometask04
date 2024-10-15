using ConsoleApplication;

class Team
{
    public string TeamName { get; private set; }
    private List<Worker> Workers;

    public Team(string teamName)
    {
        TeamName = teamName;
        Workers = new List<Worker>();
    }

    public void AddWorker(Worker worker)
    {
        Workers.Add(worker);
    }

    public void ShowTeamInfo()
    {
        Console.WriteLine($"Team: {TeamName}");
        foreach (var worker in Workers)
        {
            Console.WriteLine(worker.Name);
        }
    }

    public void ShowDetailedInfo()
    {
        Console.WriteLine($"Team: {TeamName}");
        foreach (var worker in Workers)
        {
            Console.WriteLine($"{worker.Name} - {worker.Position}");
            foreach (var activity in worker.WorkDay)
            {
                Console.WriteLine(activity);
            }
        }
    }
}