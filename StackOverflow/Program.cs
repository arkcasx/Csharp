using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            var post = new Post();
            Console.WriteLine("Creating post...");
            post["title"] = "This is the best title";
            post.DateCreated(DateTime.Now);
            post["description"] = "This post is for educational purpose only";
            post.Display();
            while (true)
            {
                Console.WriteLine("Type up to Upvote or down to Downvote");
                var text = Console.ReadLine();
                post.Voteupanddown(text);
                
            }
        }
    }
}
