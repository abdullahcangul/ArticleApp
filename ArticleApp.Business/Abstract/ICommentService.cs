using ArticleApp.Core.Business.Abstract;
using ArticleApp.Core.Utilty.Results;
using ArticleApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArticleApp.Business.Abstract
{
    public interface ICommentService : IGenericService<Comment>
    {
        IDataResult<List<Comment>> GetAllWithSubComments(int articleId, int? parentId);
    }
}
