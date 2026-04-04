public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if (s.Length == 0) return 0;
        HashSet<char> set = new HashSet<char>();
        int left = 0;
        int maxLength = 0;

        for (int i = 0; i < s.Length; i++) {
            char c = s[i];
            while (set.Contains(c)) {
                set.Remove(s[left]);
                left++;
            }

            set.Add(c);
            maxLength = Math.Max(maxLength, (i - left) + 1);
        }

        return maxLength;
    }
}
