public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if (s.Length == 0) return 0;
        HashSet<char> seen = new HashSet<char>();
        int left = 0;
        int length = 0;

        for (int i = 0; i < s.Length; i++) {
            char c = s[i];
            while (seen.Contains(c)) {
                seen.Remove(s[left]);
                left++;
            }

            seen.Add(c);
            length = Math.Max(length, (i - left) + 1);
        }

        return length;
    }
}
