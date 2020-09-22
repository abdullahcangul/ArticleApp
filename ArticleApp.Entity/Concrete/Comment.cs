using System;
using System.Collections.Generic;
using System.Text;

namespace ArticleApp.Entity.Concrete
{
    public class Comment
    {
        public int Id { get; set; }
        public string Img { get; set; }
        public string Content { get; set; }
        public DateTime CommentDate { get; set; }

        public int ArticleID { get; set; }
        public Article Article { get; set; }

        public int? ReplyID { get; set; }
        public Comment Reply { get; set; }

    }
}
