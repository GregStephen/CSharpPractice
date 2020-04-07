using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkflowExercise
{
    public class WorkFlowEngine
    {
        public void Run(IWorkflow workflow)
        {
            foreach (var item in workflow.GetFlow())
            {
                item.Execute();
            }
        }
    }
}
