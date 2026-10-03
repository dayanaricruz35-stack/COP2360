using System;

public class Stock
{
    public decimal CurrentPrice { get; set; }
    public decimal SharesOwned { get; set; }

    public decimal Worth => CurrentPrice * SharesOwned;
}

enum InvestmentType
{
    Technology,
    Healthcare,
    Energy,
    Financial
}

class Program
{
    static void Main()
    {
        // Create an instance of the Stock class
        Stock myStock = new Stock
        {
            CurrentPrice = 150.00m,
            SharesOwned = 10
        };

        // Use an enum to identify the type of investment
        InvestmentType type = InvestmentType.Technology;

        Console.WriteLine("Investment Information");
        Console.WriteLine("----------------------");
        Console.WriteLine($"Investment Type: {type}");
        Console.WriteLine($"Current Price: ${myStock.CurrentPrice}");
        Console.WriteLine($"Shares Owned: {myStock.SharesOwned}");
        Console.WriteLine($"Total Worth: ${myStock.Worth}");
    }
}
