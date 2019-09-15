using System;
using System.Collections.Generic;

namespace MyExercicoResolvido2.Entities
{
    class Post
    {
        public string Title { get; set; }
        public DateTime Moment { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Post()
        {
        }
        public Post(string title) : this()
        {
            Title = title;
        }
        public Post(string title, string content) : this(title)
        {
            Content = content;
        }

        public override string ToString()
        {
            return Title.ToUpper() + "\n" + Likes + " Likes - " + Moment + "\n" + Content;          
        }
        public void ShowComments()
        {
            foreach (Comment item in Comments)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
