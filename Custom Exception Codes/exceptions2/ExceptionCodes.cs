using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Exception_Codes.exceptions2
{
    abstract class ExceptionCodes
    {
        // exception code ranges
        public int GeneralExceptionCode = 0;

        public int ResourceExceptionCode = 1000;
        public int DatabaseExceptionCode = 1100;
        public int CacheExceptionCode = 1200;

        public int IntegrationExceptionCode = 10000;

        // Exception issue codes
        public int Timeout = 10;
        public int NotFound = 20;
        public int NullReference = 30;
        public int InvalidOperation = 40;
        public int Unauthorized = 50;
        public int Denied = 60;

        public int GetGeneralExceptionCode()
        {
            return GeneralExceptionCode;
        }

        public int GetResourceExceptionCode()
        {
            return ResourceExceptionCode;
        }

        public int GetDatabaseExceptionCode()
        {
            return DatabaseExceptionCode;
        }

        public int GetDatabaseTimeoutExceptionCode()
        {
            return GetDatabaseExceptionCode() + Timeout;
        }

        public int GetIntegrationExceptionCode()
        {
            return IntegrationExceptionCode;
        }

        public int GetIntegrationExceptionCodeWithResourceCode(int code)
        {
            return IntegrationExceptionCode + code;
        }
    }
}
