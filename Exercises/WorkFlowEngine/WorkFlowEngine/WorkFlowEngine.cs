using System.Collections.Generic;

namespace WorkFlowEngine
{
    public class WorkFlowEngine
    {
        private readonly List<IWorkFlow> _activityList = new List<IWorkFlow>();

        public WorkFlowEngine(params IWorkFlow[] workFlow)
        {
            foreach (var activity in workFlow)
            {
                _activityList.Add(activity);
            }
            
        }

        public void Run()
        {
            foreach (var activity in _activityList)
            {
                activity.Execute();
            }
        }

    }
}