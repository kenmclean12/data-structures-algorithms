public class Solution {
    public string LongestPalindrome(string s) {
        int start = 0;
        int maxLength = 0;

        for (int i = 0; i < s.Length; i++) {
            int oddCount = Expand(s, i, i);
            int evenCount = Expand(s, i, i + 1);
            int highest = Math.Max(oddCount, evenCount);
            if (highest > maxLength) {
                maxLength = highest;
                start = i - ((highest - 1) / 2);
            }
        }

        return s.Substring(start, maxLength);
    }

    private int Expand(string s, int left, int right) {
        int len = 0;

        while (
            left >= 0 &&
            right < s.Length &&
            s[left] == s[right]
        ) {
            len = (right - left) + 1;
            left--;
            right++;
        }

        return len;
    }
}
