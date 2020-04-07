using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkflowExercise
{
    public class SetStatus : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Set status of video to 'Processing'");
        }
    }
}
