using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialniSit
{
    internal class Comment
    {
        private string content;
        private User author;
public Comment(string content, User author)
        {
            this.content = content;
            this.author = author;
        }
        public string Content { get => content; set => content = value; }
        internal User Author { get => author; set => author = value; }
   
        public void Introduce()
        {
            Console.WriteLine("Author: " + this.Author.Name);
            Console.WriteLine("Content:" + this.Content);
        }
    
    }
}
