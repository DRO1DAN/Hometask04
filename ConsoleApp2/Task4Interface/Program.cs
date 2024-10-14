using System.Text;

namespace GeographicInterfaceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            River river = new River(48.4, 35.0, "Дніпро", "Найбільша річка України", 120, 2201);
            Mountain mountain = new Mountain(44.2, 33.6, "Говерла", "Найвища гора в Україні", 2061);

            Console.WriteLine(river.GetInfo());
            Console.WriteLine(mountain.GetInfo());

            Console.ReadKey();
        }
    }
}