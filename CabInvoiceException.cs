using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class CabInvoiceException : Exception
    {
        public ExceptionType type;

        public CabInvoiceException(ExceptionType type, string Message) : base(Message)
        {
            this.type = type;
        }
        public enum ExceptionType
        {
            INVALID_DISTANCE,INVALID_TIME,INVALID_USER_ID,INVALID_RIDE_TYPE,NULL_RIDES
        }
    }
}
