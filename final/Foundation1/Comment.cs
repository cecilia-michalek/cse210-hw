using System;

class Comment
{
    public string _commenterName;
    public string _text;

    public void CommentDetails()
    {
        Console.WriteLine($"{_commenterName}: {_text}");
    }

}