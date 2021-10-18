using System;
using System.Collections;
using System.Collections.Generic;

namespace Workflow
{
    public class WorkflowEngine
    {
        public IList<IActivity> _activities;
        public WorkflowEngine()
        {
            this._activities = new List<IActivity>();
        }

        public void ExecuteActivities()
        {
            foreach (IActivity activity in this._activities)
            {
                activity.Execute();
            }
        }

        public void AddActivity(IActivity activity)
        {
            this._activities.Add(activity);
        }
    }
}
