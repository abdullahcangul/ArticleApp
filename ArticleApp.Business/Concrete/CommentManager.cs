using ArticleApp.Business.Abstract;
using ArticleApp.Core.DAL;
using ArticleApp.Core.Utilty.Results;
using ArticleApp.DAL.Abstract;
using ArticleApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArticleApp.Business.Concrete
{
    public class CommentManager : GenericManager<Comment>, ICommentService
    {
        private readonly ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal) :base(commentDal)
        {
            _commentDal = commentDal;
        }

        public IDataResult<List<Comment>> GetAllWithSubComments(int articleId, int? parentId)
        {
           return new SuccessDataResult<List<Comment>>(_commentDal.GetAllWithSubComments(articleId, parentId));
        }
    }
}
