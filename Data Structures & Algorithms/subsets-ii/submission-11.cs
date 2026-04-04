public class Solution {
    public List<List<int>> SubsetsWithDup(int[] nums) {
        Array.Sort(nums);
        List<List<int>> result = new();
        HashSet<string> used = new();
        result.Add(new List<int>());

        foreach (int num in nums) {
            int count = result.Count;
            for (int i = 0; i < count; i++) {
                var newList = new List<int>(result[i]);
                newList.Add(num);
                string key = string.Join(",", newList);
                if (!used.Contains(key)) {
                    result.Add(newList);
                    used.Add(key);
                }
            }
        }

        return result;
    }
}
