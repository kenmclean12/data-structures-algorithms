public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int left = 0;
        int maxLength = 0;
        HashSet<int> seen = new();

        for (int i = 0; i < s.Length; i++) {
            while (seen.Contains(s[i])) {
                seen.Remove(s[left]);
                left++;
            }

            maxLength = Math.Max(maxLength, (i - left) + 1);
            seen.Add(s[i]);
        }

        return maxLength;
    }
}
