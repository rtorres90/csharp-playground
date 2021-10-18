using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Workflow.UnitTests
{
    [TestClass]
    public class WorkflowEngineTests
    {
        [TestMethod]
        public void AddActivity_ActivityIsAdded_ShouldBeAddedToActivitiesList()
        {
            var workflowEngine = new WorkflowEngine();
            workflowEngine.AddActivity(new FakeActivity());

            Assert.AreEqual(10, workflowEngine._activities.Count);
        }
    }

    public class FakeActivity : IActivity
    {
        public void Execute()
        {
            
        }
    }
}
