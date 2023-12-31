using AlgorithmPractice.Arrays.Sorting;
using AutoFixture;
using FluentAssertions;

namespace UnitTests.ArrayUnitTests.Sorting;

public class BubbleSortTests
{
    private readonly IFixture _fixture;

    public BubbleSortTests()
    {
        _fixture = new Fixture();
    }

    [Fact]
    public void Sort_MultiElementArrayOutOfOrder_ReturnsSortedArray()
    {
        var numsToSort = _fixture.Create<int[]>();

        var result = BubbleSort.Sort(numsToSort);
        result.Should().BeInAscendingOrder();
    }

    [Fact]
    public void Sort_ArrayWithDuplicates_ReturnsSortedArray()
    {
        var numsToSort = new[] { 9, 9, 9, 8, 8, 5, 4, 3, 2, 1 };

        var result = BubbleSort.Sort(numsToSort);
        result.Should().BeInAscendingOrder();
    }
}