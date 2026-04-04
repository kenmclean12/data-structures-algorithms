class Solution {
    /**
     * @param {number[]} nums
     * @return {number[]}
     */
    getConcatenation(nums) {
        const result = [...nums];

        for (let i = 0; i < nums.length; i++) {
            result.push(nums[i]);
        }

        return result;
    }
}
