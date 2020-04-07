using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkflowExercise
{
    public class SendEmail : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Sending Email to Owner of video");
        }
    }
}
