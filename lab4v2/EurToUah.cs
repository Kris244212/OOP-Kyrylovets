public class EurToUah : IConverter
{
    private double rate = 44.5; // курс 1 EUR = 44.5 UAH

    public double Convert(double amount)
    {
        return amount * rate;
    }
}
