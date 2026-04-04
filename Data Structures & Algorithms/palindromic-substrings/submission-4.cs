public class Solution {
    public int CountSubstrings(string s) {
        int total = 0;

        for (int i = 0; i < s.Length; i++) {
            int odd = Expand(s, i, i);
            int even = Expand(s, i, i + 1);
            int curTotal = odd + even;
            total += curTotal;
        }

        return total;
    }

    private int Expand(string s, int left, int right) {
        int count = 0;
        
        while (
            left >= 0 &&
            right < s.Length &&
            s[left] == s[right]
        ) {
            count++;
            left--;
            right++;
        }

        return count;
    }
}
