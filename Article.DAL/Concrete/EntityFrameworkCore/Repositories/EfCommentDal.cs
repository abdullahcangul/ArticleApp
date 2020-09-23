using ArticleApp.Core.DAL.EntityFrameworkCore;
using ArticleApp.DAL.Abstract;
using ArticleApp.DAL.Concrete.Contexts;
using ArticleApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArticleApp.DAL.Concrete.EntityFrameworkCore.Repositories
{
    public class EfCommentDal: EfEntityRepositoryBase<Comment, ArticleAppContext>, ICommentDal
    {
        public List<Comment> GetAllWithSubComments(int articleId, int? parentId)
        {
            List<Comment> result = new List<Comment>();
            GetComments(articleId, parentId, result);
            return result;
        }

        private void GetComments(int articleId, int? parentId, List<Comment> result)
        {
            using var context = new ArticleAppContext();
            var comments =  context.Comments.Where(I => I.ArticleID == articleId && I.ParentCommentId == parentId).OrderByDescending(I => I.CommentDate).ToList();
            if (comments.Count > 0)
            {
                foreach (var comment in comments)
                {
                    if (comment.SubComments == null)
                        comment.SubComments = new List<Comment>();

                    GetComments(comment.ArticleID, comment.Id, comment.SubComments);

                    if (!result.Contains(comment))
                    {
                        result.Add(comment);
                    }
                }
            }
        }
    }
}
