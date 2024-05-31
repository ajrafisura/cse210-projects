using System;

    public class Video
    {
        public string _title;
        public string _author;
        public string _length;
        public List<Comment> _comment = new List<Comment>();

        public Video(string title, string author, string length)
        {
            List<Comment> _comment = new List<Comment>();
            _title = title;
            _author = author;
            _length = length;
        }

        public void AddComment(Comment newComment)
        {
            _comment.Add(newComment);
        }

        public void DisplayVideo()
        {
            Console.WriteLine($"{_title} by {_author} ({_length})");
            Console.WriteLine($"Comments ({GetComments()})");
            foreach (Comment comment in _comment)
            {
                comment.DisplayComment();
            }

        }

        public int GetComments()
        {
            return _comment.Count;
        }
    }