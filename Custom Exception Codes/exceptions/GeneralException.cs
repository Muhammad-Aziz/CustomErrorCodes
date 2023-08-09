using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Exception_Codes.exceptions
{
    public class GeneralException : Exception
    {
        private readonly int _code = 0;
        private string _message;

        protected int Timeout = 10;
        protected int NotFound = 20;
        protected int NullReference = 30;
        protected int InvalidOperation = 40;
        protected int Unauthorized = 50;
        protected int Denied = 60;

        public GeneralException(string message) : base(message) 
        {
            ProcessException(message, _code);
        }

        protected void ProcessException(string message, int code)
        {
            UpdateMessage(message, code);
            string trace = GetTraceCode();
            LogError(code, trace, message);
        }

        protected string GetTraceCode()
        {
            var stackTrace = new StackTrace(true);
            var stackFrame = stackTrace.GetFrame(0);
            var trace = string.Concat(":");
            if (stackFrame != null)
            {
                var fileName = Path.GetFileName(stackFrame.GetFileName());
                var lineNumber = stackFrame.GetFileLineNumber();
                trace = string.Concat(fileName, " : ", lineNumber);
            }
            return trace;
        }

        protected void LogError(int code, string trace, string message)
        {
            Console.WriteLine($"Exception ['E{code}' - '{trace}']: '{message}'");
        }

        protected void UpdateMessage(string message, int code)
        {
            _message = string.Concat("[MU", code, "] ", message);
        }

        public override string Message
        {
            get
            {
                return _message;
            }
        }
    }
}
