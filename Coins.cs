using System;
namespace CS_Practice
{
    /*
     * COINS   
     * Write a Solution, which return the minimum number of coins
     * needed to pay a given amount of money.
     * We have following available coins: 200, 100, 50, 20, 10, 5, 2, 1.  
     * (input - > output)1021 -> 7. because: 1*1 + 1x20 + 5*200 = 1021
     */
    public class Coins
    {
        static public int minimalCoins(int input)
        {
            int[] coins = { 200, 100, 50, 20, 10, 5, 2, 1 };
            int coinAmount = 0;

            foreach (int coin in coins)
            {
                coinAmount += (input - (input % coin)) / coin;
                input %= coin;
            }
                

            return coinAmount;
        }
    }
}
