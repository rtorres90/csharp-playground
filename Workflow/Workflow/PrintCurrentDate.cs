using System;
namespace Workflow
{
    public class PrintCurrentDate : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Current Date is {0}", DateTime.Now);
        }
    }
}
