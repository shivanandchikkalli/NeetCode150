public class Solution {
    public int MaxProfit(int[] prices) {
            var maxProfit = 0;

            if(prices.Length < 2)
                return maxProfit;

            int left = 0;
            int right = 1;

            while (right < prices.Length)
            {
                if (prices[left] < prices[right])
                { 
                    maxProfit = Math.Max(maxProfit, prices[right] - prices[left]);
                }
                else
                    left = right;

                right++;
            }

            return maxProfit;      
    }
}