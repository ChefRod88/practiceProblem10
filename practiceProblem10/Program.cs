using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Dictionary representing the stock prices
        var stocks = new Dictionary<string, double>
        {
            { "TSLA", 912.86 },
            { "BBBY", 24.84 },
            { "AAPL", 174.26 },
            { "SOFI", 6.92 },
            { "KIRK", 8.72 },
            { "AURA", 22.12 },
            { "AMZN", 141.28 },
            { "EMBK", 12.29 },
            { "LVLU", 2.33 }
        };

        // Accept integer input for the number of stock selections
        var ns = int.Parse(Console.ReadLine());

        double totalCost = 0;

        // Loop through each stock selection and accumulate the cost
        for (var i = 0; i < ns; i++)
        {
            var stockSelection = Console.ReadLine();
            if (stocks.ContainsKey(stockSelection))
            {
                totalCost += stocks[stockSelection];
            }
            else
            {
                Console.WriteLine("Invalid stock selection.");
            }
        }

        // Output the total cost of the stock selections
        Console.WriteLine($"Total price: ${totalCost:F2}");
    }
}