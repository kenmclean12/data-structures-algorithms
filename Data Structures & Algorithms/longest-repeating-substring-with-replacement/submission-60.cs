public class Solution {
    public int CharacterReplacement(string s, int k) {
        int[] count = new int[26];
        int left = 0;
        int result = 0;

        for (int i = 0; i < s.Length; i++) {
            char lower = char.ToLower(s[i]);
            count[lower - 'a']++;
            int maxCount = count.Max();
            int window = (i - left) + 1;
            if (window - maxCount > k) {
                char lower2 = char.ToLower(s[left]);
                count[lower2 - 'a']--;
                left++;
            }

            result = Math.Max(result, (i - left) + 1);
        }

        return result;
    }
}


