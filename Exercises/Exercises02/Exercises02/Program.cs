using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exercises02
{
    class Program
    {
        static void Main(string[] args)
        {
            var post = new Post("The Bananas","A group of monkeys love bananas");
            while (true)
            {


                Console.WriteLine("Vote down or up?");
                var input = Console.ReadLine();
                if (input == "1")
                    post.DownVote();
                else
                    post.UpVote();

                Console.WriteLine(post.Title + post.Description + post._votecount + post.DateCreated);
            }
        }
    }
}
