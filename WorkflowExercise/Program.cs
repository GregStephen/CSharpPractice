using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace WorkflowExercise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var workFlow = new Workflow();
            workFlow.AddToFlow(new UploadVideo());
            workFlow.AddToFlow(new SendEmail());
            workFlow.AddToFlow(new SetStatus());
            var workFlowEngine = new WorkFlowEngine();
            workFlowEngine.Run(workFlow);
        }

    }
}
