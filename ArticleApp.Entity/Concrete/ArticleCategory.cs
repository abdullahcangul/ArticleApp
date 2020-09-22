using ArticleApp.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArticleApp.Entity.Concrete
{
    public class ArticleCategory: IEntity
    {
       
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int ArticleId { get; set; }
        public Article Article { get; set; }
    }
}
