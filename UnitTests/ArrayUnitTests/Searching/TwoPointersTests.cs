using AlgorithmPractice.Arrays.Searching;
using FluentAssertions;

// ReSharper disable ConvertToConstant.Local
// ReSharper disable StringLiteralTypo

namespace UnitTests.ArrayUnitTests.Searching;

public class TwoPointersTests
{
    [Fact]
    public void CheckPalindrome_StringIsPalindrome_ReturnsTrue()
    {
        // Arrange
        const string str = "madam";
        // Act
        var result = TwoPointers.CheckPalindrome(str);
        // Assert
        result.Should().BeTrue();
    }

    [Fact]
    public void CheckPalindrome_StringIsNotPalindrome_ReturnsFalse()
    {
        // Arrange
        const string str = "sir";
        // Act
        var result = TwoPointers.CheckPalindrome(str);
        // Assert
        result.Should().BeFalse();
    }

    [Fact]
    public void TwoSum_HasNumbersEqualToTarget_ShouldReturnIndex()
    {
        // Arrange
        var target = 9;
        var nums = new[] { 1, 2, 3, 4, 5 };

        // Act
        var result = TwoPointers.TwoSum(nums, target);

        // Assert
        result.Should().Be(nums.Length - 2);
    }

    [Fact]
    public void TwoSum_HasNumbersNotEqualToTarget_ShouldReturnMinusOne()
    {
        // Arrange
        var target = 18;
        var nums = new[] { 1, 2, 3, 4, 10 };

        // Act
        var result = TwoPointers.TwoSum(nums, target);

        // Assert
        result.Should().Be(-1);
    }

    [Fact]
    public void CombineIntegerArrays_ShouldReturnCombinedSortedArray()
    {
        // Arrange
        int[] arr1 = { 1, 3, 5 };
        int[] arr2 = { 2, 4, 6, 8 };
        var expected = new List<int> { 1, 2, 3, 4, 5, 6, 8 };

        // Act
        var result = TwoPointers.CombineIntegerArrays(arr1, arr2);

        // Assert
        result.Should().BeEquivalentTo(expected);
    }


    [Fact]
    public void CheckSubsequence_SubsequenceExists_ShouldReturnTrue()
    {
        // Arrange
        var str1 = "abc";
        var str2 = "abcdefg";

        // Act
        var result = TwoPointers.CheckSubsequence(str1, str2);

        // Assert
        result.Should().BeTrue();
    }

    [Fact]
    public void CheckSubsequence_SubsequenceDoesNotExist_ShouldReturnFalse()
    {
        // Arrange
        var str1 = "abc";
        var str2 = "xyz";

        // Act
        var result = TwoPointers.CheckSubsequence(str1, str2);

        // Assert
        result.Should().BeFalse();
    }

    [Fact]
    public void SortedSquares_PositiveNumbers_ReturnsSortedSquares()
    {
        // Arrange
        int[] nums = { 2, 4, 6 };
        int[] expected = { 4, 16, 36 };

        // Act
        var result = TwoPointers.SortedSquares(nums);

        // Assert
        result.Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void SortedSquares_NegativeNumbers_ReturnsSortedSquares()
    {
        // Arrange
        int[] nums = { -3, -2, -1 };
        int[] expected = { 1, 4, 9 };

        // Act
        var result = TwoPointers.SortedSquares(nums);

        // Assert
        result.Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void SortedSquares_MixedNumbers_ReturnsSortedSquares()
    {
        // Arrange
        int[] nums = { -5, -3, 0, 2, 4 };
        int[] expected = { 0, 4, 9, 16, 25 };

        // Act
        var result = TwoPointers.SortedSquares(nums);

        // Assert
        result.Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void ReverseString_WordArray_ReturnsReversedArray()
    {
        // Arrange
        var input = "Hello";
        var expected = "olleH";

        // Act
        var result = TwoPointers.ReverseString(input);

        // Assert
        result.Should().BeEquivalentTo(expected);
    }
}