public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> freqMap = new();
        for (int i = 0; i < nums.Length; i++) {
            if (!freqMap.ContainsKey(nums[i])) {
                freqMap[nums[i]] = 0;
            }

            freqMap[nums[i]]++;
        }

        return freqMap
            .OrderByDescending(x => x.Value)
            .Take(k)
            .Select(x => x.Key)
            .ToArray();
    }
}
