public class Solution {
    public int[] BuildArray(int[] nums) {
        var result = new int[nums.Length];
        for (var i = 0; i < nums.Length; i++)
        {
            result[i] = nums[nums[i]];
        }
        Console.WriteLine(result);
        return result;
    }
}