/*
 * @lc app=leetcode id=26 lang=csharp
 *
 * [26] Remove Duplicates from Sorted Array
 */

// @lc code=start
public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if (nums.Length == 0) return 0;

        int k = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            if(nums[i] != nums[k - 1])
            {
                nums[k] = nums[i];
                k++;
            }
        }
        return k;
    }
}
// @lc code=end

