using Microsoft.Extensions.Logging;
using NLog;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArticleApp.Business.Tools.LogTool
{
    class NLogAdapter:ICustomLogger
    {
        public void LogError(string message)
        {
            var logger = LogManager.GetLogger("loggerFile");
            logger.Log(NLog.LogLevel.Error, message);
        }
    }
}
