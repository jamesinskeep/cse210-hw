public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }


    public List<Comment> Comments
    {
        get { return _comments; }
    }   
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    private int CountComments()
    {
        return _comments.Count;
    }

    public void PrintVideo()
    {
        Console.Write($"Title: {_title} ;");
        Console.Write($"Author: {_author} ;");
        Console.Write($"Length: {_length} seconds ;");
        Console.WriteLine($"Comments: {CountComments()}");
    }
}