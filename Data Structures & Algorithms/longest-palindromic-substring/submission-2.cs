public class Solution {
    public string LongestPalindrome(string s) {
        if (string.IsNullOrEmpty(s) || s.Length == 1) return s;
        int start = 0;
        int maxLength = 0;

        for (int i = 0; i < s.Length; i++) {
            int lenOdd = Expand(s, i, i);
            int lenEven = Expand(s, i, i + 1);
            int len = Math.Max(lenOdd, lenEven);

            if (len > maxLength) {
                maxLength = len;
                start = i - ((len - 1) / 2);
            }
        }

        return s.Substring(start, maxLength);
    }

    private int Expand(string s, int left, int right) {
        while (
            left >= 0 &&
            right <= s.Length - 1 &&
            s[left] == s[right]
        ) {
            left--;
            right++;
        }

        return (right - left) - 1;
    }
}
