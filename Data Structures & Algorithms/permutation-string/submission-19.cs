public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if (s2.Length < s1.Length) return false;
        int[] s1Count = new int[26];
        int[] s2WindowCount = new int[26];

        for (int i = 0; i < s1.Length; i++) {
            s1Count[s1[i] - 'a']++;
            s2WindowCount[s2[i] - 'a']++;
        }
        if (ArraysEqual(s1Count, s2WindowCount)) return true;

        int left = 0;
        for (int i = s1.Length; i < s2.Length; i++) {
            s2WindowCount[s2[i] - 'a']++;
            s2WindowCount[s2[left] - 'a']--;
            if (ArraysEqual(s1Count, s2WindowCount)) return true;
            left++;
        }

        return false;
    }

    private bool ArraysEqual(int[] a, int[] b) {
        for (int i = 0; i < 26; i++) if (a[i] != b[i]) return false;
        return true;
    }
}
