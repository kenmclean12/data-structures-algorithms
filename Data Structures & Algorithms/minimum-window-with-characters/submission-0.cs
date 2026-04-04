public class Solution {
    public string MinWindow(string s, string t) {
        if (t.Length > s.Length) return "";

        int[] tFreq = new int[128];
        for (int i = 0; i < t.Length; i++) {
            tFreq[t[i]]++;
        }

        int[] sFreq = new int[128];

        int left = 0;
        int right = 0;
        int formed = 0;
        int required = 0;

        for (int i = 0; i < 128; i++) {
            if (tFreq[i] > 0) required++;
        }

        int minLen = int.MaxValue;
        int minLeft = 0;

        while (right < s.Length) {
            char c = s[right];
            sFreq[c]++;

            if (tFreq[c] > 0 && sFreq[c] == tFreq[c]) {
                formed++;
            }

            while (left <= right && formed == required) {
                int windowLen = right - left + 1;
                if (windowLen < minLen) {
                    minLen = windowLen;
                    minLeft = left;
                }

                char leftChar = s[left];
                sFreq[leftChar]--;

                if (tFreq[leftChar] > 0 && sFreq[leftChar] < tFreq[leftChar]) {
                    formed--;
                }

                left++;
            }

            right++;
        }

        return minLen == int.MaxValue ? "" : s.Substring(minLeft, minLen);
    }
}
