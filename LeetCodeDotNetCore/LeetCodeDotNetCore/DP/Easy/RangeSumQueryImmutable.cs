using System;
namespace LeetCodeDotNetCore.DP.Easy
{
    /*
     * Given an integer array nums, find the sum of the elements between indices i and j (i ≤ j), inclusive.

        Example:
        Given nums = [-2, 0, 3, -5, 2, -1]

        sumRange(0, 2) -> 1
        sumRange(2, 5) -> -1
        sumRange(0, 5) -> -3
        Note:
        You may assume that the array does not change.
        There are many calls to sumRange function.
     * 
     */
    public class NumArray
    {

        //private int[] p = null;
        //public NumArray(int[] nums)
        //{
        //    p = nums;
        //}

        //public int SumRange(int i, int j)
        //{
        //    int res = 0;
        //    for (int a = i; a <= j; a++)
        //    {
        //        res += p[a];
        //    }
        //    return res;
        //}


        private readonly int[] _nums;
        private int[] note;
        public NumArray(int[] nums)
        {
            _nums = nums;
            int sum = 0;
            note = new int[_nums.Length + 1];
            for (int i = 0; i < _nums.Length; i++)
            {
                sum += _nums[i];
                note[i + 1] = sum;
            }
        }

        public int SumRange(int i, int j)
        {
            return note[j + 1] - note[i];
        }
    }

}
