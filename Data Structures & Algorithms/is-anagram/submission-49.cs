public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;
        int[] count = new int[128];

        for (int i = 0; i < s.Length; i++) {
            count[s[i]]++;
            count[t[i]]--;
        }

        for (int i = 0; i < 128; i++) {
            if (count[i] != 0) return false;
        }

        return true;
    }
}
