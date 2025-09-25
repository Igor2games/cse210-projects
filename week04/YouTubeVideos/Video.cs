using System.Xml.Schema;

public class Video
{
    private string _title;
    private string _author;
    private int _lenghtSeconds;
    private List<Comment> _comments;

    public Video(string title, string author, int lengthSeconds)
    {
        _title = title;
        _author = author;
        _lenghtSeconds = lengthSeconds;
        _comments = new List<Comment>();
    }

    public string GetTitle()
    {
        return _title;
    }
    public void SetTitle(string title)
    {
        _title = title;
    }
    public string GetAuthor()
    {
        return _author;
    }
    public void SetAuthor(string author)
    {
        _author = author;
    }
    public int GetlenghtSeconds()
    {
        return _lenghtSeconds;
    }
    public void SetlenghtSeconds(int lenghtSeconds)
    {
        _lenghtSeconds = lenghtSeconds;
    }
    public List<Comment> GetComments()
    {
        return _comments;
    }
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    public int CountComments()
    {
        return _comments.Count;
    }
}

