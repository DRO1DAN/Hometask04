using Microsoft.Extensions.Logging;

namespace Task5
{
    public class Product
    {
        public double Price { get; set; }
        public string CountryOfOrigin { get; set; }
        public string Name { get; set; }
        public DateTime PackagingDate { get; set; }
        public string Description { get; set; }
    }

    public class FoodProduct : Product
    {
        public DateTime ExpirationDate { get; set; }
        public int Quantity { get; set; }
        public string UnitOfMeasure { get; set; }
    }

    public class Book : Product
    {
        public int PageCount { get; set; }
        public string Publisher { get; set; }
        public List<string> Authors { get; set; }
    }


    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
