public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if (s2.Length < s1.Length) return false;
        int[] s1Freq = new int[26];
        int[] windowFreq = new int[26];

        for (int i = 0; i < s1.Length; i++) {
            s1Freq[s1[i] - 'a']++;
            windowFreq[s2[i] - 'a']++;
        }
        if (arrEqual(s1Freq, windowFreq)) return true;

        for (int i = s1.Length; i < s2.Length; i++) {
            windowFreq[s2[i] - 'a']++;
            windowFreq[s2[i - s1.Length] - 'a']--;
            if (arrEqual(s1Freq, windowFreq)) return true;
        }

        return false;
    }

    private bool arrEqual(int[] a, int[] b) {
        for (int i = 0; i < 26; i++) {
            if (a[i] != b[i]) return false;
        }

        return true;
    }
}
