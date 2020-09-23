using System;
using System.Collections.Generic;
using System.Text;

namespace ArticleApp.Core.Utilty.Results
{
    public interface IDataResult<out T> : IResult
    {
        T Data { get; }
    }
}
