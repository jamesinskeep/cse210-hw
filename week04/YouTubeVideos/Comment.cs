public class Comment
{
    private string _commenter;
    private string _text;

    public Comment(string text, string commenter)
    {
        _commenter = commenter;
        _text = text;
    }

    public void PrintComment()
    {
        Console.WriteLine($"     Comment by {_commenter}: {_text}");
    }
}