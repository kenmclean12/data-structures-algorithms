public class Solution {
    public string MinWindow(string s, string t) {
        if (s.Length < t.Length) return "";
        int[] tCount = new int[128];
        for (int i = 0; i < t.Length; i++) tCount[t[i]]++;

        int[] sCount = new int[128];
        int left = 0;

        int minLen = int.MaxValue;
        int minStart = 0;

        for (int i = 0; i < s.Length; i++) {
            sCount[s[i]]++;
            while (CountsValid(sCount, tCount)) {
                int currLen = (i - left) + 1;
                if (currLen < minLen) {
                    minLen = currLen;
                    minStart = left;
                }
    
                sCount[s[left]]--;
                left++;
            }
        }

        return minLen == int.MaxValue ? "" : s.Substring(minStart, minLen);
    }

    private bool CountsValid(int[] sCount, int[] tCount) {
        for (int i = 0; i < 128; i++) {
            if (sCount[i] < tCount[i]) return false;
        }

        return true;
    }
}
