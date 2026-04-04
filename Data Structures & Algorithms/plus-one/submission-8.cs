public class Solution {
    public int[] PlusOne(int[] digits) {
        string intStr = string.Join("", digits);
        long number = long.Parse(intStr) + 1;
        string str = number.ToString();
        int[] result = str.Select(c => c - '0').ToArray();
        return result;
    }
}
