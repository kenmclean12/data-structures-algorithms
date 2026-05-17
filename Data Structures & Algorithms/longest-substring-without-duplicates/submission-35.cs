public class Solution {
    public int LengthOfLongestSubstring(string s) {
        HashSet<int> set = new();
        int left = 0;
        int result = 0;

        for (int i = 0; i < s.Length; i++) {
            while (set.Contains(s[i])) {
                set.Remove(s[left]);
                left++;
            }

            set.Add(s[i]);
            int window = (i - left) + 1;
            result = Math.Max(result, window);
        }

        return result;
    }
}
