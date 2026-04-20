using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialniSit
{
    internal class User
    {
        private string name;
        private List<Post> posts;

        public User(string name)
        {
            this.name = name;
            posts = new List<Post>();
        }
        public string Name { get => name; set => name = value; }
        internal List<Post> Posts { get => posts; set => posts = value; }
        public void AddPost(Post post)
        {
            posts.Add(post);
        }
        public void Introduce()
        {
            Console.WriteLine("User name: " + this.Name);
            foreach (var post in posts)
            {
               post.Introduce();
            }

        }
    }
}
