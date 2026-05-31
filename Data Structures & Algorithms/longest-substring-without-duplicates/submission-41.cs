public class Solution {
    public int LengthOfLongestSubstring(string s) {
        HashSet<char> set = new();
        int left = 0;
        int result = 0;

        for (int i = 0; i < s.Length; i++) {
            char c = s[i];
            while (set.Contains(c)) {
                set.Remove(s[left]);
                left++;
            }

            set.Add(c);
            int window = (i - left) + 1;
            result = Math.Max(result, window);
        }

        return result;
    }
}
