using ArticleApp.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace ArticleApp.Entity.Concrete
{
    public class Category:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        
        public List<ArticleCategory> ArticleCategories { get; set; }


    }
}
