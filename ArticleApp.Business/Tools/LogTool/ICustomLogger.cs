using System;
using System.Collections.Generic;
using System.Text;

namespace ArticleApp.Business.Tools.LogTool
{
    public interface ICustomLogger
    {
        void LogError(string message);
    }
}
