public class Solution {
    public int CharacterReplacement(string s, int k) {
        int[] freq = new int[26];
        int length = 0;
        int maxFreq = 0;
        int left = 0;

        for (int i = 0; i < s.Length; i++) {
            var c = s[i];
            freq[s[i] - 'A']++;
            maxFreq = Math.Max(maxFreq, freq[s[i] - 'A']);
            var window = (i - left) + 1;

            if ((window - maxFreq) > k) {
                freq[s[left] - 'A']--;
                left++;
            }

            length = Math.Max(length, (i - left) + 1);
        }

        return length;
    }
}
