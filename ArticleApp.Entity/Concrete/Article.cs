using ArticleApp.Core.Entities;
using ArticleApp.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArticleApp.Entity.Concrete
{
    public class Article:IEntity
    {
        public int Id { get; set; }
        public string Uid { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Description { get; set; }
        public State State { get; set; }
        public DateTime LastEditDate { get; set; }
        public DateTime PublishedDate { get; set; }
        public bool isActive { get; set; }


        public List<ArticleCategory> ArticleCategories { get; set; }

        public List<Comment> Comments { get; set; }




    }
}
