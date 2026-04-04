public class Solution {
    public string LongestPalindrome(string s) {
        int start = 0;
        int maxLength = 0;

        for (int i = 0; i < s.Length; i++) {
            int oddLen = Expand(s, i, i);
            int evenLen = Expand(s, i, i + 1);
            int highest = Math.Max(oddLen, evenLen);
            if (highest > maxLength) {
                maxLength = highest;
                start = i - ((highest - 1) / 2);
            }
        }

        return s.Substring(start, maxLength);
    }

    private int Expand(string s, int left, int right) {
        int count = 0;

        while (
            left >= 0 &&
            right < s.Length &&
            s[left] == s[right]
        ) {
            count = (right - left) + 1;
            left--;
            right++;
        }

        return count;
    }
}
