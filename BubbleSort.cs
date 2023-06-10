namespace AlgorithmPractice;

public class BubbleSort
{
    public int[] Sort(int[] nums)
    {
        var length = nums.Length - 1;
        for (var i = 0; i < length; i++)
        {
            for (var j = 0; j < length; j++)
            {
                if (nums[j] > nums[j+1])
                {
                    var temp = nums[j]; // temp variable to value
                    nums[j] = nums[j + 1];
                    nums[j + 1] = temp;
                }
            }
        }

        return nums;
    }
}