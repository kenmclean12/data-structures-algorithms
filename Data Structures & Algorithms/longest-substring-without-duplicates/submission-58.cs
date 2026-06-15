public class Solution {
    public int LengthOfLongestSubstring(string s) {
        HashSet<char> set = new();
        int left = 0;
        int result = 0;

        for (int i = 0; i < s.Length; i++) {
            while (set.Contains(s[i])) {
                set.Remove(s[left]);
                left++;
            }

            set.Add(s[i]);
            result = Math.Max(result, (i - left) + 1);
        }

        return result;
    }
}
