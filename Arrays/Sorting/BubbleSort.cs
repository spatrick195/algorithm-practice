namespace AlgorithmPractice.Arrays.Sorting;

public abstract class BubbleSort
{
    public static IEnumerable<int> Sort(int[] nums)
    {
        var n = nums.Length - 1;
        for (var i = 0; i < n; i++)
        for (var j = 0; j < n; j++)
            if (nums[j] > nums[j + 1])
                Swap(nums, j);

        return nums;
    }

    #region Helpers

    // ReSharper disable once SwapViaDeconstruction
    private static void Swap(IList<int> nums, int j)
    {
        // could use deconstruction but easier to read like this
        var temp = nums[j]; // temp variable to value

        // perform the swap
        nums[j] = nums[j + 1];
        nums[j + 1] = temp;
    }

    #endregion
}