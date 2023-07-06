using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Exception_Codes.exceptions2
{
    public class CustomException : Exception
    {
        private string _message;

        public CustomException(string message, int code, int response_err_code = 0) : base(message)
        {
            UpdateMessage(message, code);
        }

        protected void UpdateMessage(string message, int code)
        {
            _message = string.Concat("[E", code, "] ", message);
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
