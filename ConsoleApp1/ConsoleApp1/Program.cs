using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication
{
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

    class Developer : Worker
    {
        public Developer(string name) : base(name)
        {
            Position = "Розробник";
        }

        public override void FillWorkDay()
        {
            WriteCode();
            Call();
            Relax();
            WriteCode();
        }
    }

    class Manager : Worker
    {
        private Random random;

        public Manager(string name) : base(name)
        {
            Position = "Менеджер";
            random = new Random();
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

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<Team> teams = new List<Team>();

            while (true)
            {
                Console.WriteLine("1. Створити команду\n2. Додати співробітника" +
                    "\n3. Показати коротку інформацію про команди\n4. Показати повну інформацію про команди\n5. Вийти");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Назва команди: ");
                        string teamName = Console.ReadLine();
                        teams.Add(new Team(teamName));
                        Console.WriteLine($"Команда '{teamName}' створена.");
                        break;

                    case "2":
                        if (teams.Count == 0)
                        {
                            Console.WriteLine("Спочатку створіть команду.");
                            break;
                        }
                        Console.Write("Назва команди: ");
                        teamName = Console.ReadLine();
                        Team team = teams.Find(t => t.TeamName == teamName);
                        if (team == null)
                        {
                            Console.WriteLine("Команду не знайдено.");
                            break;
                        }

                        Console.Write("Ім'я співробітника: ");
                        string workerName = Console.ReadLine();
                        Console.Write("1 - Розробник, 2 - Менеджер: ");
                        string role = Console.ReadLine();

                        if (role != "1" && role != "2")
                        {
                            Console.WriteLine("Роль не існує");
                            break;
                        }
                        else
                        {
                            Worker worker = role == "1" ? new Developer(workerName) : (Worker)new Manager(workerName);
                            worker.FillWorkDay();
                            team.AddWorker(worker);
                            Console.WriteLine($"Співробітника '{workerName}' додано до команди '{teamName}'.");
                            break;
                        }


                    case "3":
                        foreach (var t in teams)
                        {
                            t.ShowTeamInfo();
                        }
                        break;

                    case "4":
                        foreach (var t in teams)
                        {
                            Console.WriteLine($"Команда: {t.TeamName}");
                            foreach (var e in teams)
                            {
                                e.ShowDetailedInfo();
                            }
                            Console.WriteLine();
                        }
                        break;

                    case "5":
                        return;

                    default:
                        Console.WriteLine("Невірний вибір.");
                        break;
                }

            }
        }
    }
}