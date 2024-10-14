namespace CurrencyConverterApp;

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
