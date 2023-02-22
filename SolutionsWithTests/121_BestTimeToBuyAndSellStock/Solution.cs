using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.BestTimeToBuyAndSellStock
{
    public class Solution
    {
        public int MaxProfit(int[] prices)
        {
            if (prices == null || prices.Length == 0)
            {
                return 0;
            }

            var min = prices[0];
            var profit = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < min)
                {
                    min = prices[i];
                    continue;
                }

                if (profit < prices[i] - min)
                {
                    profit = prices[i] - min;
                }
            }

            return profit;
        }
    }
}
