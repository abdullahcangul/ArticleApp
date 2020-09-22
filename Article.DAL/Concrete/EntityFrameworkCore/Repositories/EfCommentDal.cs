using ArticleApp.Core.DAL.EntityFrameworkCore;
using ArticleApp.DAL.Abstract;
using ArticleApp.DAL.Concrete.Contexts;
using ArticleApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArticleApp.DAL.Concrete.EntityFrameworkCore.Repositories
{
    public class EfCommentDal: EfEntityRepositoryBase<Comment, ArticleAppContext>, ICommentDal
    {
    }
}
