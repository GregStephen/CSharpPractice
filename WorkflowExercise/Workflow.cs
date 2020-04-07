using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkflowExercise
{
    public class Workflow : IWorkflow
    {
        private readonly List<IActivity> _flow;

        public Workflow()
        {
            _flow = new List<IActivity>();
        }
        public void AddToFlow(IActivity activity)
        {
            _flow.Add(activity);
        }

        public IEnumerable<IActivity> GetFlow()
        {
            return _flow;
        }
    }
}
