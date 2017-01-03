using System;

namespace WorkFlowEngine
{
    public class SendString : IWorkFlow
    {
        private readonly string _message;

        public SendString(string message)
        {
            _message = message;
        }
        public void Execute()
        {
            Console.WriteLine(_message);
        }
    }
}