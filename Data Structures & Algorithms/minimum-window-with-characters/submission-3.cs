public class Solution {
    public string MinWindow(string s, string t) {
        if (s.Length < t.Length) return "";
        int[] tCount = new int[128];
        for (int i = 0; i < t.Length; i++) {
            tCount[t[i]]++;
        }

        int[] sCount = new int[128];
        int left = 0;
        string result = "";

        for (int i = 0; i < s.Length; i++) {
            sCount[s[i]]++;
            while (isValid(tCount, sCount)) {
                string currentStr = s.Substring(left, (i - left) + 1);
                if (currentStr.Length < result.Length || result.Length == 0) {
                    result = s.Substring(left, (i - left) + 1);
                }

                sCount[s[left]]--;
                left++;
            } 
        }

        return result;
    }

    private bool isValid(int[] a, int[] b) {
        for (int i = 0; i < 128; i++) {
            if (a[i] > b[i]) return false;
        }

        return true;
    }
}
