using AlgorithmPractice.Arrays.Searching;
using AlgorithmPractice.Arrays.Sorting;

// ReSharper disable ConvertToConstant.Local
// ReSharper disable StringLiteralTypo

namespace AlgorithmPractice.Util;

public static class ArrayMethodRunner
{
    #region Sorting

    public static void RunAndPrintBubbleSort()
    {
        var bubbleSortInput = new[] { 5, 4, 3, 2, 1 };
        var result = BubbleSort.Sort(bubbleSortInput);

        var bubbleSortResult = new Result(
            "Bubble Sort",
            $"[{string.Join(", ", bubbleSortInput)}]",
            string.Join(", ", result));

        WriteToConsole(bubbleSortResult);
    }

    #endregion

    #region Searching

    public static void RunAndPrintAllTwoPointerAlgorithms()
    {
        var palindromeInput = "madam";
        int[] twoSumInput = { 1, 2, 3, 4, 5 };
        var twoSumTarget = 9;
        var subsequenceInput = "abc";
        var subsequenceTarget = "abcdefg";
        int[] combineInput1 = { 1, 3, 5 };
        int[] combineInput2 = { 2, 4, 6, 8 };
        int[] sortedSquareInput = { 2, 4, 6 };
        var reverseStringInput = "Hello World";

        var algorithms = new List<Result>
        {
            // Check Palindrome
            new(
                "Check Palindrome",
                palindromeInput,
                TwoPointers.CheckPalindrome(palindromeInput).ToString()),

            // Two Sum
            new(
                "Two Sum",
                $"[{string.Join(", ", twoSumInput)}], Target: {twoSumTarget}",
                TwoPointers.TwoSum(twoSumInput, twoSumTarget).ToString()),

            // Check subsequence
            new(
                "Check Subsequence",
                $"'{subsequenceInput}', '{subsequenceTarget}'",
                TwoPointers.CheckSubsequence(subsequenceInput, subsequenceTarget).ToString()),

            // Combine & Sort Arrays
            new(
                "Combine & Sort Arrays",
                $"[{string.Join(", ", combineInput1)}], [{string.Join(", ", combineInput2)}]",
                string.Join(", ", TwoPointers.CombineIntegerArrays(combineInput1, combineInput2))),

            // Sorted Squares
            new(
                "Sorted Squares",
                $"[{string.Join(", ", sortedSquareInput)}]",
                string.Join(", ", TwoPointers.SortedSquares(sortedSquareInput))),
            // Reverse String
            new("Reverse String", reverseStringInput, TwoPointers.ReverseString(reverseStringInput))
        };

        WriteToConsole(algorithms);
    }

    #endregion

    #region Helper

    private static void WriteToConsole(Result result)
    {
        ConsoleHelper.WriteTitle(result.Title);
        ConsoleHelper.WriteInput($"INPUT: {result.Input}. ");
        ConsoleHelper.WriteOutput($"RESULT: {result.Output}");
    }

    private static void WriteToConsole(IEnumerable<Result> results)
    {
        foreach (var result in results)
        {
            ConsoleHelper.WriteTitle(result.Title);
            ConsoleHelper.WriteInput($"INPUT: {result.Input}. ");
            ConsoleHelper.WriteOutput($"RESULT: {result.Output}");
        }
    }

    #endregion
}