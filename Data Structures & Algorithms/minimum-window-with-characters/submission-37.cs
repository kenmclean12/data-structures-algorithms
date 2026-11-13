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
         while (CountsValid(tCount, sCount)) {
            int window = (i - left) + 1;
            if (window < minWindow) {
                minWindow = window;
                start = left;
            }

            sCount[s[left]]--;
            left++;
         }
       }

       return minWindow == int.MaxValue ? "" : s.Substring(start, minWindow);
    }

    private bool CountsValid(int[] tCount, int[] sCount) {
        for (int i = 0; i < 128; i++) {
            if (sCount[i] < tCount[i]) return false;
        }

        return true;
    }
}
