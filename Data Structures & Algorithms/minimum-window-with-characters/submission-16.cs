public class Solution {
    public string MinWindow(string s, string t) {
        int[] tCount = new int[128];
        for (int i = 0; i < t.Length; i++) tCount[t[i]]++;

        int[] sCount = new int[128];
        int left = 0;
        string result = "";

        for (int i = 0; i < s.Length; i++) {
           sCount[s[i]]++;
           while (CountsValid(tCount, sCount)) {
             string subStr = s.Substring(left, (i - left) + 1);
             if (subStr.Length < result.Length || result.Length == 0) result = subStr;

             sCount[s[left]]--;
             left++;
           }
        }

        return result;
    }

    private bool CountsValid(int[] t, int[] s) {
      for (int i = 0; i < 128; i++) if (t[i] > s[i]) return false;
      return true;
    }
}
