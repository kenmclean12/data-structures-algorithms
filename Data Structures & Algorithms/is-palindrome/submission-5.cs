public class Solution {
    public bool IsPalindrome(string s) {
       var trimmed = s.Trim();
       int left = 0;
       int right = trimmed.Length - 1;

       while (left < right) {
          if (!char.IsLetterOrDigit(trimmed[left])) {
            left++;
            continue;
          }

          if (!char.IsLetterOrDigit(trimmed[right])) {
            right--;
            continue;
          }

          if (char.ToLower(trimmed[left]) != char.ToLower(trimmed[right])) {
            return false;
          }

          left++;
          right--;
       }

       return true;
    }
}
