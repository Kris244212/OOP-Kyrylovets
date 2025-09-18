public class UsdToUah : IConverter
{
    private double rate = 41.2; // курс 1 USD = 41.2 UAH

    public double Convert(double amount)
    {
        return amount * rate;
    }
}
