public class Solution {
    public int LengthOfLongestSubstring(string s) {
        HashSet<char> set = new();
        int left = 0;
        int maxLen = 0;

        for (int i = 0; i < s.Length; i++) {
            while (set.Contains(s[i])) {
                set.Remove(s[left]);
                left++;
            }

            set.Add(s[i]);
            maxLen = Math.Max(maxLen, (i - left) + 1);
        }

        return maxLen;
    }
}
