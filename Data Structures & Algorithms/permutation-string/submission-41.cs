public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if (s2.Length < s1.Length) return false;
        int[] s1Count = new int[128];
        int[] s2Count = new int[128];

        for (int i = 0; i < s1.Length; i++) {
          s1Count[s1[i]]++;
          s2Count[s2[i]]++;
        }

        if (CountsEqual(s1Count, s2Count)) return true;

        for (int i = s1.Length; i < s2.Length; i++) {
          s2Count[s2[i]]++;
          s2Count[s2[i - s1.Length]]--;
          if (CountsEqual(s1Count, s2Count)) return true;
        }

        return false;
    }

    private bool CountsEqual(int[] a, int[] b) {
      for (int i = 0; i < 128; i++) if (a[i] != b[i]) return false;
      return true;
    }
}
