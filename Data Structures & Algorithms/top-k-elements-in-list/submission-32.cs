public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> map = new();
        for (int i = 0; i < nums.Length; i++) {
            if (!map.ContainsKey(nums[i])) {
                map[nums[i]] = 0;
            }

            map[nums[i]]++;
        }

        return map
            .OrderByDescending(x => x.Value)
            .Take(k)
            .Select(x => x.Key)
            .ToArray();
    }
}
