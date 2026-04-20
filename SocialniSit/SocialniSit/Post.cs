using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialniSit
{
    internal class Post
    {
        private string title;
        private string content;
        private List<Comment> comments;
        private User author;

        public Post(string title, string content, User author)
        {
            this.title = title;
            this.content = content;
            this.author = author;
            this.comments = new List<Comment>();
        }


        public string Title { get => title; set => title = value; }
        public string Content { get => content; set => content = value; }
        internal List<Comment> Comments { get => comments; set => comments = value; }
        internal User Author { get => author; set => author = value; }
   public void Introduce() {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Title: " + this.Title);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Content: " + this.Content);
            Console.ForegroundColor = ConsoleColor.Blue;
            foreach (Comment comment in Comments) {
                comment.Introduce();
            }
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void AddComment(Comment comment) { 
        comments.Add(comment);
        }

    }
}
