using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace StackoverflowPost
{
    internal class Post
    {
        public String Title { get; set; }
        public String Description { get; set; }
        public DateTime DateAndTime { get; set; }
        public int CurrentVoteValue { get; private set; }

        public void UpVote()
        {
            CurrentVoteValue++;
        }

        public void DownVote()
        {
            CurrentVoteValue--;
        }
    }
}
