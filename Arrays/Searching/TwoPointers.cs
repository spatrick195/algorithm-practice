namespace AlgorithmPractice.Arrays.Searching;

/*
  Two-pointers is a common technique used to solve array and string problems.
  
  It involves having two integer variables that both move along an iterable. In this article, we are focusing on arrays and strings. 
  
  This means we will have two integers, usually named something like i and j, or left and right which each represent an index of the array or string
 */
public static class TwoPointers
{
    public static bool CheckPalindrome(string str)
    {
        var left = 0;
        var right = str.Length - 1;
        var lowerCaseString = str.ToLower();
        while (left < right)
        {
            if (lowerCaseString.ElementAt(left) != lowerCaseString.ElementAt(right)) return false;

            left++;
            right--;
        }

        return true;
    }

    public static int TwoSum(IReadOnlyList<int> nums, int target)
    {
        var left = 0;
        var right = nums.Count - 1;

        while (left < right)
        {
            var current = nums[left] + nums[right];
            if (current == target) return left;

            if (current > target)
                right--;
            else
                left++;
        }

        return -1;
    }

    public static IEnumerable<int> CombineIntegerArrays(int[] arr1, int[] arr2)
    {
        var ans = new List<int>();
        int i = 0, j = 0;
        while (i < arr1.Length && j < arr2.Length)
            if (arr1[i] < arr2[j])
            {
                ans.Add(arr1[i]);
                i++;
            }
            else
            {
                ans.Add(arr2[j]);
                j++;
            }

        while (i < arr1.Length)
        {
            ans.Add(arr1[i]);
            i++;
        }

        while (j < arr2.Length)
        {
            ans.Add(arr2[j]);
            j++;
        }

        return ans;
    }

    public static bool CheckSubsequence(string str1, string str2)
    {
        var i = 0;
        var j = 0;

        while (i < str1.Length && j < str2.Length)
        {
            if (str1[i] == str2[j]) i++;
            j++;
        }

        return i == str1.Length;
    }

    public static IEnumerable<int> SortedSquares(int[] nums)
    {
        var n = nums.Length;
        var result = new int[n];
        int left = 0, right = n - 1;
        var i = n - 1;

        while (left <= right)
            if (Math.Abs(nums[left]) > Math.Abs(nums[right]))
            {
                result[i--] = nums[left] * nums[left];
                left++;
            }
            else
            {
                result[i--] = nums[right] * nums[right];
                right--;
            }

        return result;
    }

    public static string ReverseString(string str)
    {
        var characters = str.ToCharArray();
        var left = 0;
        var right = characters.Length - 1;
        while (left <= right)
        {
            (characters[left], characters[right]) = (characters[right], characters[left]);
            left++;
            right--;
        }

        var result = characters.Aggregate("", (current, c) => current + c);
        return result;
    }
}