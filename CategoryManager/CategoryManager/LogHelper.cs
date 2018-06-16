// MIT License
// 
// Copyright (c) 2018 Thomas Stensitzki, Torsten Schlopsnies
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
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
