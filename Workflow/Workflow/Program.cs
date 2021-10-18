using System;

namespace Workflow
{
    class Program
    {
        static void Main(string[] args)
        {
            var workflowEngine = new WorkflowEngine();
            workflowEngine.AddActivity(new ConnectToServer());
            workflowEngine.AddActivity(new PrintCurrentDate());
            workflowEngine.AddActivity(new UploadVideo());
            workflowEngine.AddActivity(new ModifyUploadDescription());
            workflowEngine.AddActivity(new PrintCurrentDate());
            workflowEngine.AddActivity(new CloseConnection());
            workflowEngine.ExecuteActivities();
        }
    }
}
