public class Solution {
    public int LengthOfLongestSubstring(string s) {
        HashSet<char> set = new();
        int left = 0;
        int len = 0;

        for (int i = 0; i < s.Length; i++) {
            char val = s[i];
            while (set.Contains(val)) {
                set.Remove(s[left]);
                left++;
            }

            set.Add(val);
            len = Math.Max(len, (i - left) + 1);
        }

        return len;
    }
}
