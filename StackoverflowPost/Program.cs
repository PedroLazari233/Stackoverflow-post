using StackoverflowPost;

internal class Program
{
    private static void Main(string[] args)
    {
        var post = new Post();

        Console.Write("Create a title for a StackOverflow post: ");
        post.Title = Console.ReadLine();

        Console.Write("Create a description for the same post: ");
        post.Description = Console.ReadLine();

        while (true)
        {
            Console.WriteLine("UpVote by inserting U and DownVote by inserting D: ");
            var vote = Console.ReadLine();

            switch(vote)
            {
                case "U":
                    post.UpVote(); break;
                case "D":
                    post.DownVote(); break;
                default:
                    Console.WriteLine("Wrong input!"); break;
            }

            Console.WriteLine("Do you want to vote again?");
            var input = Console.ReadLine();

            if (input == "No")
                break;

        }

        Console.WriteLine("Total votes for the post " + post.Title + " is " + post.CurrentVoteValue);
    }
}