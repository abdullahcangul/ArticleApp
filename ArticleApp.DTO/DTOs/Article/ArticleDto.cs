using ArticleApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArticleApp.DTO.DTOs.Article
{
   public class ArticleDto
    {
        public int Id { get; set; }
        public string Uid { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Description { get; set; }
        public State State { get; set; }
        public DateTime LastEditDate { get; set; }
        public DateTime PublishedDate { get; set; }

    }
}
