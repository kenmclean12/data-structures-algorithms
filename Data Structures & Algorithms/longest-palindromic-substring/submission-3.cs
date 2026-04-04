public class Solution {
    public string LongestPalindrome(string s) {
        int start = 0;
        int maxLength = 0;

        for (int i = 0; i < s.Length; i++) {
            int oddLen = Expand(s, i, i);
            int evenLen = Expand(s, i, i + 1);
            int len = Math.Max(oddLen, evenLen);

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
