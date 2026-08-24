/*
 * @lc app=leetcode id=1 lang=csharp
 *
 * [1] Two Sum
 */

// @lc code=start
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var indicesByValue = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) {
            int complement = target - nums[i];

            if (indicesByValue.TryGetValue(complement, out int complementIndex)) {
                return new[] { complementIndex, i };
            }

            indicesByValue[nums[i]] = i;
        }

        return Array.Empty<int>();
    }
}
// @lc code=end
