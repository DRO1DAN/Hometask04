using System;
using System.Text;

namespace CurrencyConverterApp
{
    class Converter
    {
        private decimal usdToUah;
        private decimal eurToUah;

        public Converter(decimal usdRate, decimal eurRate)
        {
            usdToUah = usdRate;
            eurToUah = eurRate;
        }

        public decimal ConvertUahToUsd(decimal amountInUah)
        {
            return amountInUah / usdToUah;
        }

        public decimal ConvertUahToEur(decimal amountInUah)
        {
            return amountInUah / eurToUah;
        }

        public decimal ConvertUsdToUah(decimal amountInUsd)
        {
            return amountInUsd * usdToUah;
        }

        public decimal ConvertEurToUah(decimal amountInEur)
        {
            return amountInEur * eurToUah;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Введіть курс долара до гривні: ");
            decimal usdRate = decimal.Parse(Console.ReadLine().Replace('.', ','));

            Console.Write("Введіть курс євро до гривні: ");
            decimal eurRate = decimal.Parse(Console.ReadLine().Replace('.', ','));

            Converter converter = new Converter(usdRate, eurRate);

            while (true)
            {
                Console.WriteLine("\nМеню:");
                Console.WriteLine("1. Конвертувати гривні в долари");
                Console.WriteLine("2. Конвертувати гривні в євро");
                Console.WriteLine("3. Конвертувати долари в гривні");
                Console.WriteLine("4. Конвертувати євро в гривні");
                Console.WriteLine("5. Вийти");
                Console.Write("Введіть номер дії: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Введіть суму в гривнях: ");
                        decimal uahAmount = decimal.Parse(Console.ReadLine().Replace('.', ','));
                        Console.WriteLine($"Сума в доларах: {converter.ConvertUahToUsd(uahAmount):0.00}");
                        break;

                    case "2":
                        Console.Write("Введіть суму в гривнях: ");
                        uahAmount = decimal.Parse(Console.ReadLine().Replace('.', ','));
                        Console.WriteLine($"Сума в євро: {converter.ConvertUahToEur(uahAmount):0.00}");
                        break;

                    case "3":
                        Console.Write("Введіть суму в доларах: ");
                        decimal usdAmount = decimal.Parse(Console.ReadLine().Replace('.', ','));
                        Console.WriteLine($"Сума в гривнях: {converter.ConvertUsdToUah(usdAmount):0.00}");
                        break;

                    case "4":
                        Console.Write("Введіть суму в євро: ");
                        decimal eurAmount = decimal.Parse(Console.ReadLine().Replace('.', ','));
                        Console.WriteLine($"Сума в гривнях: {converter.ConvertEurToUah(eurAmount):0.00}");
                        break;

                    case "5":
                        return;

                    default:
                        Console.WriteLine("Невірний вибір. Спробуйте ще раз.");
                        break;
                }
            }
        }
    }
}
