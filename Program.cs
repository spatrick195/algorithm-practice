using AlgorithmPractice.Arrays.Sorting;

Console.WriteLine("Hello, World!");

RunAndPrintBubbleSort();

void RunAndPrintBubbleSort()
{
    var nums = new[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
    Console.WriteLine(string.Join(", ", BubbleSort.Sort(nums)));
}