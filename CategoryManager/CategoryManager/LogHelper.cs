using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace CategoryManager
{
    /// <summary>
    /// Class to manage log4net
    /// </summary>
    public class LogHelper
    {
        private static ILog _Logger;
        private static ILog GetLogger()
        {
            ILog log =  LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
            return log;
        }

        static LogHelper()
        {
            _Logger = GetLogger();
        }

        public void WriteInfoLog(string message)
        {
            if (_Logger.IsInfoEnabled)
            {
                _Logger.InfoFormat(message);
            }
        }

        public void WriteDebugLog(string message)
        {
            if (_Logger.IsDebugEnabled)
            {
                _Logger.DebugFormat(message);
            }
        }

        public void WriteErrorLog(string message)
        {
            _Logger.ErrorFormat(message);
        }
    }
}
