using System;
using System.Collections.Generic;
using System.Text;

namespace ArticleApp.DTO.DTOs.Comment
{
    public class CommentAddDto
    {
        public string AuthorName { get; set; }
        public string AuthorEmail { get; set; }
        public string Content { get; set; }
        public DateTime CommentDate { get; set; }
        public int? ParentCommentId { get; set; }
        public int ArticleID { get; set; }
    }
}
