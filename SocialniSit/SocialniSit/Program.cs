namespace SocialniSit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User U1 = new User("Karel");
            Post prispevek1 = new Post("Programko", "je super", U1);
            U1.AddPost(prispevek1);
            Post prispevek2 = new Post("Blabla", "není super", U1);
            U1.AddPost(prispevek2);
           
            User U2 = new User("Pepik");
            Comment komentar1 = new Comment("je to skvely", U2);
            User U3 = new User("Anicka");
            Comment komentar2 = new Comment("jo fakt je to skvely", U3);
        prispevek1.AddComment(komentar1);
            prispevek1.AddComment(komentar2);
            U1.Introduce();
        }
    }
}
