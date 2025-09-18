﻿using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введіть суму в USD:");
        double usd = double.Parse(Console.ReadLine());
        CurrencyConverter usdToUah = new CurrencyConverter(new UsdToUah());
        usdToUah.ConvertAndPrint(usd);

        Console.WriteLine("Введіть суму в EUR:");
        double eur = double.Parse(Console.ReadLine());
        CurrencyConverter eurToUah = new CurrencyConverter(new EurToUah());
        eurToUah.ConvertAndPrint(eur);
    }
}
