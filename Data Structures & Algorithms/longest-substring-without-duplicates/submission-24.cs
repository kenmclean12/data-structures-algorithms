public class Solution {
    public int LengthOfLongestSubstring(string s) {
        HashSet<char> set = new HashSet<char>();
        int left = 0;
        int count = 0;

        for (int i = 0; i < s.Length; i++) {
            char c = s[i];
            while (set.Contains(c)) {
                set.Remove(s[left]);
                left++;
            }

            set.Add(c);
            count = Math.Max(count, (i - left) + 1);
        }

        return count;
    }
}
