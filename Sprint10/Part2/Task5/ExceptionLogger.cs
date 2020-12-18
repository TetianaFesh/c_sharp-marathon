using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint10.Part2.Task5
{
    class ExceptionLogger
    {
        public ILogger _loger;
        public ExceptionLogger(ILogger loger)
        {
            _loger = loger;
        }
        public void LogIntoFile(Exception mException)
        {
            FileLogger objFileLogger = new FileLogger();
            objFileLogger.LogMessage(GetUserReadableMessage(mException));
        }
        public void LogIntoDataBase(Exception mException)
        {
            DbLogger objDbLogger = new DbLogger();
            objDbLogger.LogMessage(GetUserReadableMessage(mException));
        }
        private string GetUserReadableMessage(Exception ex)
        {
            string strMessage = string.Empty;
            //code to convert Exception's stack trace and message to user   
            // readable format.  
            return strMessage;
        }
        public void LogException(Exception ex)
        {

        }
    }
}
