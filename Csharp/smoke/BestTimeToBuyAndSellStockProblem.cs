using System;

public class BestTimeToBuyAndSellStockProblem : ILeetCodeProblem
{
    public string Name
    {
        get { return "Best Time to Buy and Sell Stock"; }
    }

    public void Run()
    {
        int[] prices = { 7, 1, 5, 3, 6, 4 };

        int result = MaxProfit(prices);

        Console.WriteLine("Input: prices = [7, 1, 5, 3, 6, 4]");
        Console.WriteLine("Output: " + result);
    }

    private int MaxProfit(int[] prices)
    {
        int minPrice = Int32.MaxValue;
        int maxProfit = 0;

        for (int i = 0; i < prices.Length; i++)
        {
            if (prices[i] < minPrice)
            {
                minPrice = prices[i];
            }

            int profit = prices[i] - minPrice;

            if (profit > maxProfit)
            {
                maxProfit = profit;
            }
        }

        return maxProfit;
    }
}