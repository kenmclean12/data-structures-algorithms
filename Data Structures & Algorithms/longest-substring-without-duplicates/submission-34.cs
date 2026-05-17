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

            int window = (i - left) + 1;
            result = Math.Max(result, window);
            set.Add(s[i]);
        }

        return result;
    }
}
