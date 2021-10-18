using System;
namespace Workflow
{
    public class ConnectToServer : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Connecting to server...");
        }
    }
}
