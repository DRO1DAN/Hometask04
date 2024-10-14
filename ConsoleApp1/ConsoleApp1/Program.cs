using System.Text;

namespace ConsoleApplication
{
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