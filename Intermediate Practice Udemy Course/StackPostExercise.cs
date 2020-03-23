using System;
using System.Collections.Generic;
using System.Text;

namespace Intermediate_Practice_Udemy_Course
{
    class StackPostExercise
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }

        private int currentVoteValue; 
        public StackPostExercise(string title, string description)
        {
            Title = title;
            Description = description;
            DateCreated = DateTime.Now;
            currentVoteValue = 0;
        }

        public void Upvote()
        {
            currentVoteValue++;
        }

        public void Downvote()
        {
            currentVoteValue--;
        }

        public int GetTotalVoteValue()
        {
            return currentVoteValue;
        }

    }
}
