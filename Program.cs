// See https://aka.ms/new-console-template for more information

using AlgorithmPractice;

Console.WriteLine("Hello, World!");


void RunAndPrintBubbleSort()
{
    var bubbleSort = new BubbleSort();
    var nums = new[] { 9, 8, 7, 6, 5, 4, 3, 2, 1};
    Console.WriteLine(string.Join(", ", bubbleSort.Sort(nums)));
}