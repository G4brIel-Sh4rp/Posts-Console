using System;
using System.Collections.Generic;
using MyExercicoResolvido2.Entities;

namespace MyExercicoResolvido2
{
    class Program
    {
        static List<Post> Posts = new List<Post>();
        static Post templatePost = new Post();
        static void Main(string[] args)
        {
            AddPost();
            AddPost();
            foreach (Post item in Posts)
            {
                Console.WriteLine();
                Console.WriteLine(item);
                Console.WriteLine("\nComents: \n");
                item.ShowComments();
            }
        }
        public static void AddPost()
        {
            Console.Write("TITLE: ");
            string title = Console.ReadLine();
            Console.WriteLine("Content: ");
            string content = Console.ReadLine();

            Console.Write("Show Comments? [s/n]   ");
            char comment = char.Parse(Console.ReadLine());
            bool boolComent = (comment == 's') ? true : false;

            Console.Write("Show Likes?    [s/n]   ");
            char likes = char.Parse(Console.ReadLine());
            bool boolLike = (likes == 's') ? true : false;

            Console.WriteLine();
            Console.WriteLine("Submit Post? [s/n] ");
            char confirm = char.Parse(Console.ReadLine());
            bool boolConfirm = (confirm == 's') ? true : false;

            if (boolConfirm)
            {
                templatePost = new Post(title, content);
            }

            if (boolComent)
            {
                Console.Write("How much comments there: ");
                int n = int.Parse(Console.ReadLine());
                for(int i = 0; i< n; i++)
                {
                    Console.Write("Comment #{0}: ",i+1);
                    Comment text = new Comment { Text = Console.ReadLine() };
                    templatePost.Comments.Add(text);
                }
            }
            if (boolLike)
            {
                Console.Write("How many Likes recived this post: ");
                int postLikes = int.Parse(Console.ReadLine());
                templatePost.Likes = postLikes;
            }
            Posts.Add(templatePost);
        }
    }
}
