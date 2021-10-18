using System;
namespace Workflow
{
    public class CloseConnection : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Closing connection...");
        }
    }
}
