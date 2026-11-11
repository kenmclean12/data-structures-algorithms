public class Solution {
    public string MinWindow(string s, string t) {
        if (s.Length < t.Length) return "";
        int[] tCount = new int[128];
        for (int i = 0; i < t.Length; i++) tCount[t[i]]++;

        int[] sCount = new int[128];
        int left = 0;

        int minStart = 0;
        int minLen = int.MaxValue;

        for (int i = 0; i < s.Length; i++) {
            sCount[s[i]]++;
            while (CountsValid(tCount, sCount)) {
                int window = (i - left) + 1;
                if (window < minLen) {
                    minStart = left;
                    minLen = window;
                }

                sCount[s[left]]--;
                left++;
            }
        }

        return minLen == int.MaxValue ? "" : s.Substring(minStart, minLen);
    }

    private bool CountsValid(int[] tCount, int[] sCount) {
        for (int i = 0; i < 128; i++) {
            if (sCount[i] < tCount[i]) return false;
        }
        return true;
    }
}
