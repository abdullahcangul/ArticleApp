using System;
using System.Collections.Generic;
using System.Text;

namespace ArticleApp.Core.Utilty.Results
{
    public interface IResult
    {
        bool Succes { get; }

        string Message { get; }
    }
}
