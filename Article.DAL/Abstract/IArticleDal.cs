using ArticleApp.Core.DAL;
using ArticleApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArticleApp.DAL.Abstract
{
    public interface IArticleDal: IEntityRepository<Article>
    {

    }
}
