public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var set = new HashSet<char>();
        var left = 0;
        var length = 0;

        for (int i = 0; i < s.Length; i++) {
            var c = s[i];
            while (set.Contains(c)) {
                set.Remove(s[left]);
                left++;
            }

            set.Add(c);
            length = Math.Max(length, (i - left) + 1);
        }

        return length;
    }
}
