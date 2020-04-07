using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkflowExercise
{
    public interface IWorkflow
    {
        void AddToFlow(IActivity activity);
        IEnumerable<IActivity> GetFlow();
    }
}
