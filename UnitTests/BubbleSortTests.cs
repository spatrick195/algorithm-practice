using AlgorithmPractice;
using AutoFixture;
using FluentAssertions;

namespace UnitTests;

public class BubbleSortTests
{
    private readonly IFixture _fixture; 
    private readonly BubbleSort _sut;
    public BubbleSortTests()
    {
        _fixture = new Fixture();
        _sut = new BubbleSort();
    }
    
    [Fact]
    public void Sort_MultiElementArrayOutOfOrder_ReturnsSortedArray()
    {
        var numsToSort = _fixture.Create<int[]>();

        var result = _sut.Sort(numsToSort);
        result.Should().BeInAscendingOrder();
    }
    
    [Fact]
    public void Sort_ArrayWithDuplicates_ReturnsSortedArray()
    {
        var numsToSort = new[]{9,9,9,8,8,5,4,3,2,1};

        var result = _sut.Sort(numsToSort);
        result.Should().BeInAscendingOrder();
    }
}