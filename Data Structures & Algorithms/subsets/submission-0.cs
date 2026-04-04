public class Solution {
    public List<List<int>> Subsets(int[] nums) {
        List<List<int>> result = new();
        result.Add(new List<int>());

        foreach (int num in nums) {
            int count = result.Count;
            for (int i = 0; i < count; i++) {
                List<int> newList = new List<int>(result[i]);
                newList.Add(num);
                result.Add(newList);
            }
        }

        return result;
    }
}
