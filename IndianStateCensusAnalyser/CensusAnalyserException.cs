using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStateCensusAnalyser
{
    public class CensusAnalyserException : Exception
    {
        /// <summary>
        /// This enum ExceptionType for diffrent exception which is constant
        /// </summary>
        public enum ExceptionType
        {
            FILE_NOT_FOUND, INVALID_FILE_TYPE, INCORRECT_HEADER, INCORRECT_DELIMITER, NO_SUCH_COUNTRY
        }

        public ExceptionType exceptionType;

        /// <summary>
        /// This Parametrized Constructor Initialize a new instance of this class.
        /// </summary>

        public CensusAnalyserException(ExceptionType exceptionType, string message) : base(message)
        {
            this.exceptionType = exceptionType;
        }
    }
}
