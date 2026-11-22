public class Solution {
    public int FindDuplicate(int[] nums) {
        HashSet<int> set = new();
        foreach (int num in nums) {
            if (set.Contains(num)) return num;
            set.Add(num);
        }

        return 0;
    }
}
