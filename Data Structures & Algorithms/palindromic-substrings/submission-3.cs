public class Solution {
    public int CountSubstrings(string s) {
        int totalCount = 0;

        for (int i = 0; i < s.Length; i++) {
            int oddCount = Expand(s, i, i);
            int evenCount = Expand(s, i, i + 1);
            int currentTotal = oddCount + evenCount;
            totalCount += currentTotal;
        }

        return totalCount;
    }

    private int Expand(string s, int left, int right) {
        int count = 0;

        while (
            left >= 0 &&
            right <= s.Length - 1 &&
            s[left] == s[right]
        ) {
            count++;
            left--;
            right++;
        }

        return count;
    }
}
