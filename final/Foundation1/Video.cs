using System;

class Video
{
    public string _title;
    public string _author;
    public int _lengthSec;
    public List<Comment> Comments = new List<Comment>();

    public int GetNumberOfComments()
    {
        return Comments.Count;
    }

    public void AddComment(string commenterName, string text)
    {
        Comment comment = new Comment {_commenterName = commenterName, _text = text };
        Comments.Add(comment);
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_lengthSec} seconds");
        Console.WriteLine($"Number of Comments: {Comments.Count}");

        if (Comments.Count > 0)
        {
            Console.WriteLine("Comments: ");
            foreach (Comment comment in Comments)
            {
                comment.CommentDetails();
            }
        }
        Console.WriteLine();
    }
}