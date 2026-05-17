public class Solution {
    public int CharacterReplacement(string s, int k) {
        int[] count = new int[26];
        int maxFreq = 0;
        int left = 0;
        int result = 0;

        for (int i = 0; i < s.Length; i++) {
            count[s[i] - 'A']++;
            maxFreq = count.Max();

            int window = (i - left) + 1;
            if (window - maxFreq > k) {
                count[s[left] - 'A']--;
                left++;
                maxFreq = count.Max();
            }

            result = Math.Max(result, (i - left) + 1);
        }

        return result;
    }
}
