/*
 * @lc app=leetcode id=9 lang=csharp
 *
 * [9] Palindrome Number
 */

// @lc code=start
public class Solution {
    public bool IsPalindrome(int x) {
        if (x < 0 || x % 10 == 0 && x != 0)
        {
            return false;
        }

        int reversedhalf = 0;
        while (x > reversedhalf)
        {
            reversedhalf = reversedhalf * 10 + x % 10;
            x /= 10;
        }
        return x == reversedhalf || x == reversedhalf / 10;
        
    }
}
// @lc code=end

