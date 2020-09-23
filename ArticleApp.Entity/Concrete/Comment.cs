using ArticleApp.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace ArticleApp.Entity.Concrete
{
    public class Comment:IEntity
    {
        public int Id { get; set; }
        public string AuthorName { get; set; }
        public string AuthorEmail { get; set; }
        public string Content { get; set; }
        public DateTime CommentDate { get; set; }

        public int ArticleID { get; set; }
        public Article Article { get; set; }

        public int? ParentCommentId { get; set; }
        public Comment ParentComment { get; set; }

        public List<Comment> SubComments { get; set; }

    }
}
