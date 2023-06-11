namespace AlgorithmPractice;

public class Result
{
    public Result(string title, string input, string output)
    {
        Title = title;
        Input = input;
        Output = output;
    }

    public string Title { get; }
    public string Input { get; }
    public string Output { get; }

    public override string ToString()
    {
        return $"{nameof(Title.ToUpper)}: {Title}. " +
               $"{nameof(Input.ToUpper)}: {Input}. " +
               $"{nameof(Output.ToUpper)}: {Output}.";
    }
}