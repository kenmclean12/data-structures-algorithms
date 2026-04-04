public class Solution {
    public int CharacterReplacement(string s, int k) {
        int[] freq = new int[26];
        int left = 0;
        int maxFreq = 0;
        int maxLength = 0;

        for (int i = 0; i < s.Length; i++) {
            var freqInt = s[i] - 'A';
            var c = s[i];
            freq[freqInt]++;
            maxFreq = Math.Max(maxFreq, freq[freqInt]);

            var window = i - left + 1;
            if (window - maxFreq > k) {
                freq[s[left] - 'A']--;
                left++;
            }

            maxLength = Math.Max(maxLength, i - left + 1);
        }
 
        return maxLength;
    }
}
