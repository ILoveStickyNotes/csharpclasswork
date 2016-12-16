using System;

namespace Exercises02
{
    class Post
    {
        public int _votecount { get; private set; }
        public string Title,Description;
        public DateTime DateCreated = DateTime.Now;

        public Post(string title, string description)
        {
            Title = title;
            Description = description;
        }

        public void UpVote()
        {
            _votecount += 1;
        }

        public void DownVote()
        {
            _votecount -= 1;
        }
    }
}