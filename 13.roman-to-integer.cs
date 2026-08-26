/*
 * @lc app=leetcode id=13 lang=csharp
 *
 * [13] Roman to Integer
 */

// @lc code=start
public class Solution {
    public int RomanToInt(string s) {
        int Total = 0;
        int n = s.Length;

        for (int i = 0; i < n; i++)
        {
            int currentVal = GetValue(s[i]);

            if (i+1 < n && currentVal < GetValue(s[i + 1]))
            {
                Total -= currentVal;
            }
            else
            {
                Total += currentVal;
            }
        }
        return Total;
    }

    private int GetValue (char c)
    {
        return c switch
        {
            'I' => 1,
            'V' => 5,
            'X' => 10,
            'L' => 50,
            'C' => 100,
            'D' => 500,
            'M' => 1000,
            _ => 0 
        };
    }
}
// @lc code=end

