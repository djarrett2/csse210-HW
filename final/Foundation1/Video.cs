public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comments> _comments;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comments>();
    }

    public void AddComment(Comments comment)
    {
        _comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }

    public string DisplayVideos()
    {
        return $"Title: {_title}\nAuthor: {_author}\nLength: {_length} seconds\nNumber of Comments: {GetCommentCount()}";
    }

    public List<Comments> GetComments()
    {
        return _comments;
    }
}