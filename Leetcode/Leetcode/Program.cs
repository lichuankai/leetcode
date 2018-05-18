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

            int result = RemoveDuplicates(nums);

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


    }
}
