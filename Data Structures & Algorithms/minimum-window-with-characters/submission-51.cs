public class Solution {
    public string MinWindow(string s, string t) {
       if (s.Length < t.Length) return "";
       int[] tCount = new int[128];
       for (int i = 0; i < t.Length; i++) tCount[t[i]]++;

       int[] sCount = new int[128];
       int left = 0;

       int start = 0;
       int minWindow = int.MaxValue;

       for (int i = 0; i < s.Length; i++) {
         sCount[s[i]]++;
         while (CountsValid(sCount, tCount)) {
            int window = (i - left) + 1;
            if (window < minWindow) {
                start = left;
                minWindow = window;
            }

            sCount[s[left]]--;
            left++;
         }
       }

       return minWindow == int.MaxValue ? "" : s.Substring(start, minWindow);
    }

    private bool CountsValid(int[] s, int[] t) {
        for (int i = 0; i < 128; i++) if (s[i] < t[i]) return false;
        return true;
    }
}
