using _7AprelTask;
using System.Reflection.Metadata;
using System.Xml.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        //Post post = new Post("abfghh", "yy", "fgh");
        //Post post1 = new Post("abfghh", "yy", "fgh");
        //Post post2 = new Post("abfghh", "yy", "fgh");
        //Post post3 = new Post("abfghh", "yy", "fgh");
        //Console.WriteLine(post3.Id);
        //post.Arrayin(post);
        //foreach (var item in post.Posts)
        //{
        //    Console.WriteLine(item.Id);

        //    Console.WriteLine(item.Description);
        //}




      // User[] users = new User[5];
        User user = new User("elvin", "azizli", "a");
        User user1 = new User("elvin", "azizli", "a");
        User user2 = new User("elvin", "azizli", "a");
        User user3 = new User("elvin", "azizli", "a");
        User user4 = new User("elvin", "azizli", "a");
        user.ArrCheck(user1);

        Console.WriteLine();

        foreach (var item in user.Users)
        {
            Console.WriteLine();

           // Console.WriteLine(item.Name);
        }
        //Comment comment = new Comment("salam");
        //Comment comment1 = new Comment("salam");
        //Comment comment2 = new Comment("salam");
        //Comment comment3 = new Comment("salam");

        //foreach (var item in comment.Comments)
        //{
        //    Console.WriteLine(item.Createdate);
        //}





    }
}