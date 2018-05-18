using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 1, 2, 3, 3, 4, 5, 5, 7, 7 };

            int result = MaxProfit(nums);

            Console.WriteLine(result);
            Console.ReadLine();
        }

        /// <summary>
        /// 从排序数组中删除重复项：
        /// 给定一个排序数组，你需要在原地删除重复出现的元素，使得每个元素只出现一次，返回移除后数组的新长度。
        /// 不要使用额外的数组空间，你必须在原地修改输入数组并在使用 O(1) 额外空间的条件下完成。
        /// 测试数据：int[] nums = { 1, 1, 2, 3, 3, 4, 5, 5, 7, 7 };
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int RemoveDuplicates(int[] nums)
        {
            if(nums.Length == 0 && nums == null)
            {
                return 0;
            }

            int temp = 0;
            for(var i = 0;i < nums.Length; i++)
            {
                if(nums[i] != nums[temp])
                {
                    nums[++temp] = nums[i];
                }
            }
            return temp + 1;
        }

        /// <summary>
        /// 买卖股票的最佳时机 II
        /// 给定一个数组，它的第 i 个元素是一支给定股票第 i 天的价格。
        ///设计一个算法来计算你所能获取的最大利润。你可以尽可能地完成更多的交易（多次买卖一支股票）。
        ///注意：你不能同时参与多笔交易（你必须在再次购买前出售掉之前的股票）。
        ///
        ///思路：贪心算法，只要可以产生利润（后一天比前一天股票价值上升），就进行一次买卖
        /// </summary>
        /// <param name="prices"></param>
        /// <returns></returns>
        public static int MaxProfit(int[] prices)
        {
            if(prices.Length == 0 && prices == null)
            {
                return 0;
            }

            int max = 0;

            for(int i=1; i < prices.Length; i++)
            {
                if (prices[i-1] < prices[i])
                {
                    max += (prices[i] - prices[i-1]);
                }
            }

            return max;
        }

    }
}
