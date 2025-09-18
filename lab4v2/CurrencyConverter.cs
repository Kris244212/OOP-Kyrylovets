using System;

public class CurrencyConverter
{
    private IConverter converter;

    public CurrencyConverter(IConverter converter)
    {
        this.converter = converter;
    }

    public void ConvertAndPrint(double amount)
    {
        double result = converter.Convert(amount);
        Console.WriteLine($"Результат конвертації: {result} грн");
    }
}
